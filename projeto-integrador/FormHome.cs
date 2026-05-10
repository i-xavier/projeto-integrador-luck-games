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
            this.Close();
        }

        private void btnAparelhos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAparelho());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEstoque());
        }
    }
}
