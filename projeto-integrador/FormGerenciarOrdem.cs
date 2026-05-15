using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormGerenciarOrdem : Form
    {
        // STRING DE CONEXÃO
       
        MySqlConnection Conexao;
        string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
        private bool ordemSalvaNoBanco = false;
        public FormGerenciarOrdem(string id)
        {
            InitializeComponent();

            // CARREGA OS DADOS DAS COMBOBOX
            carregarTecnicos();
            carregarClientes();
            carregarAparelhos();
            carregarItens();
            txtIDOrdem.Text = id;
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

                    // COMBOBOX TÉCNICO
                    cmbTecnico.DataSource = dt;

                    cmbTecnico.DisplayMember = "nome_funcionario";

                    cmbTecnico.ValueMember = "id_funcionario";

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

        // MÉTODO PARA CARREGAR CLIENTES
        private void carregarClientes()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_cliente, nome
                                   FROM cliente";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // COMBOBOX CLIENTE
                    cmbCliente.DataSource = dt;

                    cmbCliente.DisplayMember = "nome";

                    cmbCliente.ValueMember = "id_cliente";

                    cmbCliente.SelectedIndex = -1;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao carregar clientes: " + erro.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        // MÉTODO PARA CARREGAR APARELHOS
        private void carregarAparelhos()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_aparelho, modelo
                                   FROM aparelho";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // COMBOBOX CLIENTE
                    cmbAparelho.DataSource = dt;

                    cmbAparelho.DisplayMember = "modelo";

                    cmbAparelho.ValueMember = "id_aparelho";

                    cmbAparelho.SelectedIndex = -1;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao carregar aparelhos: " + erro.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void carregarItens()
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    string sql = @"SELECT id_produto, nome_produto
                                   FROM produto";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    // COMBOBOX ITENS
                    cmbAdicionarItens.DataSource = dt;

                    cmbAdicionarItens.DisplayMember = "nome_produto";

                    cmbAdicionarItens.ValueMember = "id_produto";

                    cmbAdicionarItens.SelectedIndex = -1;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao carregar itens: " + erro.Message,
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private decimal ConsultarValorUnitario(object idObj)
        {
            // Se o ID for nulo ou não for um número válido (ex: texto temporário da inicialização), retorna 0
            if (idObj == null || !int.TryParse(idObj.ToString(), out int id))
            {
                return 0;
            }

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT valor_unitario FROM produto WHERE id_produto = @id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        object resultado = cmd.ExecuteScalar(); // Mais rápido e limpo que DataReader para buscar um único valor

                        if (resultado != null && resultado != DBNull.Value)
                        {
                            return Convert.ToDecimal(resultado);
                        }
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro ao consultar valor unitário: " + erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return 0;
        }

        // BOTÃO FECHAR
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

       
        private void btnAdicionarItens_Click(object sender, EventArgs e)
        {
            // 1. Validações básicas de segurança
            if (!int.TryParse(txtIDOrdem.Text.Trim(), out int idOrdem))
            {
                MessageBox.Show("ID da Ordem inválido ou em branco.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQtdItens.Text.Trim(), out int quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Insira uma quantidade válida maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbAdicionarItens.SelectedValue == null || !int.TryParse(cmbAdicionarItens.SelectedValue.ToString(), out int idProduto))
            {
                MessageBox.Show("Selecione um produto válido da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação extra: Para criar a ordem automaticamente, precisamos dos dados do cabeçalho preenchidos
            if (cmbCliente.SelectedIndex == -1 || cmbAparelho.SelectedIndex == -1 || cmbTecnico.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha Cliente, Aparelho e Técnico antes de adicionar itens.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    // 2. BLINDAGEM: Verifica se a ordem pai já existe no banco de dados
                    string sqlCheck = "SELECT COUNT(*) FROM ordem WHERE id_ordem = @id";
                    bool ordemExiste = false;

                    using (MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@id", idOrdem);
                        ordemExiste = Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0;
                    }

                    // 3. Se a ordem NÃO existe, insere ela primeiro automaticamente para evitar o erro de FK
                    if (!ordemExiste)
                    {
                        string sqlOrdem = @"INSERT INTO ordem (id_ordem, aprovacao_orcamento, valor, data_ordem, fk_id_cliente, fk_id_aparelho, fk_id_funcionario) 
                                   VALUES (@id, 'Em Aberto', 0.00, @data, @cliente, @aparelho, @funcionario)";

                        using (MySqlCommand cmdOrdem = new MySqlCommand(sqlOrdem, conn))
                        {
                            cmdOrdem.Parameters.AddWithValue("@id", idOrdem);
                            cmdOrdem.Parameters.AddWithValue("@data", DateTime.Now);
                            cmdOrdem.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                            cmdOrdem.Parameters.AddWithValue("@aparelho", cmbAparelho.SelectedValue);
                            cmdOrdem.Parameters.AddWithValue("@funcionario", cmbTecnico.SelectedValue);
                            cmdOrdem.ExecuteNonQuery();
                        }
                    }

                    // 4. Agora insere o item com 100% de certeza que a ordem existe
                    string sqlItem = "INSERT INTO item_ordem(fk_id_ordem, fk_id_produto, quantidade, valor_unitario) " +
                                     "VALUES(@fk_id_ordem, @fk_id_produto, @quantidade, @valor_unitario)";

                    using (MySqlCommand cmdItem = new MySqlCommand(sqlItem, conn))
                    {
                        decimal valorUnitario = ConsultarValorUnitario(idProduto);

                        cmdItem.Parameters.Add("@fk_id_ordem", MySqlDbType.Int32).Value = idOrdem;
                        cmdItem.Parameters.Add("@fk_id_produto", MySqlDbType.Int32).Value = idProduto;
                        cmdItem.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
                        cmdItem.Parameters.Add("@valor_unitario", MySqlDbType.Decimal).Value = valorUnitario;
                        cmdItem.ExecuteNonQuery();
                    }

                    conn.Close();

                    // 5. Atualiza o valor total da ordem (multiplicação e soma)
                    AtualizarValorTotalOrdem(idOrdem);

                    MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 6. Atualiza o DataGridView local (Nome do produto e Qtd)
                    carregar_itens_da_ordem(idOrdem);

                    // Limpa os campos de itens para a próxima digitação
                    txtQtdItens.Text = "1";
                    cmbAdicionarItens.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro crítico ao adicionar item: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carregar_itens_da_ordem(int idOrdem)
        {
            // Query que busca a quantidade da tabela 'item_ordem' 
            // e o nome do produto fazendo o JOIN com a tabela 'produto'
            string query = @"
        SELECT 
            io.quantidade, 
            p.nome_produto 
        FROM item_ordem io
        INNER JOIN produto p ON io.fk_id_produto = p.id_produto
        WHERE io.fk_id_ordem = @id_ordem";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Passa o ID da ordem com segurança
                        cmd.Parameters.AddWithValue("@id_ordem", idOrdem);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Limpa as linhas antigas do DataGridView antes de carregar as novas
                            dgvOrdemItens.Rows.Clear();

                            while (reader.Read())
                            {
                                // Adiciona no seu Grid: primeiro o Nome do Produto, depois a Quantidade
                                // (Certifique-se de que a ordem das colunas no seu Grid visual seja essa)
                                dgvOrdemItens.Rows.Add(
                                    reader["nome_produto"].ToString(),
                                    reader["quantidade"].ToString()
                                );
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao carregar itens da ordem: {ex.Message}", "Erro de Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex == -1) { MessageBox.Show("Selecione um técnico."); return; }
            if (cmbCliente.SelectedIndex == -1) { MessageBox.Show("Selecione um cliente."); return; }
            if (cmbAparelho.SelectedIndex == -1) { MessageBox.Show("Selecione um aparelho."); return; }
            if (!int.TryParse(txtIDOrdem.Text.Trim(), out int idOrdem)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    // Verifica se a ordem já existe para decidir se faz INSERT ou UPDATE
                    string verificarSql = "SELECT COUNT(*) FROM ordem WHERE id_ordem = @id";
                    conn.Open();

                    bool existe;
                    using (MySqlCommand checkCmd = new MySqlCommand(verificarSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id", idOrdem);
                        existe = Convert.ToInt32(checkCmd.ExecuteScalar()) > 0;
                    }

                    string sql;
                    if (!existe)
                    {
                        // Se não existe, cria a Ordem pai
                        sql = @"INSERT INTO ordem (id_ordem, aprovacao_orcamento, valor, data_ordem, fk_id_cliente, fk_id_aparelho, fk_id_funcionario) 
                        VALUES (@id, 'Em Aberto', 0, @data, @cliente, @aparelho, @funcionario)";
                    }
                    else
                    {
                        // Se já existe, atualiza os dados caso o usuário tenha mudado o técnico ou cliente na tela
                        sql = @"UPDATE ordem SET fk_id_cliente = @cliente, fk_id_aparelho = @aparelho, fk_id_funcionario = @funcionario 
                        WHERE id_ordem = @id";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idOrdem);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);
                        cmd.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                        cmd.Parameters.AddWithValue("@aparelho", cmbAparelho.SelectedValue);
                        cmd.Parameters.AddWithValue("@funcionario", cmbTecnico.SelectedValue);

                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Dados da Ordem de Serviço salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados da ordem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarValorTotalOrdem(int idOrdem)
        {
            // 1. Query para somar o total de todos os itens da ordem
            string sqlSoma = "SELECT COALESCE(SUM(quantidade * valor_unitario), 0) FROM item_ordem WHERE fk_id_ordem = @id";

            // 2. Query para atualizar o valor final na tabela ordem
            string sqlUpdate = "UPDATE ordem SET valor = @valorTotal WHERE id_ordem = @id";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    decimal valorTotal = 0;

                    // Busca a soma atualizada de todos os itens
                    using (MySqlCommand cmdSoma = new MySqlCommand(sqlSoma, conn))
                    {
                        cmdSoma.Parameters.AddWithValue("@id", idOrdem);
                        valorTotal = Convert.ToDecimal(cmdSoma.ExecuteScalar());
                    }

                    // Atualiza o valor na tabela pai 'ordem'
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@valorTotal", valorTotal);
                        cmdUpdate.Parameters.AddWithValue("@id", idOrdem);
                        cmdUpdate.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao recalcular o valor total da ordem: " + ex.Message, "Erro de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}