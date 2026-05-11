using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormEstoque : Form
    {
        String codProd = "";

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";
        public FormEstoque()
        {
            InitializeComponent();

            cmbFiltro.DataSource = new List<string>
            {
                "Selecione",
                "ID",
                "Nome",
                "Categoria",
                "Quantidade Mínima",
                "Valor Unitário",
                "Quantidade Total"
            };

            preencherBaloes();
            ConfigurarDataGridView();
        }

        private void ConfigurarDataGridView()
        {
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.AllowUserToDeleteRows = false;
            dgvProduto.AllowUserToResizeRows = false;

            dgvProduto.MultiSelect = false;

            dgvProduto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProduto.ReadOnly = true;

            dgvProduto.RowHeadersVisible = false;

            dgvProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvProduto.BackgroundColor = Color.Black;

            dgvProduto.BorderStyle = BorderStyle.None;

            dgvProduto.EnableHeadersVisualStyles = false;

            dgvProduto.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvProduto.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dgvProduto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvProduto.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvProduto.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);

            dgvProduto.DefaultCellStyle.ForeColor = Color.White;

            dgvProduto.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(40, 40, 40);

            dgvProduto.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvProduto.GridColor = Color.FromArgb(50, 50, 50);

            dgvProduto.Columns.Clear();

            // COLUNAS
            dgvProduto.Columns.Add("id_produto", "ID");

            dgvProduto.Columns.Add("nome_produto", "Nome da peça");

            dgvProduto.Columns.Add("categoria", "Categoria");

            dgvProduto.Columns.Add("quantidade_minima", "Quantidade mínima");

            dgvProduto.Columns.Add("valor_unitario", "Valor unitário");

            dgvProduto.Columns.Add("quantidade_total", "Quantidade total");

            // VISUALIZAR
            DataGridViewButtonColumn btnVisualizar =
                new DataGridViewButtonColumn();

            btnVisualizar.Name = "Visualizar";

            btnVisualizar.HeaderText = "";

            btnVisualizar.Text = "👁";

            btnVisualizar.UseColumnTextForButtonValue = true;

            dgvProduto.Columns.Add(btnVisualizar);

            // EDITAR
            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";

            btnEditar.HeaderText = "";

            btnEditar.Text = "✏";

            btnEditar.UseColumnTextForButtonValue = true;

            dgvProduto.Columns.Add(btnEditar);

            // EXCLUIR
            DataGridViewButtonColumn btnExcluir =
                new DataGridViewButtonColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Text = "🗑";

            btnExcluir.UseColumnTextForButtonValue = true;

            dgvProduto.Columns.Add(btnExcluir);

            dgvProduto.CellClick += dgvProduto_CellClick;
        }
        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            FormNovaMovimentacao form = new FormNovaMovimentacao();
            if (form.ShowDialog() == DialogResult.OK) //Carrega a movimentação cadastrada e mostra na consulta
            {
                carregar_produtos_com_query(
                     "SELECT * FROM produto ORDER BY id_produto DESC"
                 );
            }

            preencherBaloes();
        }


        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            carregar_produtos();

            FormNovoProduto form = new FormNovoProduto(codProd);

            if (form.ShowDialog() == DialogResult.OK) //Carrega o produto cadastrado e mostra na consulta
            {
               carregar_produtos_com_query(
                    "SELECT * FROM produto ORDER BY id_produto DESC"
                );
            }

            preencherBaloes();
        }

        private void carregar_produtos()
        {
            string query = "SELECT COALESCE(MAX(id_produto), 0) FROM produto;";
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
                        codProd = "1"; // Valor padrão se a tabela estiver vazia
                    }
                    else
                    {
                        codProd = (reader.GetInt32(0) + 1).ToString();
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

        private void carregar_produtos_com_query(string query)
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

                dgvProduto.Rows.Clear();

                while (reader.Read())
                {
                    dgvProduto.Rows.Add(
                        reader["id_produto"].ToString(),
                        reader["nome_produto"].ToString(),
                        reader["categoria"].ToString(),
                        reader["quantidade_minima"].ToString(),
                        reader["valor_unitario"].ToString(),
                        reader["quantidade_total"].ToString()
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
                        id_produto,
                        nome_produto,
                        categoria,
                        quantidade_minima,
                        valor_unitario,
                        quantidade_total
                    FROM produto
                    WHERE CAST(id_produto AS CHAR) LIKE @q
                       OR nome_produto LIKE @q
                       OR categoria LIKE @q
                       OR CAST(quantidade_minima AS CHAR) LIKE @q
                       OR CAST(valor_unitario AS CHAR) LIKE @q
                       OR CAST(quantidade_total AS CHAR) LIKE @q
                    ORDER BY id_produto DESC;";
                }
                else
                {
                    switch (q)
                    {
                        case "Nome":
                            campo = "nome_produto";
                            break;

                        case "Categoria":
                            campo = "categoria";
                            break;

                        case "Quantidade Mínima":
                            campo = "CAST(quantidade_minima AS CHAR)";
                            break;

                        case "Valor Unitário":
                            campo = "CAST(valor_unitario AS CHAR)";
                            break;

                        case "Quantidade Total":
                            campo = "CAST(quantidade_total AS CHAR)";
                            break;

                        case "ID":
                            campo = "CAST(id_produto AS CHAR)";
                            break;

                        default:
                            campo = "nome_produto";
                            break;
                    }

                    query = $@"
                    SELECT
                        id_produto,
                        nome_produto,
                        categoria,
                        quantidade_minima,
                        valor_unitario,
                        quantidade_total
                    FROM produto
                    WHERE {campo} LIKE @q
                    ORDER BY id_produto DESC;";
                }

                carregar_produtos_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao buscar: " + ex.Message
                );
            }

        }

        private void dgvProduto_CellClick(
           object sender,
           DataGridViewCellEventArgs e
       )
        {
            if (e.RowIndex < 0)
                return;

            string idProduto =
                dgvProduto.Rows[e.RowIndex]
                .Cells["id_produto"]
                .Value
                .ToString();

            // VISUALIZAR
            if (dgvProduto.Columns[e.ColumnIndex].Name
                == "Visualizar")
            {
                MessageBox.Show(
                    "Visualizar produto ID: " + idProduto
                );
            }

            // EDITAR
            if (dgvProduto.Columns[e.ColumnIndex].Name
                == "Editar")
            {
                MessageBox.Show(
                    "Editar produto ID: " + idProduto
                );

                // abrir tela edição aqui
            }

            // EXCLUIR
            if (dgvProduto.Columns[e.ColumnIndex].Name
                == "Excluir")
            {
                DialogResult resultado =
                    MessageBox.Show(
                        "Deseja excluir este produto?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.Yes)
                {
                    ExcluirProduto(idProduto);
                }
            }
        }

        private void ExcluirProduto(string id)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                string sql =
                    "DELETE FROM produto WHERE id_produto = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Produto excluído com sucesso!"
                );

                carregar_produtos_com_query(
                    "SELECT * FROM produto ORDER BY id_produto DESC"
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

        private void preencherBaloes() { 
        
            string queryTiposProdutos = "SELECT COUNT(DISTINCT nome_produto) FROM produto;";

            string queryCategorias = "SELECT COUNT(DISTINCT categoria) FROM produto;";

            string queryTotalProdutos = "SELECT SUM(quantidade_total) FROM produto;";

            lblTotalProdutos.Text = consultarBaloes(queryTotalProdutos);

            lblItensEstoque.Text = consultarBaloes(queryTiposProdutos);

            lblTotalCategorias.Text = consultarBaloes(queryCategorias);

        }

        private string consultarBaloes (string query)
        {
            Conexao = new MySqlConnection(data_source);

            Conexao.Open();

            string valorEncontrado = "";

            MySqlCommand cmd = new MySqlCommand(query, Conexao);

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                if (reader.IsDBNull(0))
                {
                    valorEncontrado = "0"; // Valor padrão se a tabela estiver vazia
                }
                else
                {
                    valorEncontrado = (reader.GetInt32(0)).ToString();
                }
            }

            return valorEncontrado;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
