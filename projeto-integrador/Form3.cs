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
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        public Form3(string texto)
        {
            InitializeComponent();
            txtCodigoUser.Text = texto;
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


                //validação do Telefone
                string telefone = txtTelefone.Text.Trim();

                if (!isValidTelefoneLength(telefone))
                {
                    MessageBox.Show(
                        "Telefone Inválido. Certifique-se de que o Telefone tenha 11 dígitos numéricos",
                        "Validação de Telefone",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                //Cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();
                cmd.CommandText = "INSERT INTO funcionario (nome_funcionario, cargo, telefone, tipo_acesso, senha) " +
                    "VALUES(@nome_funcionario, @cargo, @telefone, @tipo_acesso, @senha)";

                //Adiciona os parâmetros com os dados do formulário
                cmd.Parameters.AddWithValue("@nome_funcionario", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@cargo", txtCargo.Text.Trim());
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text.Trim());
                cmd.Parameters.AddWithValue("@tipo_acesso", txtCodigoUser.Text.Trim());
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

                //cmd.Parameters.AddWithValue("@cpf", txtCodigoUser.Text.Trim());

                //Executa o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //Mensagem de sucesso
                MessageBox.Show(
                    "Funcionario cadastrado com sucesso: ",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

               //Limpa os campos após o sucesso
                txtNomeCompleto.Clear();
                txtCargo.Clear();
                txtTelefone.Clear();
                //cbTipoAcesso.Clear;
                txtSenha.Clear();

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

        /*
        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //Cria a conexão ocm o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resulttados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adiocnar novos
                lstCliente.Items.Clear();

                //Preenche o ListView com os dados dos cliente
                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)), //Código
                        reader.GetString(1),                    //Nome Completo
                        reader.GetString(2),                    //Nome Social
                        reader.GetString(3),                    //E-mail
                        reader.GetString(4),                     //CPF
                    };

                    //Adiicona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
                }

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

        private void carregar_clientes(int)
        {
            string query = "SELECT MAX(id_funcionario) AS maior_id FROM funcionario";
            carregar_clientes_com_query(query);
        }
        */

        private bool isValidTelefoneLength(string telefone)
        {
            // Remove todos os caracteres não númericos
            telefone = new string(telefone.Where(char.IsDigit).ToArray());

            // Verifica se o CPF tem exatamente 11 dígitos;
            return telefone.Length == 11;
        }

    }
}
