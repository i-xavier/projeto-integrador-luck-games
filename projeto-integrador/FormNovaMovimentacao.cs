using MySql.Data.MySqlClient;
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
    public partial class FormNovaMovimentacao : Form
    {

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";
        public FormNovaMovimentacao()
        {
            InitializeComponent();
            CarregarCombo();
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

        private void CarregarCombo()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(data_source))
                {
                    conn.Open();

                    //SELECT DISTINCT nome_produto FROM produto;

                    // 1. Carregar Produtos
                    FillComboBox(conn, "SELECT id_produto, nome_produto FROM produto", cbProduto, "nome_produto", "id_produto");
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
            cb.DataSource = dt;
            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.SelectedIndex = -1; // Deixa vazio por padrão
        }
    }
}
