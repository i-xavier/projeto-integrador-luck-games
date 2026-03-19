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
    public partial class frmLogin : Form
    {
        String codUser = "123";
        String senhaUser = "123";
        public frmLogin()
        {
            InitializeComponent();

            this.ClientSize = new Size(550, 600);
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
            


            if (txtCodigoUser.Text == codUser && txtSenha.Text == senhaUser)
            {
                MessageBox.Show("Bem-vindo!");
            }

            else
            {
                MessageBox.Show("Senha incorreta.");
                   
            }

        }
    }
}
