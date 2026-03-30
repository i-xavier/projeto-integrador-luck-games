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
            openChildForm(new FormClientes());
        }

        private void btnOrdens_Click(object sender, EventArgs e)
        {
            openChildForm(new FormOrdens());
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEstoque());
        }

        private void btnAparelhos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAparelhos());
        }

        private void btnAcompanhamento_Click(object sender, EventArgs e)
        {
            openChildForm(new FormAcompanhamento());
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
            panelFundo.Controls.Add(childForm); // ← nome correto agora
            panelFundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
