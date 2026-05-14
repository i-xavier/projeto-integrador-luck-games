using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class FormGerenciarOrdem : Form
    {
        // STRING DE CONEXÃO
        string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";

        public FormGerenciarOrdem()
        {
            InitializeComponent();

            // CARREGA OS DADOS DAS COMBOBOX
            carregarTecnicos();
            carregarClientes();
        }

        // MÉTODO PARA CARREGAR TÉCNICOS
        private void carregarTecnicos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_funcionario, nome_funcionario
                                   FROM funcionario";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // COMBOBOX TÉCNICO
                    cmbTecnico.DataSource = dt;

                    cmbTecnico.DisplayMember = "nome_funcionario";

                    cmbTecnico.ValueMember = "id_funcionario";

                    cmbTecnico.SelectedIndex = -1;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao carregar técnicos: " + erro.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // MÉTODO PARA CARREGAR CLIENTES
        private void carregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_cliente, nome
                                   FROM cliente";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // COMBOBOX CLIENTE
                    cmbCliente.DataSource = dt;

                    cmbCliente.DisplayMember = "nome";

                    cmbCliente.ValueMember = "id_cliente";

                    cmbCliente.SelectedIndex = -1;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao carregar clientes: " + erro.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // BOTÃO FECHAR
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

        // BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // VERIFICA TÉCNICO
            if (cmbTecnico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um técnico.");
                return;
            }

            // VERIFICA CLIENTE
            if (cmbCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            int idTecnico = Convert.ToInt32(cmbTecnico.SelectedValue);

            string nomeTecnico = cmbTecnico.Text;

            int idCliente = Convert.ToInt32(cmbCliente.SelectedValue);

            string nomeCliente = cmbCliente.Text;

            MessageBox.Show(
                "DADOS SELECIONADOS:\n\n" +
                "TÉCNICO:\n" +
                "ID: " + idTecnico +
                "\nNome: " + nomeTecnico +
                "\n\nCLIENTE:\n" +
                "ID: " + idCliente +
                "\nNome: " + nomeCliente
            );
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}