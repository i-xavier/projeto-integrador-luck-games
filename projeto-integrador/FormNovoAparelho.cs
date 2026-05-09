using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class FormNovoAparelho : Form
    {
        string conexao = "server=localhost;database=projeto_luck_games;user=root;password=;";
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

            this.Shown += (s, ev) =>
            {
                GraphicsPath path = new GraphicsPath();
                int raio = 20;

                path.AddArc(0, 0, raio, raio, 180, 90);
                path.AddArc(btnFechar.Width - raio, 0, raio, raio, 270, 90);
                path.AddArc(btnFechar.Width - raio, btnFechar.Height - raio, raio, raio, 0, 90);
                path.AddArc(0, btnFechar.Height - raio, raio, raio, 90, 90);
                path.CloseAllFigures();

                btnFechar.Region = new Region(path);
            };
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

            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"INSERT INTO aparelho 
        (codigo_cliente, marca, tipo, num_serie, modelo, estado, data_entrada, descricao_problema)
        VALUES 
        (@codigo, @marca, @tipo, @num_serie, @modelo, @estado, @data, @descricao_problema)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@codigo", codigoCliente);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@num_serie", numeroSerie);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@data", dataEntrada);
                    cmd.Parameters.AddWithValue("@descricao_problema", descricao);
                   

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Salvo no banco com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
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

        private void btnFechar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
                "Tem certeza que deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.DarkRed;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Red;
        }

    
    }
}