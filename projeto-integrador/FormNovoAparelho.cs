using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class FormNovoAparelho : Form
    {
      string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
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

            int flag = consultarCliente(txtCodigoDoCliente.Text.Trim());

            if (flag == 0)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro");
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
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string sql = @"INSERT INTO aparelho
        ( marca, tipo, num_serie, modelo, estado, data_entrada, fk_id_cliente, descricao_problema)
        VALUES
        ( @marca, @tipo, @num_serie, @modelo, @estado, @data_entrada, @cliente, @descricao_problema)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                       
                        cmd.Parameters.AddWithValue("@marca", marca);
                        cmd.Parameters.AddWithValue("@tipo", tipo);
                        cmd.Parameters.AddWithValue("@num_serie", numeroSerie);
                        cmd.Parameters.AddWithValue("@modelo", modelo);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@data_entrada", dataEntrada);
                        cmd.Parameters.AddWithValue("@cliente", codigoCliente);
                        cmd.Parameters.AddWithValue("@descricao_problema", descricao);
                      

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Aparelho cadastrado com sucesso!");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                //LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco: " + ex.Message);
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

        private int consultarCliente(string idCliente)
        {
            int flag = 0;


            string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string query = "SELECT id_cliente FROM cliente WHERE id_cliente = @cliente";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = idCliente;
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            flag = 1;

                        }
                    }
                }
            }

            return flag;

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            DialogResult resultado = MessageBox.Show(
            "Deseja realmente fechar?",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}