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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();

            //Configuração inciial do ListView para exibição dos dados dos clientes
            lstProduto.View = View.Details; //Define a visualização em "detalhes"
            lstProduto.LabelEdit = true; //Permite editar os títulos das colunas
            lstProduto.AllowColumnReorder = true; //Permite reordenar as colunas
            lstProduto.FullRowSelect = true; //Seleciona a linha inteira ao clica
            lstProduto.GridLines = false; //Exibe a slinhas de grade no ListView
            lstProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstProduto.OwnerDraw = true;



            lstProduto.DrawColumnHeader += (sender, e) =>
            {
                using (Brush backBrush = new SolidBrush(Color.Black)) // cor do fundo
                using (Brush textBrush = new SolidBrush(Color.White))    // cor do texto
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, e.Font, textBrush, e.Bounds);
                }
            };

            lstProduto.DrawItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            lstProduto.DrawSubItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            //Definindo as colunas do ListView

            lstProduto.Columns.Add("ID", 79, HorizontalAlignment.Left); //Coluna do Código
            lstProduto.Columns.Add("Nome da peça", 158, HorizontalAlignment.Left);//Coluna do Nome da peça
            lstProduto.Columns.Add("Categoria", 158, HorizontalAlignment.Left);//Coluna da categoria
            lstProduto.Columns.Add("Quantidade", 158, HorizontalAlignment.Left);//Coluna da quantidade
            lstProduto.Columns.Add("Valor unitário", 158, HorizontalAlignment.Left);//Coluna do valor unitário
            lstProduto.Columns.Add("Fornecedor", 158, HorizontalAlignment.Left);//Coluna do fornecedor

            AjustarColunasIgualmente();

            lstProduto.Resize += (s, e) => AjustarColunasIgualmente();
            this.Resize += (s, e) => AjustarColunasIgualmente();
        }

        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            FormCadastrarMovimentacao form = new FormCadastrarMovimentacao();
            form.ShowDialog();
        }

        private void AjustarColunasIgualmente()
        {
            int totalColunas = lstProduto.Columns.Count;
            if (totalColunas == 0) return;

            int larguraTotal = lstProduto.ClientSize.Width;
            int larguraBase = larguraTotal / totalColunas;
            int resto = larguraTotal % totalColunas;

            for (int i = 0; i < totalColunas; i++)
            {
                lstProduto.Columns[i].Width = larguraBase;

                if (resto > 0)
                {
                    lstProduto.Columns[i].Width += 1;
                    resto--;
                }
            }
        }
    }
}
