using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;



namespace projeto_integrador
{

    public partial class frmEsqueceuSenha : Form
    {
        public string Conexao { get; private set; } =
 "server=localhost;port=3306;database=projeto_luck_games;uid=root;pwd=;";



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



        public frmEsqueceuSenha()
        {



            InitializeComponent();
        }



        private void frmEsqueceuSenha_Load(object sender, EventArgs e)
        {



            // Labels
            lblNovaSenha.Visible = false;
            lblConfirmarSenha.Visible = false;



            // TextBox
            txtNovaSenha.Visible = false;
            txtConfirmarSenha.Visible = false;



            // Botão confirmar
            btnConfirmar.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button1.Visible = false;



            txtCodigo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width,
            txtCodigo.Height, 25, 25));



            txtConfirmarSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtConfirmarSenha.Width,
            txtConfirmarSenha.Height, 25, 25));



            txtNovaSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNovaSenha.Width,
            txtNovaSenha.Height, 25, 25));



            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width,
            panel1.Height, 30, 30));



            btnConfirmar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmar.Width,
            btnConfirmar.Height, 30, 30));



            cbPerguntaSecreta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbPerguntaSecreta.Width,
            cbPerguntaSecreta.Height, 20, 20));



            txtRespostaPerguntaSecreta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtRespostaPerguntaSecreta.Width,
            txtRespostaPerguntaSecreta.Height, 20, 20));



            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width,
            button1.Height, 20, 20));



            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button2.Width,
            button2.Height, 20, 20));



            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button3.Width,
            button3.Height, 20, 20));



            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button4.Width,
            button4.Height, 20, 20));
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.PasswordChar == '*')
            {
                button4.BringToFront();
                txtNovaSenha.PasswordChar = '\0';
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtNovaSenha.PasswordChar = '*';
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '*')
            {
                button1.BringToFront();
                txtConfirmarSenha.PasswordChar = '\0';
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtConfirmarSenha.PasswordChar == '\0')
            {
                button2.BringToFront();
                txtConfirmarSenha.PasswordChar = '*';
            }
        }







        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (cbPerguntaSecreta.SelectedIndex == -1 ||

            txtRespostaPerguntaSecreta.Text.Trim() == "" ||

            txtCodigo.Text.Trim() == "")

            {

                MessageBox.Show("Preencha todos os campos.");

                return;

            }







            int codigo = Convert.ToInt32(txtCodigo.Text);

            int idPergunta = Convert.ToInt32(cbPerguntaSecreta.SelectedValue);

            string respostaUsuario = txtRespostaPerguntaSecreta.Text.Trim().ToLower();







            using (MySqlConnection conn = new MySqlConnection(Conexao))

            {

                conn.Open();







                string sql = "SELECT resposta_secreta FROM funcionario WHERE id_funcionario = @codigo";







                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@codigo", codigo);

                cmd.Parameters.AddWithValue("@idPergunta", idPergunta);







                object resultado = cmd.ExecuteScalar();







                if (resultado == null)

                {

                    MessageBox.Show("Funcionário ou pergunta inválidos.");

                    return;

                }







                string respostaCorreta = resultado.ToString().ToLower();







                if (respostaUsuario == respostaCorreta)

                {

                    // MOSTRA LABEL + TEXTO + BOTÃO

                    lblNovaSenha.Visible = true;

                    txtNovaSenha.Visible = true;







                    lblConfirmarSenha.Visible = true;

                    txtConfirmarSenha.Visible = true;







                    btnConfirmar.Visible = true;

                    button2.Visible = true;

                    button3.Visible = true;

                    button4.Visible = true;

                    button1.Visible = true;







                    MessageBox.Show("Resposta correta! Defina sua senha.");

                }

                else

                {

                    //  ESCONDE TUDO DE NOVO

                    lblNovaSenha.Visible = false;

                    txtNovaSenha.Visible = false;







                    lblConfirmarSenha.Visible = false;

                    txtConfirmarSenha.Visible = false;







                    btnConfirmar.Visible = false;

                    button2.Visible = false;

                    button3.Visible = false;

                    button4.Visible = false;

                    button1.Visible = false;







                    MessageBox.Show("Resposta incorreta!",

                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // 1. Validar se os campos não estão vazios



            if (string.IsNullOrWhiteSpace(txtNovaSenha.Text) || string.IsNullOrWhiteSpace(txtConfirmarSenha.Text))

            {

                MessageBox.Show("Por favor, preencha ambos os campos de senha.");

                return;

            }



            // 2. Verificar se as senhas são idênticas

            if (txtNovaSenha.Text != txtConfirmarSenha.Text)

            {

                MessageBox.Show("As senhas não coincidem. Tente novamente.");

                return;

            }



            try

            {

                using (MySqlConnection conn = new MySqlConnection(Conexao))

                {

                    conn.Open();



                    // SQL para atualizar a senha baseando-se no ID do funcionário



                    // O campo 'senha' e a tabela 'funcionario' foram identificados em image_66c3ec.jpg



                    string sql = "UPDATE funcionario SET senha = @novaSenha WHERE id_funcionario = @codigo";


                    MySqlCommand cmd = new MySqlCommand(sql, conn);


                    // Parâmetros para evitar SQL Injection



                    cmd.Parameters.AddWithValue("@novaSenha", txtNovaSenha.Text);



                    cmd.Parameters.AddWithValue("@codigo", txtCodigo.Text);







                    int linhasAfetadas = cmd.ExecuteNonQuery();







                    if (linhasAfetadas > 0)



                    {



                        MessageBox.Show("Senha alterada com sucesso!");







                        // Opcional: Redirecionar para o login após o sucesso



                        frmLogin login = new frmLogin();



                        this.Hide();



                        login.ShowDialog();



                        this.Close();



                    }



                    else



                    {



                        MessageBox.Show("Erro ao atualizar a senha. Verifique o código do funcionário.");



                    }



                }



            }



            catch (Exception ex)



            {



                MessageBox.Show("Erro técnico: " + ex.Message);



            }

        }

    }

}