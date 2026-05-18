using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormVisualizarAparelho : Form
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


        private string idAparelho;

        public FormVisualizarAparelho(string id)
        {
            InitializeComponent();

            idAparelho = id;
        }

        private void FormVisualizarAparelho_Load(object sender, EventArgs e)
        {
            textBoxCodigodoProduto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxCodigodoProduto.Width,
                textBoxCodigodoProduto.Height, 25, 25));

            textBoxValorUnitario.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxValorUnitario.Width,
                textBoxValorUnitario.Height, 25, 25));

            textBoxQuantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBoxQuantidade.Width,
               textBoxQuantidade.Height, 25, 25));

            txtNomedoProduto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNomedoProduto.Width,
               txtNomedoProduto.Height, 25, 25));
        }
    }
}