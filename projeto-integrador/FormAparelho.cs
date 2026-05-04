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
    public partial class FormAparelho : Form
    {
        public FormAparelho()
        {
            InitializeComponent();
        }

        private void btnNovoAparelho_Click(object sender, EventArgs e)
        {
            FormNovoAparelho form = new FormNovoAparelho(); // cria novo form
            form.Show(); // abre sem bloquear
        }
    }
    }
    
    
    

