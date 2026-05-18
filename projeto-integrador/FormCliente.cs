using Google.Protobuf.WellKnownTypes;
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
    public partial class FormCliente : Form
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

        String codUser = "";

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        private int? codigo_cliente = null;
        public FormCliente()
        {
            InitializeComponent();

            cmbFiltro.DataSource = new List<string>
            {
                "Selecione",
                "ID",
                "Nome",
                "Telefone",
                "CPF"
            };

            ConfigurarDataGridView();
            string query = @"
                    SELECT
                        *
                    FROM cliente
                    ORDER BY id_cliente ASC;";
            carregar_clientes_com_query(query);
        }

        private void ConfigurarDataGridView()
        {
            dgvCliente.AllowUserToAddRows = false;
            dgvCliente.AllowUserToDeleteRows = false;
            dgvCliente.AllowUserToResizeRows = false;

            dgvCliente.MultiSelect = false;

            dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCliente.ReadOnly = true;

            dgvCliente.RowHeadersVisible = false;

            dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCliente.BackgroundColor = Color.Black;

            dgvCliente.BorderStyle = BorderStyle.None;
            dgvCliente.EnableHeadersVisualStyles = false;

            dgvCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;

            dgvCliente.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dgvCliente.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvCliente.DefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20);

            dgvCliente.DefaultCellStyle.ForeColor = Color.White;

            dgvCliente.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(40, 40, 40);

            dgvCliente.DefaultCellStyle.SelectionForeColor = Color.White;

            dgvCliente.GridColor = Color.FromArgb(50, 50, 50);

            dgvCliente.Columns.Clear();
            // COLUNAS
            dgvCliente.Columns.Add("id_cliente", "ID");
            dgvCliente.Columns.Add("nome", "Nome do cliente");
            dgvCliente.Columns.Add("telefone", "Telefone");
            dgvCliente.Columns.Add("cpf", "CPF");

        

            // VISUALIZAR
           /*DataGridViewButtonColumn btnVisualizar =
                new DataGridViewButtonColumn();

            btnVisualizar.Name = "Visualizar";

            btnVisualizar.HeaderText = "";

            btnVisualizar.Text = "👁";

            //btnVisualizar.Photo

            btnVisualizar.UseColumnTextForButtonValue = true;

            dgvCliente.Columns.Add(btnVisualizar);*/

            // EDITAR
            DataGridViewButtonColumn btnEditar =
                new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";

            btnEditar.HeaderText = "";

            btnEditar.Text = "✏";

            btnEditar.UseColumnTextForButtonValue = true;

            dgvCliente.Columns.Add(btnEditar);

            // EXCLUIR

            DataGridViewButtonColumn btnExcluir =
                new DataGridViewButtonColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Text = "🗑";

            btnExcluir.UseColumnTextForButtonValue = true;

            dgvCliente.Columns.Add(btnExcluir);
            
            /*
            DataGridViewImageColumn btnExcluir =
            new DataGridViewImageColumn();

            btnExcluir.Name = "Excluir";

            btnExcluir.HeaderText = "";

            btnExcluir.Image = Image.FromFile("lixeira.png");

            btnExcluir.ImageLayout =
                DataGridViewImageCellLayout.Zoom;

            dgvCliente.Columns.Add(btnExcluir);*/

            dgvCliente.CellClick += dgvCliente_CellClick;
        }

        private void carregar_clientes_com_query(string query)
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

                dgvCliente.Rows.Clear();

                while (reader.Read())
                {
                    dgvCliente.Rows.Add(
                        reader["id_cliente"].ToString(),
                        reader["nome"].ToString(),
                        reader["telefone"].ToString(),
                        reader["cpf"].ToString()
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
                        codUser = "1"; // Valor padrão se a tabela estiver vazia
                    }
                    else
                    {
                        codUser = Convert.ToString(reader.GetInt32(0) + 1);
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

        private void carregar_clientes()
        {
            string query = "SELECT COALESCE(MAX(id_cliente), 0) FROM cliente;";
            checar_cod(query);
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
                        id_cliente,
                        nome,
                        telefone,
                        cpf
                    FROM cliente
                    WHERE CAST(id_cliente AS CHAR) LIKE @q
                       OR nome LIKE @q
                       OR telefone LIKE @q
                       OR cpf LIKE @q
                    ORDER BY id_cliente DESC;";
                }
                else
                {
                    switch (q)
                    {
                        case "Nome":
                            campo = "nome";
                            break;

                        case "Telefone":
                            campo = "telefone";
                            break;

                        case "CPF":
                            campo = "cpf";
                            break;

                        case "ID":
                            campo = "CAST(id_cliente AS CHAR)";
                            break;

                        default:
                            campo = "nome";
                            break;
                    }

                    query = $@"
                    SELECT
                        id_cliente,
                        nome,
                        telefone,
                        cpf
                    FROM cliente
                    WHERE {campo} LIKE @q
                    ORDER BY id_cliente DESC;";
                }

                carregar_clientes_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao buscar: " + ex.Message
                );
            }

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            carregar_clientes();

           // FormNovoCliente form = new FormNovoCliente(codUser);

            /*if (form.ShowDialog() == DialogResult.OK) //Carrega o cliente cadastrado e mostra na consulta
            {
                carregar_clientes_com_query(
                    "SELECT * FROM cliente ORDER BY id_cliente DESC"
                );
            }*/

            using (FormGerenciarCliente form = new FormGerenciarCliente(codUser))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    carregar_clientes_com_query(
                    "SELECT * FROM cliente ORDER BY id_cliente DESC" );
                }
            }

        }

        private void dgvCliente_CellClick(
           object sender,
           DataGridViewCellEventArgs e
       )
        {
            if (e.RowIndex < 0)
                return;

            string idCliente =
                dgvCliente.Rows[e.RowIndex]
                .Cells["id_cliente"]
                .Value
                .ToString();

            // VISUALIZAR
            if (dgvCliente.Columns[e.ColumnIndex].Name
                == "Visualizar")
            {
                MessageBox.Show(
                    "Visualizar cliente ID: " + idCliente
                );
            }

            // EDITAR
            if (dgvCliente.Columns[e.ColumnIndex].Name
                == "Editar")

            {

                int id = Convert.ToInt32(dgvCliente.Rows[e.RowIndex].Cells["id_cliente"].Value);

                string nome = dgvCliente.Rows[e.RowIndex].Cells["nome"].Value.ToString();

                string telefone = dgvCliente.Rows[e.RowIndex].Cells["telefone"].Value.ToString();

                string cpf = dgvCliente.Rows[e.RowIndex].Cells["cpf"].Value.ToString();



                using (FormGerenciarCliente frm = new FormGerenciarCliente(codUser))

                {

                    // Chamamos o método que criamos para transformar a tela

                    frm.ConfigurarEdicao(id, nome, telefone, cpf);



                    if (frm.ShowDialog() == DialogResult.OK)

                    {

                        // Recarrega o grid após salvar

                        carregar_clientes_com_query("SELECT * FROM cliente ORDER BY id_cliente DESC");

                    }

                }

            }

            // EXCLUIR
            if (dgvCliente.Columns[e.ColumnIndex].Name
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
                    ExcluirCliente(idCliente);
                }
            }
        }

        private void ExcluirCliente(string id)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                Conexao.Open();

                string sql =
                    "DELETE FROM cliente WHERE id_cliente = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Produto excluído com sucesso!"
                );

                carregar_clientes_com_query(
                    "SELECT * FROM cliente ORDER BY id_cliente DESC"
                );
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1451)
                {
                    MessageBox.Show(
                        "Há um aparelho registrado no nome desse cliente.\n\n" +
                        "Apague os aparelhos vinculados antes de excluir o cliente.",
                        "Cliente vinculado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    MessageBox.Show(
                        "Erro ao excluir: " + ex.Message
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro inesperado: " + ex.Message
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

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            btnPesquisar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnPesquisar.Width,
                btnPesquisar.Height, 25, 25));

            btnNovoCliente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnNovoCliente.Width,
                btnNovoCliente.Height, 25, 25));

            cmbFiltro.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbFiltro.Width,
                cmbFiltro.Height, 25, 25));

            txtBuscar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtBuscar.Width,
                txtBuscar.Height, 25, 25));
        }

    }
}
