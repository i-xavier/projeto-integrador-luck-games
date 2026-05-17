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


using System.Runtime.InteropServices;
namespace projeto_integrador
{
    public partial class frmLogin : Form
    {

        String Valor = "";
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeft,
                int nTop,
                int nRight,
                int nBottom,
                int nWidthEllipse,
                int nHeightEllipse
            );

        public frmLogin()
        {
            InitializeComponent();
            this.ClientSize = new Size(550, 600);
            this.Load += frmLogin_Load;
            panel1.Resize += panel1_Resize;
            this.AcceptButton = btnEntrar;
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
            int codigo;
            string senha = txtSenha.Text.Trim();



                if (!int.TryParse(txtCodigoUser.Text, out codigo))
                {
                    MessageBox.Show("Digite um código válido.");
                    return;
                }




            string sql =
                "SELECT id_funcionario, nome_funcionario " +
                "FROM funcionario " +
                "WHERE id_funcionario = @codigo " +
                "AND senha = @senha";


            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);
                    cmd.Parameters.AddWithValue("@senha", senha);



                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();



                    if (dr.Read())
                    {
                        MessageBox.Show("Bem-vindo, " + dr["nome_funcionario"]);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Código ou senha incorretos");
                        txtSenha.Clear();
                        txtCodigoUser.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }


        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
                panel1.Height, 25, 25));

            txtCodigoUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigoUser.Width,
                txtCodigoUser.Height, 30, 30));

            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtSenha.Width,
               txtSenha.Height, 30, 30));

            btnEntrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEntrar.Width,
                btnEntrar.Height, 38, 38));

            btnCriarconta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCriarconta.Width,
                btnCriarconta.Height, 38, 38));

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
            /* try
             {
                 carregar_clientes();
                 FormCadastrarUsuario form = new FormCadastrarUsuario(Valor);
                 this.Hide();
                 form.ShowDialog();
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao abrir cadastro: " + ex.Message);
             }*/
            try
            {
                carregar_clientes();
                FormCadastrarUsuario form = new FormCadastrarUsuario(Valor);
                this.Hide(); // Esconde o login
                form.ShowDialog(); // Trava a execução aqui até o cadastro fechar
                this.Show(); // FAÇA ISSO: Mostra o login de volta quando sair do cadastro
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir cadastro: " + ex.Message);
                this.Show(); // Garante que o login volte se der erro
            }

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
                    if (reader.IsDBNull(0))
                    {
                        Valor = "1"; // Valor padrão se a tabela estiver vazia
                    }
                    else
                    {
                        Valor = Convert.ToString(reader.GetInt32(0) + 1);
                    }
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
            string query = "SELECT COALESCE(MAX(id_funcionario), 0) FROM funcionario;";
            carregar_clientes_com_query(query);
        }

        private void lblAlterasenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEsqueceuSenha form = new frmEsqueceuSenha();

            this.Hide();

            form.ShowDialog();

            this.Show();
        }
        
        private void btnOlhoAberto_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                btnOlhoFechado.BringToFront();
                txtSenha.PasswordChar = '\0';
            }
        }

        private void btnOlhoFechado_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '\0')
            {
                btnOlhoAberto.BringToFront();
                txtSenha.PasswordChar = '*';
            }
        }
    }
}