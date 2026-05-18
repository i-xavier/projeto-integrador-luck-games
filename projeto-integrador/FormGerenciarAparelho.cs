using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormGerenciarAparelho : Form
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

        private bool _isEdicao = false;
        private int _idAparelhoParaEditar;
        string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
        public FormGerenciarAparelho()
        {
            InitializeComponent();
            CarregarCombo();



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
            string codigoCliente = cbClientes.SelectedValue.ToString();
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

            int flag = consultarCliente(cbClientes.SelectedValue.ToString().Trim());

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
                if (_isEdicao)
                {
                    // MODO EDIÇÃO: Usamos UPDATE
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
                        conn.Open();

                        string sql = @"UPDATE aparelho SET 
                        marca = @marca, 
                        tipo = @tipo, 
                        num_serie = @num_serie, 
                        modelo = @modelo, 
                        estado = @estado, 
                        data_entrada = @data_entrada, 
                        fk_id_cliente_aparelho = @cliente, 
                        descricao_problema = @descricao_problema 
                      WHERE id_aparelho = @idaparelho";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@marca", marca);
                            // Use .Text para garantir que envie a string selecionada
                            cmd.Parameters.AddWithValue("@tipo", cbTipodeAparelho.Text);
                            cmd.Parameters.AddWithValue("@num_serie", numeroSerie);
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@estado", cbEstado.Text);
                            cmd.Parameters.AddWithValue("@data_entrada", dataEntrada);
                            cmd.Parameters.AddWithValue("@cliente", codigoCliente);
                            cmd.Parameters.AddWithValue("@descricao_problema", descricao);

                            // LINHA ESSENCIAL QUE ESTAVA FALTANDO:
                            cmd.Parameters.AddWithValue("@idaparelho", _idAparelhoParaEditar);

                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Aparelho atualizado com sucesso!");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }

                }
                else
                {
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
                        conn.Open();

                        string sql = @"INSERT INTO aparelho
        ( marca, tipo, num_serie, modelo, estado, data_entrada, fk_id_cliente_aparelho, descricao_problema)
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
            cbClientes.SelectedIndex = -1;
            txtMarca.Clear();
            txtNumerodeSerie.Clear();
            txtModelo.Clear();
            txtDescriçãoDoProblema.Clear();

            cbTipodeAparelho.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;

            dtpDataEntrada.Value = DateTime.Now;

            pictureBox1.Image = null;
        }

        private void CarregarCombo()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    // 1. Carregar Clientes
                    FillComboBox(conn, "SELECT id_cliente, nome FROM cliente", cbClientes, "nome", "id_cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados iniciais: " + ex.Message);
            }

        }

        private void FillComboBox(MySqlConnection conn, string query, ComboBox cb, string display, string value)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // Criamos uma nova coluna no C# que combina os dados
            // Vamos chamar essa coluna de "exibicao_completa"
            dt.Columns.Add("exibicao_completa", typeof(string), "id_cliente + ' - ' + nome");

            cb.DataSource = dt;
            cb.DisplayMember = "exibicao_completa"; // Usamos a coluna que acabamos de criar
            cb.ValueMember = value; // Continua sendo id_cliente
            // Filtro inteligente
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;

            cb.SelectedIndex = -1;
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

        public void ConfigurarEdicao(int id, string marca, string modelo, string tipo, string numSerie, string fkIdCliente, string dataEntrada, string estado)

        {

            _isEdicao = true;

            _idAparelhoParaEditar = id;



            // Altera os textos dos componentes

            this.Text = "Editar Aparelho"; // Título da janela

            lblTitulo.Text = "Editar Dados";

            btnCadastrarAparelho.Text = "Salvar Alterações";



            // Preenche os campos com os dados que vieram do Grid

            txtMarca.Text = marca;

            txtModelo.Text = modelo;

            cbTipodeAparelho.SelectedValue = tipo;

            txtNumerodeSerie.Text = numSerie;

            cbClientes.SelectedValue = fkIdCliente;

            dtpDataEntrada.Value = DateTime.Parse(dataEntrada);

            cbEstado.SelectedValue = estado;
            //txtID.Text = id.ToString();

        }

        private void FormGerenciarAparelho_Load(object sender, EventArgs e)
        {
            btnCadastrarAparelho.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnCadastrarAparelho.Width,
                btnCadastrarAparelho.Height, 25, 25));

            dtpDataEntrada.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtpDataEntrada.Width,
                dtpDataEntrada.Height, 25, 25));

            cbClientes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbClientes.Width,
                cbClientes.Height, 25, 25));

            cbEstado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbEstado.Width,
                cbEstado.Height, 25, 25));

            cbTipodeAparelho.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbTipodeAparelho.Width,
                cbTipodeAparelho.Height, 25, 25));

            txtDescriçãoDoProblema.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtDescriçãoDoProblema.Width,
                txtDescriçãoDoProblema.Height, 25, 25));

            txtMarca.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtMarca.Width,
                txtMarca.Height, 25, 25));

            txtModelo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtModelo.Width,
                txtModelo.Height, 25, 25));

            txtNumerodeSerie.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNumerodeSerie.Width,
                txtNumerodeSerie.Height, 25, 25));
        }

        //Load para carregar o arredondamento de tela
        /* private void FormGerenciarAparelho_Load(object sender, EventArgs e)
         {
             txtCodigo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigo.Width,
             txtCodigo.Height, 25, 25));
         }*/
    }
}