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
    public partial class FormAparelho : Form
    {
        String codAparelho = "";

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        public FormAparelho()
        {
            InitializeComponent();

            cmbFiltro.DataSource = new List<string>
            {
                "Selecione",
                "Nome do aparelho",
                "N°Serie",
                "Tipo",
                "Marca",
                "Modelo",
                "Cliente",
                "Data Entrada",
                "Estado"
            };

            ConfigurarDataGridView();

        }

        private void ConfigurarDataGridView()
        {
            dgvAparelho.AllowUserToAddRows = false;
            dgvAparelho.AllowUserToDeleteRows = false;
            dgvAparelho.AllowUserToResizeRows = false;

            dgvAparelho.MultiSelect = false;

            dgvAparelho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAparelho.ReadOnly = true;

            dgvAparelho.RowHeadersVisible = false;

            dgvAparelho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAparelho.BackgroundColor = Color.Black;

            dgvAparelho.BorderStyle = BorderStyle.None;
            dgvAparelho.EnableHeadersVisualStyles = false;

            dgvAparelho.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvAparelho.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dgvAparelho.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvAparelho.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvAparelho.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);

            dgvAparelho.DefaultCellStyle.ForeColor = Color.White;

            dgvAparelho.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(40, 40, 40);

            dgvAparelho.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvAparelho.GridColor = Color.FromArgb(50, 50, 50);

            dgvAparelho.Columns.Clear();
            // COLUNAS
            dgvAparelho.Columns.Add("id_aparelho", "ID");
            dgvAparelho.Columns.Add("nome_aparelho", "ID");
            dgvAparelho.Columns.Add("tipo", "Tipo");
            dgvAparelho.Columns.Add("marca", "Marca");
            dgvAparelho.Columns.Add("modelo", "Modelo");
            dgvAparelho.Columns.Add("cliente", "Cliente");
            dgvAparelho.Columns.Add("data_entrada", "Data Entrada");
            dgvAparelho.Columns.Add("estado", "Estado");

        

            // VISUALIZAR
            DataGridViewButtonColumn btnVisualizar =
                new DataGridViewButtonColumn();

            btnVisualizar.Name = "Visualizar";

            btnVisualizar.HeaderText = "";

            btnVisualizar.Text = "👁";

            btnVisualizar.UseColumnTextForButtonValue = true;

            dgvAparelho.Columns.Add(btnVisualizar);

            // EDITAR
            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";

            btnEditar.HeaderText = "";

            btnEditar.Text = "✏";

            btnEditar.UseColumnTextForButtonValue = true;

            dgvAparelho.Columns.Add(btnEditar);

            // EXCLUIR
            DataGridViewButtonColumn btnExcluir =
                new DataGridViewButtonColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Text = "🗑";

            btnExcluir.UseColumnTextForButtonValue = true;

            dgvAparelho.Columns.Add(btnExcluir);

            dgvAparelho.CellClick += dgvAparelho_CellClick;
        }

        private void btnNovoAparelho_Click(object sender, EventArgs e)
        {
            carregar_aparelhos();
            FormNovoAparelho form = new FormNovoAparelho(codAparelho); // cria novo form
            
            if (form.ShowDialog() == DialogResult.OK) //Carrega o cliente cadastrado e mostra na consulta
            {
                carregar_aparelhos_com_query(
                    "SELECT * FROM aparelho ORDER BY id_aparelho DESC"
                );
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
                        id_aparelho,
                        nome_aparelho,
                        marca,
                        modelo,
                        tipo,
                        cliente,
                        data_entrada,
                        estado
                    FROM aparelho
                    WHERE CAST(id_aparelho AS CHAR) LIKE @q
                       OR nome_aparelho LIKE @q
                       OR marca LIKE @q
                       OR modelo LIKE @q
                       OR tipo LIKE @q
                       OR cliente LIKE @q
                       OR CAST(data_entrada AS CHAR) LIKE @q
                       OR estado LIKE @q
                    ORDER BY id_aparelho DESC;";
                }
                else
                {
                    switch (q)
                    {
                        case "Marca":
                            campo = "marca";
                            break;

                        case "Modelo":
                            campo = "modelo";
                            break;

                        case "Tipo":
                            campo = "tipo";
                            break;

                        case "Cliente":
                            campo = "cliente";
                            break;

                        case "Data de Entrada":
                            campo = "CAST(data_entrada AS CHAR)";
                            break;

                        case "Estado":
                            campo = "estado";
                            break;

                        case "Nome do aparelho":
                            campo = "nome_aparelho";
                            break;

                        case "Numero de série":
                            campo = "CAST(num_serie AS CHAR)";
                            break;

                        case "ID":
                            campo = "CAST(id_produto AS CHAR)";
                            break;

                        default:
                            campo = "nome_aparelho";
                            break;
                    }

                    query = $@"
                    SELECT
                        id_aparelho,
                        marca,
                        nome_aparelho,
                        modelo,
                        tipo,
                        cliente,
                        data_entrada,
                        estado
                    FROM aparelho
                    WHERE {campo} LIKE @q
                    ORDER BY id_aparelho DESC;";
                }

                carregar_aparelhos_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao buscar: " + ex.Message
                );
            }

        }

        private void carregar_aparelhos_com_query(string query)
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

                dgvAparelho.Rows.Clear();

                while (reader.Read())
                {
                    dgvAparelho.Rows.Add(
                        reader["id_aparelho"].ToString(),
                        reader["tipo"].ToString(),
                        reader["marca"].ToString(),
                        reader["modelo"].ToString(),
                        reader["nome_aparelho"].ToString(),
                        reader["cliente"].ToString(),
                        reader["data_entrada"].ToString(),
                        reader["estado"].ToString()
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
                        codAparelho = "1"; // Valor padrão se a tabela estiver vazia
                    }
                    else
                    {
                        codAparelho = Convert.ToString(reader.GetInt32(0) + 1);
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

        private void carregar_aparelhos()
        {
            string query = "SELECT COALESCE(MAX(id_aparelho), 0) FROM aparelho;";
            checar_cod(query);
        }

        private void dgvAparelho_CellClick(
           object sender,
           DataGridViewCellEventArgs e
       )
        {
            if (e.RowIndex < 0)
                return;

            string idAparelho =
                dgvAparelho.Rows[e.RowIndex]
                .Cells["id_aparelho"]
                .Value
                .ToString();

            // VISUALIZAR
            if (dgvAparelho.Columns[e.ColumnIndex].Name
                == "Visualizar")
            {
                MessageBox.Show(
                    "Visualizar aparelho ID: " + idAparelho
                );
            }

            // EDITAR
            if (dgvAparelho.Columns[e.ColumnIndex].Name
                == "Editar")
            {
                MessageBox.Show(
                    "Editar aparelho ID: " + idAparelho
                );

                // abrir tela edição aqui
            }

            // EXCLUIR
            if (dgvAparelho.Columns[e.ColumnIndex].Name
                == "Excluir")
            {
                DialogResult resultado =
                    MessageBox.Show(
                        "Deseja excluir este aparelho?",
                        "Confirmação",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                if (resultado == DialogResult.Yes)
                {
                    ExcluirAparelho(idAparelho);
                }
            }
        }

        private void ExcluirAparelho(string id)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                string sql =
                    "DELETE FROM aparelho WHERE id_aparelho = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Produto excluído com sucesso!"
                );

                carregar_aparelhos_com_query(
                    "SELECT * FROM aparelho ORDER BY id_aparelho DESC"
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

    }
    }
    
    
    

