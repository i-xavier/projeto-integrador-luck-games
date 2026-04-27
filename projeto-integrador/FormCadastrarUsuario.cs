using MySql.Data.MySqlClient;
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
    public partial class FormCadastrarUsuario : Form
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

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        public FormCadastrarUsuario(string texto)
        {
            InitializeComponent();
            txtCodigoUser.Text = texto; 

            // Importante carregar os dados assim que o form abrir
            CarregarTodosOsCombos();
        }

        // Método para buscar dados das tabelas normalizadas e colocar nos Combos
        private void CarregarTodosOsCombos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();

                    // 1. Carregar Cargos
                    FillComboBox(conn, "SELECT id_cargo, nome_cargo FROM cargo", cbCargo, "nome_cargo", "id_cargo");

                    // 2. Carregar Perguntas
                    FillComboBox(conn, "SELECT id_pergunta, texto_pergunta FROM pergunta_seguranca", cbPerguntaSecreta, "texto_pergunta", "id_pergunta");

                    // 3. Carregar Níveis de Acesso
                    FillComboBox(conn, "SELECT id_acesso, nome_nivel FROM nivel_acesso", cbTipoAcesso, "nome_nivel", "id_acesso");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados iniciais: " + ex.Message);
            }
        }

        // Função auxiliar para evitar repetição de código ao encher combos
        private void FillComboBox(MySqlConnection conn, string query, ComboBox cb, string display, string value)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.SelectedIndex = -1; // Deixa vazio por padrão
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validando se os combos têm algo selecionado (SelectedIndex != -1)
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    cbCargo.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtTelefone.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCodigoUser.Text.Trim()) ||
                    string.IsNullOrEmpty(txtSenha.Text.Trim()) ||
                    cbPerguntaSecreta.SelectedIndex == -1 ||
                    string.IsNullOrEmpty(txtRespostaPerguntaSecreta.Text.Trim()) ||
                    cbTipoAcesso.SelectedIndex == -1)
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Validação");
                    return;
                }

                if (txtSenha.Text != txtConfirmarSenha.Text)
                {
                    MessageBox.Show("As senhas não coincidem.", "Erro");
                    return;
                }

                string telefone = txtTelefone.Text.Trim();
                if (!isValidTelefoneLength(telefone))
                {
                    MessageBox.Show("Telefone deve ter 11 dígitos.", "Validação");
                    return;
                }

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // query 
                cmd.CommandText = "INSERT INTO funcionario (nome_funcionario, fk_id_cargo, telefone, fk_id_pergunta, resposta_secreta, fk_id_acesso, senha) " +
                                  "VALUES (@nome, @id_cargo, @telefone, @id_pergunta, @resposta, @id_acesso, @senha)";

                // Pegando o SelectedValue (o ID da tabela estrangeira)
                cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@id_cargo", cbCargo.SelectedValue);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@id_pergunta", cbPerguntaSecreta.SelectedValue);
                cmd.Parameters.AddWithValue("@resposta", txtRespostaPerguntaSecreta.Text.Trim());
                cmd.Parameters.AddWithValue("@id_acesso", cbTipoAcesso.SelectedValue);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text.Trim());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso");
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();
            }
        }

        private void LimparCampos()
        {
            txtNomeCompleto.Clear();
            txtTelefone.Clear();
            txtRespostaPerguntaSecreta.Clear();
            txtSenha.Clear();
            txtConfirmarSenha.Clear();
            txtCodigoUser.Clear();
            cbCargo.SelectedIndex = -1;
            cbPerguntaSecreta.SelectedIndex = -1;
            cbTipoAcesso.SelectedIndex = -1;
        }

        private bool isValidTelefoneLength(string telefone)
        {
            telefone = new string(telefone.Where(char.IsDigit).ToArray());
            return telefone.Length == 11;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin form = new frmLogin();
            this.Hide();
            this.Close();
            form.ShowDialog();
        }

        private void FormCadastrarUsuario_Load(object sender, EventArgs e)
        {
            txtCodigoUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCodigoUser.Width,
               txtCodigoUser.Height, 25, 25));

            txtConfirmarSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtConfirmarSenha.Width,
               txtConfirmarSenha.Height, 25, 25));

            txtNomeCompleto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNomeCompleto.Width,
               txtNomeCompleto.Height, 25, 25));

            txtRespostaPerguntaSecreta.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtRespostaPerguntaSecreta.Width,
               txtRespostaPerguntaSecreta.Height, 25, 25));

            txtSenha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtSenha.Width,
               txtSenha.Height, 25, 25));

            txtTelefone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtTelefone.Width,
               txtTelefone.Height, 25, 25));

            btnConfirmar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnConfirmar.Width,
               btnConfirmar.Height, 25, 25));

            panelCadUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelCadUser.Width,
               panelCadUser.Height, 25, 25));
        }
    }
}