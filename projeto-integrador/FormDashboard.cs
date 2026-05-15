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
    public partial class FormDashboard : Form
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

        string data_source = "server=localhost;username=root;password=;database=projeto_luck_games";

        public FormDashboard()
        {
            InitializeComponent();
            CarregarContadores();
        }

        private void CarregarContadores()
        {
            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                try
                {
                    conn.Open();

                    // 1. BUSCA TOTAL DE CLIENTES
                    string sqlClientes = "SELECT COUNT(*) FROM cliente";
                    MySqlCommand cmdClientes = new MySqlCommand(sqlClientes, conn);
                    lblTotalClientes.Text = cmdClientes.ExecuteScalar().ToString();

                    // 2. BUSCA ORDENS FINALIZADAS (Aprovação = 'Sim')
                    // Ajuste o nome da coluna 'aprovacao_orcamento' se no seu banco estiver diferente
                    string sqlOrdens = "SELECT COUNT(*) FROM ordem WHERE aprovacao_orcamento = 'Aprovado'";
                    MySqlCommand cmdOrdens = new MySqlCommand(sqlOrdens, conn);
                    lblOrdensFinalizadas.Text = cmdOrdens.ExecuteScalar().ToString();

                    // 3. BUSCA TOTAL DE PEÇAS NO ESTOQUE (Soma da coluna quantidade_total)
                    string sqlEstoque = "SELECT SUM(quantidade_total) FROM produto";
                    MySqlCommand cmdEstoque = new MySqlCommand(sqlEstoque, conn);

                    object resultadoEstoque = cmdEstoque.ExecuteScalar();
                    // O tratamento abaixo evita que o programa trave se o estoque estiver vazio (null)
                    if (resultadoEstoque != DBNull.Value && resultadoEstoque != null)
                    {
                        lblPeçasEstoque.Text = resultadoEstoque.ToString();
                    }
                    else
                    {
                        lblPeçasEstoque.Text = "0";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro técnico ao carregar Dashboard: " + ex.Message,
                                    "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarContadoresDashboard();

            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                try
                {
                    conn.Open();
                    // Esta query organiza os dados para aparecerem igual à sua tabela (ID, Status, Valor, etc)
                    string sql = @"SELECT id_ordem AS 'ID', 
                                  aprovacao_orcamento AS 'Status', 
                                  valor AS 'Valor', 
                                  data_ordem AS 'Data', 
                                  fk_id_cliente AS 'Cliente', 
                                  fk_id_aparelho AS 'Aparelho', 
                                  fk_id_funcionario AS 'Funcionario' 
                           FROM ordem";

                    MySqlDataAdapter da = new MySqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    

                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar lista: " + ex.Message);
                }
            }
        }

        private void AtualizarContadoresDashboard()
        {
            throw new NotImplementedException();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
              panel3.Height, 25, 25));

            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
              panel2.Height, 25, 25));

            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
              panel4.Height, 25, 25));

            btnAtualizar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAtualizar.Width,
              btnAtualizar.Height, 25, 25));
        }
    }
}
