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
    public partial class FormOrdemDeServico : Form
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



        String codOrdem = "";
        

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";
        public FormOrdemDeServico()
        {
            InitializeComponent();

           cmbFiltro.DataSource = new List<string>
            {
                "Selecione",
                "Status",
                "Valor",
                "Data",
                "Cliente",
                "Aparelho",
                "Funcionario"
            };

            ConfigurarDataGridView();
            string query = @"
                    SELECT
                        *
                    FROM ordem
                    ORDER BY id_ordem ASC;";
            carregar_ordens_com_query(query);
        }

        private void ConfigurarDataGridView()
        {
            dgvOS.AllowUserToAddRows = false;
            dgvOS.AllowUserToDeleteRows = false;
            dgvOS.AllowUserToResizeRows = false;

            dgvOS.MultiSelect = false;

            dgvOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOS.ReadOnly = true;

            dgvOS.RowHeadersVisible = false;

            dgvOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOS.BackgroundColor = Color.Black;

            dgvOS.BorderStyle = BorderStyle.None;

            dgvOS.EnableHeadersVisualStyles = false;

            dgvOS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvOS.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dgvOS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvOS.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvOS.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);

            dgvOS.DefaultCellStyle.ForeColor = Color.White;

            dgvOS.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(40, 40, 40);

            dgvOS.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvOS.GridColor = Color.FromArgb(50, 50, 50);

            dgvOS.Columns.Clear();
            // COLUNAS
            dgvOS.Columns.Add("id_ordem", "ID");

            dgvOS.Columns.Add("aprovacao_orcamento", "Status");
            dgvOS.Columns.Add("valor", "Valor");

            dgvOS.Columns.Add("data_ordem", "Data");

            dgvOS.Columns.Add("fk_id_cliente_ordem", "Cliente");

            dgvOS.Columns.Add("fk_id_aparelho_ordem", "Aparelho");

            dgvOS.Columns.Add("fk_id_funcionario_ordem", "Funcionario");

            // VISUALIZAR
            DataGridViewButtonColumn btnVisualizar =
                new DataGridViewButtonColumn();

            btnVisualizar.Name = "Visualizar";

            btnVisualizar.HeaderText = "";

            btnVisualizar.Text = "👁";

            btnVisualizar.UseColumnTextForButtonValue = true;

            dgvOS.Columns.Add(btnVisualizar);

            // EDITAR
            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";

            btnEditar.HeaderText = "";

            btnEditar.Text = "✏";

            btnEditar.UseColumnTextForButtonValue = true;

            dgvOS.Columns.Add(btnEditar);

            // EXCLUIR
            DataGridViewButtonColumn btnExcluir =
                new DataGridViewButtonColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Text = "🗑";

            btnExcluir.UseColumnTextForButtonValue = true;

            dgvOS.Columns.Add(btnExcluir);

            dgvOS.CellClick += dgvOS_CellClick;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "";

                string campo = "";

                string q = cmbFiltro.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(q) ||
                    q == "Selecione")
                {
                    query = @"
                    SELECT
                        id_ordem,
                        aprovacao_orcamento,
                        valor,
                        data_ordem,
                        fk_id_cliente_ordem,
                        fk_id_aparelho_ordem,
                        fk_id_funcionario_ordem
                    FROM ordem
                    WHERE CAST(id_ordem AS CHAR) LIKE @q
                       OR CAST(aprovacao_orcamento AS CHAR) LIKE @q
                       OR CAST(valor AS CHAR) LIKE @q
                       OR CAST(data_ordem AS CHAR) LIKE @q
                       OR CAST(fk_id_cliente_ordem AS CHAR) LIKE @q
                       OR CAST(fk_id_aparelho_ordem AS CHAR) LIKE @q
                       OR CAST(fk_id_funcionario_ordem AS CHAR) LIKE @q
                    ORDER BY id_ordem DESC;";
                }
                else
                {
                    switch (q)
                    {
                        case "ID":
                            campo = "id_ordem";
                            break;

                        case "Status":
                            campo = "aprovacao_orcamento";
                            break;

                        case "Valor":
                            campo = "CAST(valor AS CHAR)";
                            break;

                        case "Data":
                            campo = "CAST(data_ordem AS CHAR)";
                            break;

                        case "Cliente":
                            campo = "CAST(fk_id_cliente_ordem AS CHAR)";
                            break;

                        case "Aparelho":
                            campo = "CAST(fk_id_aparelho_ordem AS CHAR)";
                            break;

                        case "Funcionario":
                            campo = "CAST(fk_id_funcionario_ordem AS CHAR)";
                            break;

                        default:
                            campo = "id_ordem";
                            break;
                    
                    
                    
                    
                    }

                    query = $@"
                    SELECT
                        id_ordem,
                        aprovacao_orcamento,
                        valor,
                        data_ordem,
                        fk_id_cliente_ordem,
                        fk_id_aparelho_ordem,
                        fk_id_funcionario_ordem
                    FROM ordem
                    WHERE {campo} LIKE @q
                    ORDER BY id_ordem DESC;";
                }

                carregar_ordens_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao buscar: " + ex.Message
                );
            }
        }


        private void carregar_ordens()
        {
            string query = "SELECT COALESCE(MAX(id_ordem), 0) FROM ordem;";
            checar_cod(query);
        }

        private void checar_cod(string query)
        {
            try
            {
                //int flag = 0;
                //Cria a conexão ocm o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa

                //Executa o comando e obtém os resulttados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adiocnar novos
                //lstCliente.Items.Clear();

                //Preenche o ListView com os dados dos cliente
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        codOrdem = "1"; // Valor padrão se a tabela estiver vazia
                    }
                    else
                    {
                        codOrdem = (reader.GetInt32(0) + 1).ToString();
                    }
                }
            }
            catch (MySqlException ex)
            {
                //Trata erros relacionados ao MySQL
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //Trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechda, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void carregar_ordens_com_query(string query)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                MySqlCommand cmd =
                    new MySqlCommand(query, Conexao);

                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue(
                        "@q",
                        "%" + txtBuscar.Text + "%"
                    );
                }

                MySqlDataReader reader = cmd.ExecuteReader();

                dgvOS.Rows.Clear();

                while (reader.Read())
                {
                    dgvOS.Rows.Add(
                        reader["id_ordem"].ToString(),
                        reader["aprovacao_orcamento"].ToString(),
                        reader["valor"].ToString(),
                        reader["data_ordem"].ToString(),
                        reader["fk_id_cliente_ordem"].ToString(),
                        reader["fk_id_aparelho_ordem"].ToString(),
                        reader["fk_id_funcionario_ordem"].ToString()
                    );
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Erro " + ex.Number + " ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocorreu: " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (Conexao != null &&
                    Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void dgvOS_CellClick(
           object sender,
           DataGridViewCellEventArgs e
       )
        {
            if (e.RowIndex < 0)
                return;

            string idOrdem =
                dgvOS.Rows[e.RowIndex]
                .Cells["id_ordem"]
                .Value
                .ToString();

            // VISUALIZAR
            if (dgvOS.Columns[e.ColumnIndex].Name
                == "Visualizar")
            {
                MessageBox.Show(
                    "Visualizar ordem ID: " + idOrdem
                );
            }

            
            // EDITAR
            if (dgvOS.Columns[e.ColumnIndex].Name
                == "Editar")

            {

                int id = Convert.ToInt32(dgvOS.Rows[e.RowIndex].Cells["id_ordem"].Value);
                string aprovacao_orcamento = dgvOS.Rows[e.RowIndex].Cells["aprovacao_orcamento"].Value.ToString();
                decimal valor = Convert.ToDecimal(dgvOS.Rows[e.RowIndex].Cells["valor"].Value);
                DateTime data_ordem = Convert.ToDateTime(dgvOS.Rows[e.RowIndex].Cells["data_ordem"].Value);
                int fkIdCliente = Convert.ToInt32(dgvOS.Rows[e.RowIndex].Cells["fk_id_cliente_ordem"].Value);
                int fkIdAparelho = Convert.ToInt32(dgvOS.Rows[e.RowIndex].Cells["fk_id_aparelho_ordem"].Value);
                int fkIdFuncionario = Convert.ToInt32(dgvOS.Rows[e.RowIndex].Cells["fk_id_funcionario_ordem"].Value);
                using (FormGerenciarOrdem frm = new FormGerenciarOrdem(codOrdem))

                {

                    // Chamamos o método que criamos para transformar a tela

                    frm.ConfigurarEdicao(id, aprovacao_orcamento, valor, data_ordem, fkIdCliente, fkIdAparelho, fkIdFuncionario);



                    if (frm.ShowDialog() == DialogResult.OK)

                    {

                        // Recarrega o grid após salvar

                        carregar_ordens_com_query("SELECT * FROM ordem ORDER BY id_ordem DESC");

                    }

                }

                // EXCLUIR
                if (dgvOS.Columns[e.ColumnIndex].Name
                == "Excluir")
                {
                    DialogResult resultado =
                        MessageBox.Show(
                            "Deseja excluir esta ordem?",
                            "Confirmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                    if (resultado == DialogResult.Yes)
                    {
                        ExcluirOrdem(idOrdem);
                    }
                }
            }
        }

        private void ExcluirOrdem(string id)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                string sql =
                    "DELETE FROM ordem_servico WHERE id_ordem = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Produto excluído com sucesso!"
                );

                carregar_ordens_com_query(
                    "SELECT * FROM ordem_servico ORDER BY id_ordem DESC"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao excluir: " + ex.Message
                );
            }
            finally
            {
                if (Conexao != null &&
                    Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            carregar_ordens();

            // Usando o bloco using para garantir o descarte correto da tela após fechar
            using (FormGerenciarOrdem form = new FormGerenciarOrdem(codOrdem))
            {
                form.ShowDialog();

                // Assim que o usuário fechar a tela de gerenciamento (no botão fechar ou no X),
                // a tela principal atualiza a lista de ordens automaticamente.
                carregar_ordens_com_query("SELECT * FROM ordem ORDER BY id_ordem DESC");
            }
        }

        private void FormOrdemDeServico_Load(object sender, EventArgs e)
        {
            txtBuscar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtBuscar.Width,
                txtBuscar.Height, 25, 25));

            btnNovaOS.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNovaOS.Width,
                btnNovaOS.Height, 25, 25));

            btnPesquisar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPesquisar.Width,
                btnPesquisar.Height, 25, 25));

            cmbFiltro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbFiltro.Width,
                cmbFiltro.Height, 20, 20));
        }
    }
}
