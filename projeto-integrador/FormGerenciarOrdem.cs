using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace projeto_integrador
{
    public partial class FormGerenciarOrdem : Form
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

        private bool _isEdicao = false;
        private int _idOrdemParaEditar;
        public bool foiExcluido = false;
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

            if (!_isEdicao)
            {
                MostrarComponentesDeItens(false);
            }
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
                        string sqlOrdem = @"INSERT INTO ordem (id_ordem, aprovacao_orcamento, valor, data_ordem, fk_id_cliente_ordem, fk_id_aparelho_ordem, fk_id_funcionario_ordem) 
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

                    // CAPTURA O VALOR QUE O USUÁRIO DIGITOU NA TELA
                    // Se o campo estiver vazio ou incorreto, assume 0 para não quebrar o cálculo
                    decimal.TryParse(txtValorEstimado.Text.Trim(), out decimal valorBase);

                    // ATUALIZA PASSANDO O VALOR DA TELA + OS ITENS
                    AtualizarValorTotalOrdem(idOrdem, valorBase);

                    MessageBox.Show("Produto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza o DataGridView local (Nome do produto e Qtd)
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
            string query = "";  

            if (foiExcluido == true)
            {
                query = "SELECT * FROM item_ordem ORDER BY id_itens_ordem DESC";
            }

            else {

                query = @"
        SELECT
            io.fk_id_produto,
            io.quantidade, 
            p.nome_produto 
        FROM item_ordem io
        INNER JOIN produto p ON io.fk_id_produto = p.id_produto
        WHERE io.fk_id_ordem = @id_ordem";
            }

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
                                    reader["fk_id_produto"].ToString(),
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
            // 1. VALIDAÇÕES DOS CAMPOS OBRIGATÓRIOS
            if (cmbTecnico.SelectedIndex == -1) { MessageBox.Show("Selecione um técnico."); return; }
            if (cmbCliente.SelectedIndex == -1) { MessageBox.Show("Selecione um cliente."); return; }
            if (cmbAparelho.SelectedIndex == -1) { MessageBox.Show("Selecione um aparelho."); return; return; }
            if (!int.TryParse(txtIDOrdem.Text.Trim(), out int idOrdem)) return;

            // Resgata o valor estimado digitado na tela (caso esteja vazio ou inválido, assume 0)
            decimal.TryParse(txtValorEstimado.Text.Trim(), out decimal valorEstimado);

            try
            {
                if (_isEdicao)
                {
                    // ==========================================
                    // MODO EDIÇÃO: O registro já existe na listagem principal
                    // ==========================================
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
                        // Correção: Nomes das colunas ajustados de acordo com o script do seu banco
                        string sql = @"UPDATE ordem SET 
                                aprovacao_orcamento = @aprovacao,
                                valor = @valor,
                                data_ordem = @data, 
                                fk_id_cliente_ordem = @cliente, 
                                fk_id_aparelho_ordem = @aparelho, 
                                fk_id_funcionario_ordem = @funcionario
                              WHERE id_ordem = @id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idOrdem);
                            cmd.Parameters.AddWithValue("@data", DateTime.Now);
                            cmd.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                            cmd.Parameters.AddWithValue("@aparelho", cmbAparelho.SelectedValue);
                            cmd.Parameters.AddWithValue("@funcionario", cmbTecnico.SelectedValue);
                            cmd.Parameters.AddWithValue("@aprovacao", cmbAprovacaoOrcamento.SelectedItem?.ToString() ?? "pendente");
                            cmd.Parameters.AddWithValue("@valor", valorEstimado);

                            conn.Open(); // Correção: Abrindo a conexão que estava faltando no seu código
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Dados da Ordem de Serviço atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.DialogResult = DialogResult.OK;
                            this.Close(); // No modo edição de uma OS antiga, geralmente fechamos a tela ao salvar
                        }
                    }
                }
                else
                {
                    // ==========================================
                    // MODO CADASTRO: Nova Ordem sendo iniciada
                    // ==========================================
                    using (MySqlConnection conn = new MySqlConnection(conexao))
                    {
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
                            sql = @"INSERT INTO ordem (id_ordem, aprovacao_orcamento, valor, data_ordem, fk_id_cliente_ordem, fk_id_aparelho_ordem, fk_id_funcionario_ordem) 
                            VALUES (@id, @aprovacao, @valor, @data, @cliente, @aparelho, @funcionario)";
                        }
                        else
                        {
                            sql = @"UPDATE ordem SET fk_id_cliente_ordem = @cliente, fk_id_aparelho_ordem = @aparelho, fk_id_funcionario_ordem = @funcionario, valor = @valor 
                            WHERE id_ordem = @id";
                        }

                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idOrdem);
                            cmd.Parameters.AddWithValue("@data", DateTime.Now);
                            cmd.Parameters.AddWithValue("@aprovacao", cmbAprovacaoOrcamento.SelectedItem?.ToString() ?? "pendente");
                            cmd.Parameters.AddWithValue("@cliente", cmbCliente.SelectedValue);
                            cmd.Parameters.AddWithValue("@aparelho", cmbAparelho.SelectedValue);
                            cmd.Parameters.AddWithValue("@funcionario", cmbTecnico.SelectedValue);
                            cmd.Parameters.AddWithValue("@valor", valorEstimado);

                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Dados iniciais da Ordem de Serviço salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ==========================================
                            // PERGUNTA AO USUÁRIO SE DESEJA ADICIONAR ITENS
                            // ==========================================
                            DialogResult resposta = MessageBox.Show(
                                "Deseja adicionar produtos/itens a esta Ordem de Serviço agora?",
                                "Adicionar Itens",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question
                            );

                            if (resposta == DialogResult.Yes)
                            {
                                // Se SIM: Exibe os componentes de adicionar itens na tela para continuar nela
                                MostrarComponentesDeItens(true);
                            }
                            else
                            {
                                // Se NÃO: Fecha o formulário salvando o estado
                                this.DialogResult = DialogResult.OK;
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar dados da ordem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarValorTotalOrdem(int idOrdem, decimal valorBase)
        {// Query que soma apenas o valor total dos itens (quantidade * valor)
            string sqlSomaItens = "SELECT COALESCE(SUM(quantidade * valor_unitario), 0) FROM item_ordem WHERE fk_id_ordem = @id";

            // Query que atualiza o valor final na tabela ordem
            string sqlUpdateOrdem = "UPDATE ordem SET valor = @valorFinal WHERE id_ordem = @id";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                try
                {
                    conn.Open();

                    decimal totalItens = 0;

                    // 1. Busca a soma de todos os produtos inseridos
                    using (MySqlCommand cmdSoma = new MySqlCommand(sqlSomaItens, conn))
                    {
                        cmdSoma.Parameters.AddWithValue("@id", idOrdem);
                        totalItens = Convert.ToDecimal(cmdSoma.ExecuteScalar());
                    }

                    // 2. O valor final será o Valor Base (Mão de obra / Inicial) + Total dos Itens
                    decimal valorFinal = valorBase + totalItens;

                    // 3. Atualiza a tabela pai 'ordem' com o novo total somado
                    using (MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdateOrdem, conn))
                    {
                        cmdUpdate.Parameters.AddWithValue("@valorFinal", valorFinal);
                        cmdUpdate.Parameters.AddWithValue("@id", idOrdem);
                        cmdUpdate.ExecuteNonQuery();
                    }

                    // Opcional: Se você quiser atualizar o campo de texto da tela com o novo total
                    txtValorEstimado.Text = valorFinal.ToString("F2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao recalcular o valor total da ordem: " + ex.Message, "Erro de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ConfigurarEdicao(int id, string aprovacao_orcamento, decimal valor, DateTime data_ordem, int fkIdCliente, int fkIdAparelho, int fkIdFuncionario)

        {

            _isEdicao = true;

            _idOrdemParaEditar = id;



            // Altera os textos dos componentes

            this.Text = "Editar Ordem"; // Título da janela

            lblTitulo.Text = "Editar Dados";

            btnSalvar.Text = "Salvar Alterações";

            // Preenche os campos com os dados que vieram do Grid

            cmbAparelho.SelectedValue = fkIdAparelho;

            cmbCliente.SelectedValue = fkIdCliente;

            cmbAprovacaoOrcamento.Text = aprovacao_orcamento;

            cmbTecnico.SelectedValue = fkIdFuncionario;

            txtValorEstimado.Text = valor.ToString("F2");

            dtOrdem.Value = data_ordem;

            txtIDOrdem.Text = id.ToString();

        }

        private void MostrarComponentesDeItens(bool exibir)
        {
            // Substitua os nomes abaixo pelos nomes reais dos seus componentes de Itens da tela
            cmbAdicionarItens.Visible = exibir; // ComboBox de produtos
            txtQtdItens.Visible = exibir;       // TextBox da quantidade
            btnAdicionarItens.Visible = exibir; // Botão de Adicionar
            dgvOrdemItens.Visible = exibir;     // Tabela Grid de itens da ordem
            lblAdicionarItens.Visible = exibir; // Label de Adicionar Itens
            lblQuantidade.Visible = exibir;     // Label de Quantidade

            // Opcional: focar no campo de itens se estiver exibindo
            if (exibir)
            {
                cmbAdicionarItens.Focus();
            }
        }
        

        private void ExcluirItemOrdem(string id)
        {
            try
            {
                Conexao = new MySqlConnection(conexao);

                Conexao.Open();

                string sql =
                    "DELETE FROM item_ordem WHERE id_itens_ordem = @id";

                MySqlCommand cmd =
                    new MySqlCommand(sql, Conexao);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Produto excluído com sucesso!"
                );

              carregar_itens_da_ordem(int.Parse(id));

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

        private void dgvOrdemItens_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            string idItemOrdem =
                dgvOrdemItens.Rows[e.RowIndex]
                .Cells["id_itens_ordem"]
                .Value
                .ToString();


            // EXCLUIR
            if (dgvOrdemItens.Columns[e.ColumnIndex].Name
            == "Apagar")
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
                    ExcluirItemOrdem(idItemOrdem);
                    foiExcluido = true;
                }
            }
        }

        private void FormGerenciarOrdem_Load(object sender, EventArgs e)
        {
            cmbAdicionarItens.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbAdicionarItens.Width,
               cmbAdicionarItens.Height, 20, 20));

            cmbAparelho.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbAparelho.Width,
                cmbAparelho.Height, 20, 20));

            cmbAprovacaoOrcamento.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbAprovacaoOrcamento.Width,
                cmbAprovacaoOrcamento.Height, 20, 20));

            cmbCliente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbCliente.Width,
                cmbCliente.Height, 20, 20));

            cmbTecnico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cmbTecnico.Width,
                cmbTecnico.Height, 20, 20));

            dtOrdem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtOrdem.Width,
                dtOrdem.Height, 20, 20));

            txtIDOrdem.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtIDOrdem.Width,
                txtIDOrdem.Height, 20, 20));

            txtQtdItens.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtQtdItens.Width,
                txtQtdItens.Height, 20, 20));

            txtValorEstimado.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtValorEstimado.Width,
                txtValorEstimado.Height, 20, 20));

            btnAdicionarItens.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnAdicionarItens.Width,
                btnAdicionarItens.Height, 20, 20));

            btnSalvar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnSalvar.Width,
                btnSalvar.Height, 20, 20));
        }
    }
}