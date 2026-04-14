using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class Form3 : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        public Form3()
        {
            InitializeComponent();
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                //Validando campos obrigatórios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCargo.Text.Trim()) ||
                    string.IsNullOrEmpty(txtTelefone.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCodigoUser.Text.Trim()) ||
                    string.IsNullOrEmpty(txtSenha.Text.Trim()) ||
                    string.IsNullOrEmpty(txtConfirmarSenha.Text.Trim()))
                {
                    MessageBox.Show(
                    "Todos os campos devem ser preenchidos.",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;  // Impede o prosseguimento se algum campo estiver vazio
                }

                if (txtSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show(
                        "Senha Incorreta", 
                        "Erro", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    
                    return;
                }

                //validação do CPF
                /*string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show(
                        "Cpf Inválido. Certifique-se de que o CPF tenha 11 dígitos numéricos",
                        "Validação de CPF",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }*/

                //Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdoclientes(nomecompleto, nomesocial, email, cpf) " +
                    "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                //Adiciona os parâmetros com os dados do formulário
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@cargo", txtCargo.Text.Trim());
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", txtCodigoUser.Text.Trim());
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());
                cmd.Parameters.AddWithValue("@confirmarsenha", txtConfirmarSenha.Text.Trim());
                //cmd.Parameters.AddWithValue("@cpf", txtCodigoUser.Text.Trim());

                //Executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //Mensagem de sucesso
                MessageBox.Show(
                    "Contato inserido com Sucesso: ",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

                //Limpa os campos após o sucesso
                txtNomeCompleto.Clear();
                txtNomeSocial.Clear();
                txtEmail.Clear();
                txtCPF.Clear();

                //Recarrega os clientes na ListView
                carregar_clientes();

                //Muda para a aba de consulta
                tabControl.SelectedIndex = 1;
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechda, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

      
    }
}
