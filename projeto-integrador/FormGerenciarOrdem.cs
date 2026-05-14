using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class FormGerenciarOrdem : Form
    {
        // STRING DE CONEXÃO
        string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";

        public FormGerenciarOrdem(string texto)
        {
            InitializeComponent();

            // CARREGA OS TÉCNICOS NA COMBOBOX
            carregarTecnicos();
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

                    // COMBOBOX
                    cmbTecnico.DataSource = dt;

                    cmbTecnico.DisplayMember = "nome_funcionario";

                    cmbTecnico.ValueMember = "id_funcionario";

                    // INICIA SEM SELEÇÃO
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

        // EXEMPLO PARA PEGAR O TÉCNICO SELECIONADO
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um técnico.");
                return;
            }

            int idTecnico = Convert.ToInt32(cmbTecnico.SelectedValue);

            string nomeTecnico = cmbTecnico.Text;

            MessageBox.Show(
                "Técnico selecionado:\n\n" +
                "ID: " + idTecnico +
                "\nNome: " + nomeTecnico
            );
        }
    }
}