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

        public FormNovoProduto(string texto)
        {
            InitializeComponent();
            txtCodigoProduto.Text = texto;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                // Validando se os combos têm algo selecionado (SelectedIndex != -1)
                if (string.IsNullOrEmpty(txtNomeProduto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCodigoProduto.Text.Trim()) ||
                    //cbCategoria.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtQuantidade.Text.Trim()) ||
                    string.IsNullOrEmpty(txtQuantidadeMinima.Text.Trim()) ||
                   // cbFornecedor.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtValorUnitario.Text.Trim())
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
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // query
                /*cmd.CommandText = "INSERT INTO funcionario (nome_produto, fk_id_categoria, quantidade, estoque_minimo, fk_id_fornecedor, valor_unitario, fk_id_acesso, senha) " +
                                  "VALUES (@nome, @id_cargo, @telefone, @id_pergunta, @resposta, @id_acesso, @senha)";*/

                cmd.CommandText = "INSERT INTO produto (nome_produto, quantidade, valor_unitario) " +
                                  "VALUES (@nome_produto, @quantidade, @valor_unitario)";

                // Pegando o SelectedValue (o ID da tabela estrangeira)
                cmd.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text.Trim());
               // cmd.Parameters.AddWithValue("@id_categoria", cbCategoria.SelectedValue);
                cmd.Parameters.AddWithValue("@quantidade", txtQuantidade.Text.Trim());
               // cmd.Parameters.AddWithValue("@estoque_minimo", txtQuantidade.Text.Trim());
               // cmd.Parameters.AddWithValue("@id_fornecedor", cbFornecedor.SelectedValue);
                cmd.Parameters.AddWithValue("@valor_unitario", txtValorUnitario.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso");
                //LimparCampos();
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
