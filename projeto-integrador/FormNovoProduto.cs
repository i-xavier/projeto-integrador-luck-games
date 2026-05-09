using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormNovoProduto : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        public FormNovoProduto(string proximoCodigo)
        {
            InitializeComponent();
            txtCodigoProduto.Text = proximoCodigo;
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
           "Deseja realmente fechar?",
           "Confirmação",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question
           );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormNovoProduto_Load(object sender, EventArgs e)
        {
            cbCategoria.DataSource = new List<string>
            {
                "Celular",
                "Notebook",
                "Tablet",
                "Computador",
                "Impressora",
                "Outro"
            };

         
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                // Validando se os combos têm algo selecionado (SelectedIndex != -1)
                if (string.IsNullOrEmpty(txtNomeProduto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCodigoProduto.Text.Trim()) ||
                    //cbCategoria.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtQuantidade.Text.Trim()) ||
                    string.IsNullOrEmpty(txtQuantidadeMinima.Text.Trim()) //||
                                                                          // cbFornecedor.SelectedIndex == -1 ||
                    /*string.IsNullOrEmpty(txtValorUnitario.Text.Trim())*/
                    /*cbTipoAcesso.SelectedIndex == -1*/)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Validação");
                    return;
                }

                /* if (txtSenha.Text != txtConfirmarSenha.Text)
                 {
                     MessageBox.Show("As senhas não coincidem.", "Erro");
                     return;
                 }

                 string telefone = txtTelefone.Text.Trim();
                 if (!isValidTelefoneLength(telefone))
                 {
                     MessageBox.Show("Telefone deve ter 11 dígitos.", "Validação");
                     return;
                 }
                */
                string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";

                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string sql = "INSERT INTO produto(nome_produto, quantidade_minima, valor_unitario, quantidade_total, categoria) " +
                 "VALUES(@nome, @quantidade_minima, @valor_unitario, @quantidade_total, @categoria)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {

                        cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNomeProduto.Text;
                        cmd.Parameters.Add("@quantidade_minima", MySqlDbType.Int32).Value =
                            int.Parse(txtQuantidadeMinima.Text);
                        cmd.Parameters.Add("@valor_unitario", MySqlDbType.Decimal).Value =
                            decimal.Parse(txtValorUnitario.Text);
                        cmd.Parameters.Add("@quantidade_total", MySqlDbType.Int32).Value =
                            int.Parse(txtQuantidade.Text);
                        cmd.Parameters.Add("@categoria", MySqlDbType.VarChar).Value =
                            cbCategoria.SelectedItem.ToString();
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();


                        MessageBox.Show("Produto cadastrado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }

        /* private void LimparCampos()
         {
             txtNomeCompleto.Clear();
             txtTelefone.Clear();
             txtRespostaPerguntaSecreta.Clear();
             txtSenha.Clear();
             txtConfirmarSenha.Clear();
             txtCodigoUser.Clear();
             cbCargo.SelectedIndex = -1;
             cbPerguntaSecreta.SelectedIndex = -1;
             cbTipoAcesso.SelectedIndex = -1;
         }*/
    }
}
