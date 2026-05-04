using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormNovoAparelho : Form
    {
        public FormNovoAparelho()
        {
            InitializeComponent();
        }

        private void FormNovoAparelho_Load(object sender, EventArgs e)
        {
            // Opcional: preencher combos aqui

            cbTipodeAparelho.DataSource = new List<string>
            {
                "Celular",
                "Notebook",
                "Tablet",
                "Computador",
                "Impressora",
                "Outro"
            };

            cbEstado.DataSource = new List<string>
            {
                "Recebido",
                "Em análise",
                "Em reparo",
                "Pronto",
                "Entregue"
            };

            dtpDataEntrada.Value = DateTime.Now;
        }

        private void btnAnexarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Selecionar imagem",
                Filter = "Imagens (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Pegando valores
            string codigoCliente = txtCodigoDoCliente.Text;
            string marca = txtMarca.Text;
            string tipo = cbTipodeAparelho.Text;
            string numeroSerie = txtNumerodeSerie.Text;
            string modelo = txtModelo.Text;
            string estado = cbEstado.Text;
            DateTime dataEntrada = dtpDataEntrada.Value;
            string descricao = txtDescriçãoDoProblema.Text;

            // VALIDAÇÃO COMPLETA
            if (string.IsNullOrWhiteSpace(codigoCliente) ||
                string.IsNullOrWhiteSpace(marca) ||
                string.IsNullOrWhiteSpace(tipo) ||
                string.IsNullOrWhiteSpace(numeroSerie) ||
                string.IsNullOrWhiteSpace(modelo) ||
                string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return;
            }

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Anexe uma foto do aparelho!");
                return;
            }

            // SALVAR IMAGEM
            string pasta = @"C:\AparelhosImagens\";

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string caminhoImagem = Path.Combine(pasta, Guid.NewGuid() + ".jpg");

            pictureBox1.Image.Save(caminhoImagem, System.Drawing.Imaging.ImageFormat.Jpeg);

            // (Aqui futuramente entra o banco de dados)

            MessageBox.Show("Aparelho cadastrado com sucesso!");

            // LIMPAR CAMPOS
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCodigoDoCliente.Clear();
            txtMarca.Clear();
            txtNumerodeSerie.Clear();
            txtModelo.Clear();
            txtDescriçãoDoProblema.Clear();

            cbTipodeAparelho.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

            dtpDataEntrada.Value = DateTime.Now;

            pictureBox1.Image = null;
        }

    }
}