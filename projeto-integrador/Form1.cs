using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace projeto_integrador
{
    public partial class frmLogin : Form
    {
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
            Form3 form = new Form3();
            this.Hide();
            this.Close();
            form.ShowDialog();

        }

       
    }
}