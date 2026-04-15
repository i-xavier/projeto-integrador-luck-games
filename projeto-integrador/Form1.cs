using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class frmLogin : Form
    {
        String Valor = "";
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";
        String codUser = "123";
        String senhaUser = "123";
        public frmLogin()
        {
            InitializeComponent();
            this.ClientSize = new Size(550, 600);
            this.Load += frmLogin_Load;
            panel1.Resize += panel1_Resize;
        }

        private void frmLogin_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ClientSize = new Size(550, 600);
            }

            CentralizarPanel();
        }

        private void CentralizarPanel()
        {
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
        }

        private void Logar(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoUser.Text.Equals(codUser) && txtSenha.Text.Equals(senhaUser))
                {
                    this.DialogResult = DialogResult.OK; // sinaliza sucesso e fecha
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha incorretos.",
                                    "Falha",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    txtCodigoUser.Focus();
                    txtSenha.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desculpe",
                                ex.Message,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            ArredondarPainel(panel1, 30);
        }

        private void panel1_Resize(object sender, EventArgs e)
        {
            ArredondarPainel(panel1, 30);
        }

        private void ArredondarPainel(Panel panel, int raio)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(panel.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(panel.Width - raio, panel.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, panel.Height - raio, raio, raio, 90, 90);

            path.CloseFigure();

            panel.Region = new Region(path);
        }

        private void CriarConta(object sender, EventArgs e)
        {
            carregar_clientes();
            Form3 form = new Form3(Valor);
            this.Hide();
            this.Close();
            form.ShowDialog();

        }

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

                //Executa o comando e obtém os resulttados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adiocnar novos
                //lstCliente.Items.Clear();

                //Preenche o ListView com os dados dos cliente
                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0) + 1), //Código
                    };

                    //Adiciona a linha ao ListView
                    


                    Valor = row[0];
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

        private void carregar_clientes()
        {
            string query = "SELECT MAX(id_funcionario) FROM funcionario;";
            carregar_clientes_com_query(query);
        }
    }
}