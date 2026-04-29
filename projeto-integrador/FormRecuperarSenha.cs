using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
    }
    

