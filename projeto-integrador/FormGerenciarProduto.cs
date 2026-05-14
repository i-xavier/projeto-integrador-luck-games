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
    public partial class FormGerenciarProduto : Form
    {
        private bool _isEdicao = false;
        private int _idProdutoParaEditar;
        MySqlConnection Conexao;
        //string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        public FormGerenciarProduto(string proximoCodigo)
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
                int flag = 0;
                string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
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

               
                 if (_isEdicao)
{
    // MODO EDIÇÃO: Usamos UPDATE
    using (MySqlConnection conn = new MySqlConnection(conexao))
    {
                        // Removido o parêntese incorreto após @CPF e ajustado o WHERE
                        string sql = @"UPDATE produto SET 
                       nome_produto = @nome, 
                       quantidade_minima = @quantidade_minima, 
                       valor_unitario = @valor_unitario, 
                       quantidade_total = @quantidade_total, 
                       categoria = @categoria 
                       WHERE id_produto = @idproduto";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = txtNomeProduto.Text;
                            cmd.Parameters.Add("@quantidade_minima", MySqlDbType.Int32).Value = int.Parse(txtQuantidadeMinima.Text);
                            cmd.Parameters.Add("@valor_unitario", MySqlDbType.Decimal).Value = decimal.Parse(txtValorUnitario.Text);
                            cmd.Parameters.Add("@quantidade_total", MySqlDbType.Int32).Value = int.Parse(txtQuantidade.Text);
                            cmd.Parameters.Add("@categoria", MySqlDbType.VarChar).Value = cbCategoria.SelectedItem.ToString();
                            cmd.Parameters.AddWithValue("@idproduto", _idProdutoParaEditar);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Produto atualizado com sucesso!");
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
}
else
{
    // MODO CADASTRO: Usamos INSERT
    flag = consultarProduto(txtNomeProduto.Text.Trim());

                if (flag == 1)
                 {
                     MessageBox.Show("Produto já existe.", "Erro");
                     return;
                 }

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

        private int consultarProduto(string nomeProduto)
        {
            int flag = 0;

            
                string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    string query = "SELECT * FROM produto WHERE nome_produto = @nome";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nomeProduto;
                        conn.Open();
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                flag = 1;
                              
                            }
                        }
                    }
                }

            return flag;
            
        }

        public void ConfigurarEdicao(int id, string nome, string categoria, int quantidadeMinima, decimal valorUnitario, int quantidadeTotal)

        {

            _isEdicao = true;

            _idProdutoParaEditar = id;



            // Altera os textos dos componentes

            this.Text = "Editar Produto"; // Título da janela

            lblTitulo.Text = "Editar Dados";

            btnCadastrarProduto.Text = "Salvar Alterações";

            // Preenche os campos com os dados que vieram do Grid

            txtNomeProduto.Text = nome;

            cbCategoria.SelectedItem = categoria;

            txtQuantidadeMinima.Text = quantidadeMinima.ToString();

            txtValorUnitario.Text = valorUnitario.ToString();

            txtQuantidade.Text = quantidadeTotal.ToString();

            txtCodigoProduto.Text = id.ToString();

        }
    }
}
