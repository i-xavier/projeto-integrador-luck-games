using Google.Protobuf.WellKnownTypes;
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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new FormDashboard());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCliente());
        }

        private void btnOrdens_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrdemDeServico());
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFundo.Controls.Add(childForm); 
            panelFundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja se deslogar?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAparelhos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAparelho());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEstoque());
        }

        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            botao.BackColor = Color.FromArgb(168, 217, 95);
            botao.ForeColor = Color.White;
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            botao.BackColor = Color.FromArgb(13, 52, 68);
            botao.ForeColor = Color.White;
        }
    }
}
