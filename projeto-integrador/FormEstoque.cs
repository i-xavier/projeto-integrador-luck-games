using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class FormEstoque : Form
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
            string query = @"
                    SELECT
                        *
                    FROM produto
                    ORDER BY id_produto ASC;";
            carregar_produtos_com_query(query);
            balaoNotificacao();
        }

        private void ConfigurarDataGridView()
        {
            dgvProduto.AllowUserToAddRows = false;

            dgvProduto.AllowUserToDeleteRows = false;

            dgvProduto.AllowUserToResizeRows = false;

            dgvProduto.MultiSelect = false;

            dgvProduto.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProduto.ReadOnly = true;

            dgvProduto.RowHeadersVisible = false;

            // MELHOR AJUSTE DAS COLUNAS
            dgvProduto.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            dgvProduto.BackgroundColor = Color.Black;

            dgvProduto.BorderStyle = BorderStyle.None;

            dgvProduto.EnableHeadersVisualStyles = false;

            dgvProduto.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            // CABEÇALHO
            dgvProduto.ColumnHeadersDefaultCellStyle.BackColor =
                Color.Black;

            dgvProduto.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvProduto.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 13, FontStyle.Bold);

            dgvProduto.ColumnHeadersHeight = 45;

            // LINHAS
            dgvProduto.RowTemplate.Height = 38;

            // CÉLULAS
            dgvProduto.DefaultCellStyle.BackColor =
                Color.FromArgb(20, 20, 20);

            dgvProduto.DefaultCellStyle.ForeColor =
                Color.White;

            dgvProduto.DefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Regular);

            dgvProduto.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(40, 40, 40);

            dgvProduto.DefaultCellStyle.SelectionForeColor =
                Color.White;

            dgvProduto.DefaultCellStyle.Padding =
                new Padding(5, 0, 5, 0);

            dgvProduto.DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleLeft;

            dgvProduto.GridColor =
                Color.FromArgb(50, 50, 50);

            dgvProduto.Columns.Clear();

            // COLUNAS
            dgvProduto.Columns.Add("id_produto", "ID");

            dgvProduto.Columns.Add(
                "nome_produto",
                "Nome da peça"
            );

            dgvProduto.Columns.Add(
                "categoria",
                "Categoria"
            );

            dgvProduto.Columns.Add(
                "quantidade_minima",
                "Quantidade mínima"
            );

            dgvProduto.Columns.Add(
                "valor_unitario",
                "Valor unitário"
            );

            dgvProduto.Columns.Add(
                "quantidade_total",
                "Quantidade total"
            );

            // BOTÃO EDITAR
            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";

            btnEditar.HeaderText = "";

            btnEditar.Text = "✏";

            btnEditar.UseColumnTextForButtonValue = true;

            btnEditar.FlatStyle = FlatStyle.Flat;

            btnEditar.DefaultCellStyle.Font =
                new Font("Segoe UI Emoji", 12);

            btnEditar.DefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 30);

            btnEditar.DefaultCellStyle.ForeColor =
                Color.White;

            dgvProduto.Columns.Add(btnEditar);

            // BOTÃO EXCLUIR
            DataGridViewButtonColumn btnExcluir =
                new DataGridViewButtonColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Text = "🗑";

            btnExcluir.UseColumnTextForButtonValue = true;

            btnExcluir.FlatStyle = FlatStyle.Flat;

            btnExcluir.DefaultCellStyle.Font =
                new Font("Segoe UI Emoji", 12);

            btnExcluir.DefaultCellStyle.BackColor =
                Color.FromArgb(30, 30, 30);

            btnExcluir.DefaultCellStyle.ForeColor =
                Color.White;

            dgvProduto.Columns.Add(btnExcluir);

            // NOME DA PEÇA OCUPA O ESPAÇO SOBRANDO
            dgvProduto.Columns["nome_produto"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;

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

            FormGerenciarProduto form = new FormGerenciarProduto(codProd);

            if (form.ShowDialog() == DialogResult.OK) //Carrega o produto cadastrado e mostra na consulta
            {
                
                carregar_produtos_com_query(
                    "SELECT * FROM produto ORDER BY id_produto DESC"
                );

                balaoNotificacao();
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
                    int quantidadeTotal = Convert.ToInt32(reader["quantidade_total"]);
                    int quantidadeMinima = Convert.ToInt32(reader["quantidade_minima"]);

                    int rowIndex = dgvProduto.Rows.Add(
                        reader["id_produto"].ToString(),
                        reader["nome_produto"].ToString(),
                        reader["categoria"].ToString(),
                        reader["quantidade_minima"].ToString(),
                        reader["valor_unitario"].ToString(),
                        reader["quantidade_total"].ToString()
                    );

                    // Se estiver abaixo do estoque, aplica o laranja destacado
                    if (quantidadeTotal < quantidadeMinima)
                    {
                        dgvProduto.Rows[rowIndex].Cells["quantidade_total"].Style.ForeColor = Color.Orange;
                        dgvProduto.Rows[rowIndex].Cells["quantidade_total"].Style.SelectionForeColor = Color.Orange;
                        dgvProduto.Rows[rowIndex]
     .Cells["quantidade_total"]
     .Style.Font =
         new Font("Segoe UI", 12, FontStyle.Bold);
                    }
                    else
                    {
                        // Caso o produto tenha sido abastecido, volta para a cor padrão do grid
                        dgvProduto.Rows[rowIndex].Cells["quantidade_total"].Style.ForeColor = dgvProduto.DefaultCellStyle.ForeColor;
                        dgvProduto.Rows[rowIndex].Cells["quantidade_total"].Style.SelectionForeColor = dgvProduto.DefaultCellStyle.SelectionForeColor;
                        dgvProduto.Rows[rowIndex].Cells["quantidade_total"].Style.Font = dgvProduto.DefaultCellStyle.Font;
                    }
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
                    ORDER BY id_produto ASC;";
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
                    ORDER BY id_produto ASC;";
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

                int id = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells["id_produto"].Value);
                string nome = dgvProduto.Rows[e.RowIndex].Cells["nome_produto"].Value.ToString();
                string categoria = dgvProduto.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                int quantidadeMinima = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells["quantidade_minima"].Value);
                decimal valorUnitario = Convert.ToDecimal(dgvProduto.Rows[e.RowIndex].Cells["valor_unitario"].Value);
                int quantidadeTotal = Convert.ToInt32(dgvProduto.Rows[e.RowIndex].Cells["quantidade_total"].Value);



                using (FormGerenciarProduto frm = new FormGerenciarProduto(id.ToString()))

                {
                    // Chamamos o método que criamos para transformar a tela

                    frm.ConfigurarEdicao(id, nome, categoria, quantidadeMinima, valorUnitario, quantidadeTotal);


                    if (frm.ShowDialog() == DialogResult.OK)

                    {

                        // Recarrega o grid após salvar

                        carregar_produtos_com_query("SELECT * FROM produto ORDER BY id_produto DESC");
                        balaoNotificacao();

                    }

                }

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

                balaoNotificacao();
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
            string valorEncontrado = "0";

            // O 'using' fecha a conexão e o comando automaticamente ao chegar no fim das chaves {}
            using (MySqlConnection conexaoBaloes = new MySqlConnection(data_source))
            {
                try
                {
                    conexaoBaloes.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conexaoBaloes))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (!reader.IsDBNull(0))
                            {
                                valorEncontrado = reader.GetValue(0).ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar balões: " + ex.Message);
                }
            }

            return valorEncontrado;

        }

        public void balaoNotificacao()
        {
            string query = @"
            SELECT nome_produto, quantidade_total, quantidade_minima
            FROM produto
            WHERE quantidade_total < quantidade_minima;";

            Conexao = new MySqlConnection(data_source);

            Conexao.Open();

            MySqlCommand cmd = new MySqlCommand(query, Conexao);

            MySqlDataReader reader = cmd.ExecuteReader();

            List<string> produtosCriticos = new List<string>();

            while (reader.Read())
            {
                string nomeProduto = reader["nome_produto"].ToString();

                string qtdAtual = reader["quantidade_total"].ToString();

                string qtdMinima = reader["quantidade_minima"].ToString();

                produtosCriticos.Add(
                    $"{nomeProduto} ({qtdAtual}/{qtdMinima})"
                );
            }

            cbProdutosAbaixoDoEstoque.DataSource = produtosCriticos;

            if (produtosCriticos.Count > 0)
            {
                notificaoEstoqueMinimo.Visible = true;

                /*notificaoEstoqueMinimo.Text =
                    $"{produtosCriticos.Count} produto(s) abaixo do estoque mínimo:\n\n"
                    + string.Join("\n", produtosCriticos);*/

                lblnotificaoEstoqueMinimo.Text = $"{produtosCriticos.Count} produto(s) abaixo do estoque mínimo:\n\n";
            }
            else
            {
                notificaoEstoqueMinimo.Visible = false;
            }

            Conexao.Close();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {
            btnNovaMovimentacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNovaMovimentacao.Width,
                btnNovaMovimentacao.Height, 25, 25));

            btnNovoProduto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNovoProduto.Width,
                btnNovoProduto.Height, 25, 25));

            btnPesquisar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPesquisar.Width,
                btnPesquisar.Height, 25, 25));

            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width,
                panel2.Height, 25, 25));

            panel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel3.Width,
                panel3.Height, 25, 25));

            panel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel4.Width,
                panel4.Height, 25, 25));

            notificaoEstoqueMinimo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, notificaoEstoqueMinimo.Width,
                notificaoEstoqueMinimo.Height, 25, 25));

            txtBuscar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtBuscar.Width,
                txtBuscar.Height, 25, 25));

            cmbFiltro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbFiltro.Width,
                cmbFiltro.Height, 20, 20));

           // dgvProduto.Dock = DockStyle.Fill;

        }
    }
}
