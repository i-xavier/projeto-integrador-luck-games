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

            //Configuração inciial do ListView para exibição dos dados dos clientes
            lstProduto.View = View.Details; //Define a visualização em "detalhes"
            lstProduto.LabelEdit = true; //Permite editar os títulos das colunas
            lstProduto.AllowColumnReorder = true; //Permite reordenar as colunas
            lstProduto.FullRowSelect = true; //Seleciona a linha inteira ao clica
            lstProduto.GridLines = false; //Exibe a slinhas de grade no ListView
            lstProduto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstProduto.OwnerDraw = true;



            lstProduto.DrawColumnHeader += (sender, e) =>
            {
                using (Brush backBrush = new SolidBrush(Color.Black)) // cor do fundo
                using (Brush textBrush = new SolidBrush(Color.White))    // cor do texto
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, e.Font, textBrush, e.Bounds);
                }
            };

            lstProduto.DrawItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            lstProduto.DrawSubItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            //Definindo as colunas do ListView

            lstProduto.Columns.Add("ID", 79, HorizontalAlignment.Left); //Coluna do Código
            lstProduto.Columns.Add("Nome da peça", 158, HorizontalAlignment.Left);//Coluna do Nome da peça
            lstProduto.Columns.Add("Categoria", 158, HorizontalAlignment.Left);//Coluna da categoria
            lstProduto.Columns.Add("Quantidade mínima", 158, HorizontalAlignment.Left);//Coluna da quantidade
            lstProduto.Columns.Add("Valor unitário", 158, HorizontalAlignment.Left);//Coluna do valor unitário
            lstProduto.Columns.Add("Quantidade total", 158, HorizontalAlignment.Left);//Coluna do fornecedor

            AjustarColunasIgualmente();

            lstProduto.Resize += (s, e) => AjustarColunasIgualmente();
            this.Resize += (s, e) => AjustarColunasIgualmente();
        }

        private void btnNovaMovimentacao_Click(object sender, EventArgs e)
        {
            FormNovaMovimentacao form = new FormNovaMovimentacao();
            form.ShowDialog();
        }

        private void AjustarColunasIgualmente()
        {
            int totalColunas = lstProduto.Columns.Count;
            if (totalColunas == 0) return;

            int larguraTotal = lstProduto.ClientSize.Width;
            int larguraBase = larguraTotal / totalColunas;
            int resto = larguraTotal % totalColunas;

            for (int i = 0; i < totalColunas; i++)
            {
                lstProduto.Columns[i].Width = larguraBase;

                if (resto > 0)
                {
                    lstProduto.Columns[i].Width += 1;
                    resto--;
                }
            }
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
                //Cria a conexão ocm o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Executa a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //Executa o comando e obtém os resulttados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adiocnar novos
                lstProduto.Items.Clear();

                //Preenche o ListView com os dados dos cliente
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader["id_produto"].ToString(),
                        reader["nome_produto"].ToString(),
                        reader["categoria"].ToString(),
                        reader["quantidade_minima"].ToString(),
                        reader["valor_unitario"].ToString(),
                        reader["quantidade_total"].ToString(),
                        "" 
                    };

                    //Adiicona a linha ao ListView
                    lstProduto.Items.Add(new ListViewItem(row));
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "";
                string campo = "";

                // 1. Verificamos se o item selecionado é nulo ANTES de converter para string
                // Usamos ?.ToString() que retorna nulo se o objeto for nulo, sem dar erro.
                string q = cmbFiltro.SelectedItem?.ToString();

                // 2. Lógica de decisão do filtro
                if (string.IsNullOrEmpty(q) || q == "Selecione")
                {
                    // Caso Geral: Busca em todas as colunas
                    query = @"
            SELECT id_produto, nome_produto, categoria, quantidade_minima, valor_unitario, quantidade_total
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
                    // Caso Específico: Mapeia o nome amigável para o nome da coluna no banco
                    switch (q)
                    {
                        case "Nome": campo = "nome_produto"; break;
                        case "Categoria": campo = "categoria"; break;
                        case "Quantidade Mínima": campo = "CAST(quantidade_minima AS CHAR)"; break;
                        case "Valor Unitário": campo = "CAST(valor_unitario AS CHAR)"; break;
                        case "Quantidade Total": campo = "CAST(quantidade_total AS CHAR)"; break;
                        case "ID": campo = "CAST(id_produto AS CHAR)"; break;
                        default: campo = "nome_produto"; break;
                    }

                    query = $@"
            SELECT id_produto, nome_produto, categoria, quantidade_minima, valor_unitario, quantidade_total
            FROM produto
            WHERE {campo} LIKE @q
            ORDER BY id_produto DESC;";
                }

                // 3. Execução
                carregar_produtos_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }

        }
    }
}
