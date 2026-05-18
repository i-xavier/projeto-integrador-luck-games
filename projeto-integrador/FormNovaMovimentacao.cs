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
    public partial class FormNovaMovimentacao : Form
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

        MySqlConnection Conexao;
        string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
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
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    //SELECT DISTINCT nome_produto FROM produto;

                    // 1. Carregar Produtos
                    FillComboBox(conn, "SELECT id_produto, nome_produto FROM produto", cbProdutos, "nome_produto", "id_produto");
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

            // Criamos uma nova coluna no C# que combina os dados
            // Vamos chamar essa coluna de "exibicao_completa"
            dt.Columns.Add("exibicao_completa", typeof(string), "id_produto + ' - ' + nome_produto");

            cb.DataSource = dt;
            cb.DisplayMember = "exibicao_completa"; // Usamos a coluna que acabamos de criar
            cb.ValueMember = value; // Continua sendo id_produto

            // Filtro inteligente
            cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb.AutoCompleteSource = AutoCompleteSource.ListItems;

            cb.SelectedIndex = -1;
        }

        private int ObterEstoqueAtual(int idProduto)
        {
            int estoque = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    string sql = "SELECT quantidade_total FROM produto WHERE id_produto = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idProduto);

                    object resultado = cmd.ExecuteScalar();
                    if (resultado != null && resultado != DBNull.Value)
                    {
                        estoque = Convert.ToInt32(resultado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar estoque: " + ex.Message);
            }
            return estoque;
        }

        private void btnEnviarMovimentacao_Click(object sender, EventArgs e)
        {
            // 1. Validações básicas
            if (cbProdutos.SelectedValue == null || string.IsNullOrEmpty(txtQuantidade.Text))
            {
                MessageBox.Show("Por favor, selecione um produto e informe a quantidade.");
                return;
            }

            if (cbTipoMovimentacao.SelectedItem == null)
            {
                MessageBox.Show("Selecione o tipo de movimentação (Entrada/Saída).");
                return;
            }

            // 2. Captura os dados da tela
            int idProduto = Convert.ToInt32(cbProdutos.SelectedValue);
            int qtdInformada = Convert.ToInt32(txtQuantidade.Text);
            string tipo = cbTipoMovimentacao.SelectedItem.ToString();

            // 3. Busca o estoque atual usando a função que criamos
            int estoqueAtual = ObterEstoqueAtual(idProduto);
            int novoEstoque = 0;

            // 4. Realiza a lógica de soma ou subtração
            if (tipo == "Entrada")
            {
                novoEstoque = estoqueAtual + qtdInformada;
            }
            else if (tipo == "Saída")
            {
                if (qtdInformada > estoqueAtual)
                {
                    MessageBox.Show("Saldo insuficiente para realizar essa saída!");
                    return;
                }
                novoEstoque = estoqueAtual - qtdInformada;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                // 1. Query corrigida: usamos apenas os placeholders (@)
                string sql = "INSERT INTO movimentacao(tipo_movimentacao, quantidade, motivo, fk_id_produto_movimentacao, data_movimentacao) " +
                     "VALUES(@tipo, @quantidade, @motivo, @idProduto, @data)";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // 2. Adicionando os parâmetros de forma limpa
                    cmd.Parameters.AddWithValue("@tipo", tipo);
                    cmd.Parameters.AddWithValue("@quantidade", qtdInformada);
                    cmd.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                    cmd.Parameters.AddWithValue("@idProduto", idProduto);
                    cmd.Parameters.AddWithValue("@data", DateTime.Now);

                    conn.Open();
                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Movimentação registrada com sucesso!");
                        // Opcional: limpar campos após o sucesso
                        txtQuantidade.Clear();
                        cbProdutos.SelectedIndex = -1;
                        this.DialogResult = DialogResult.OK;
                        //this.Close();
                    }
                }
            }

            // 5. Agora você envia o 'novoEstoque' para o seu UPDATE no banco de dados
            AtualizarEstoqueNoBanco(idProduto, novoEstoque);
        }

        private void AtualizarEstoqueNoBanco(int idProduto, int novoEstoque) {
            try

            {
                
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    // 1. Query corrigida: usamos apenas os placeholders (@)
                    string sql = "UPDATE produto SET quantidade_total = @novaQtd WHERE id_produto = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        // 2. Adicionando os parâmetros de forma limpa
                        cmd.Parameters.AddWithValue("@novaQtd", novoEstoque);
                        cmd.Parameters.AddWithValue("@id", idProduto);

                        conn.Open();
                        int linhasAfetadas = cmd.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Movimentação registrada com sucesso!");
                            // Opcional: limpar campos após o sucesso
                            txtQuantidade.Clear();
                            cbProdutos.SelectedIndex = -1;
                            this.DialogResult = DialogResult.OK;
                            //this.Close();
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

            finally
            {
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                    Conexao.Close();

            }

        }

        private void FormNovaMovimentacao_Load(object sender, EventArgs e)
        {
            btnEnviarMovimentacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnEnviarMovimentacao.Width,
                btnEnviarMovimentacao.Height, 25, 25));

            txtQuantidade.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtQuantidade.Width,
                txtQuantidade.Height, 25, 25));

            txtMotivo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtMotivo.Width,
                txtMotivo.Height, 25, 25));

            cbProdutos.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbProdutos.Width,
                cbProdutos.Height, 25, 25));

            cbTipoMovimentacao.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbTipoMovimentacao.Width,
                cbTipoMovimentacao.Height, 25, 25));
        }
    }

}
    

