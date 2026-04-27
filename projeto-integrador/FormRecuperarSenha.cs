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
    

