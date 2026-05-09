using Google.Protobuf.WellKnownTypes;
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
    public partial class FormCliente : Form
    {
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

            //Configuração inciial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details; //Define a visualização em "detalhes"
            lstCliente.LabelEdit = true; //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clica
            lstCliente.GridLines = false; //Exibe a slinhas de grade no ListView
            lstCliente.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstCliente.OwnerDraw = true;



            lstCliente.DrawColumnHeader += (sender, e) =>
            {
                using (Brush backBrush = new SolidBrush(Color.Black)) // cor do fundo
                using (Brush textBrush = new SolidBrush(Color.White))    // cor do texto
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, e.Font, textBrush, e.Bounds);
                }
            };

            lstCliente.DrawItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            lstCliente.DrawSubItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            //Definindo as colunas do ListView

            lstCliente.Columns.Add("ID", 79, HorizontalAlignment.Left); //Coluna do Código
            lstCliente.Columns.Add("Nome completo", 158, HorizontalAlignment.Left);//Coluna do Nome completo
            lstCliente.Columns.Add("Telefone", 158, HorizontalAlignment.Left);//Coluna do Nome social
            lstCliente.Columns.Add("CPF", 158, HorizontalAlignment.Left);//Coluna do E-mail
            //lstCliente.Columns.Add("CPF", 158, HorizontalAlignment.Left);//Coluna do CPF

            AjustarColunasIgualmente();

            lstCliente.Resize += (s, e) => AjustarColunasIgualmente();
            this.Resize += (s, e) => AjustarColunasIgualmente();

        }

        private void carregar_clientes_com_query(string query)
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
                lstCliente.Items.Clear();

                //Preenche o ListView com os dados dos cliente
                while (reader.Read())
                {
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)), //Código
                        reader.GetString(1),                    //Nome Completo
                        reader.GetString(2),                    //Nome Social
                        reader.GetString(3),                    //E-mail
                        //reader.GetString(4),                     //CPF
                    };

                    //Adiicona a linha ao ListView
                    lstCliente.Items.Add(new ListViewItem(row));
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

                // 1. Verificamos se o item selecionado é nulo ANTES de converter para string
                // Usamos ?.ToString() que retorna nulo se o objeto for nulo, sem dar erro.
                string selecionado = cmbFiltro.SelectedItem?.ToString();

                // 2. Lógica de decisão do filtro
                if (string.IsNullOrEmpty(selecionado) || selecionado == "Selecione")
                {
                    // Caso Geral: Busca em todas as colunas
                    query = @"
            SELECT id_cliente, nome, telefone, cpf
            FROM cliente
            WHERE CAST(id_cliente AS CHAR) LIKE @q
               OR nome LIKE @q
               OR telefone LIKE @q
               OR cpf LIKE @q
            ORDER BY id_cliente DESC;";
                }
                else
                {
                    // Caso Específico: Mapeia o nome amigável para o nome da coluna no banco
                    switch (selecionado)
                    {
                        case "Nome": campo = "nome"; break;
                        case "CPF": campo = "cpf"; break;
                        case "Telefone": campo = "telefone"; break;
                        case "ID": campo = "CAST(id_cliente AS CHAR)"; break;
                        default: campo = "nome"; break;
                    }

                    query = $@"
            SELECT id_cliente, nome, telefone, cpf
            FROM cliente
            WHERE {campo} LIKE @q
            ORDER BY id_cliente DESC;";
                }

                // 3. Execução
                carregar_clientes_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            carregar_clientes();

            FormNovoCliente form = new FormNovoCliente(codUser);

            if (form.ShowDialog() == DialogResult.OK) //Carrega o cliente cadastrado e mostra na consulta
            {
                carregar_clientes_com_query(
                    "SELECT * FROM cliente ORDER BY id_cliente DESC"
                );
            }

        }

        private void AjustarColunasIgualmente()
        {
            int totalColunas = lstCliente.Columns.Count;
            if (totalColunas == 0) return;

            int larguraTotal = lstCliente.ClientSize.Width;
            int larguraBase = larguraTotal / totalColunas;
            int resto = larguraTotal % totalColunas;

            for (int i = 0; i < totalColunas; i++)
            {
                lstCliente.Columns[i].Width = larguraBase;

                if (resto > 0)
                {
                    lstCliente.Columns[i].Width += 1;
                    resto--;
                }
            }
        }

        /*private void lstCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            //Obtém a coleção de itens selecionados
            ListView.SelectedListViewItemCollection clientedaselecao = lstCliente.SelectedItems;

            //PErcorre todos os itens selecionados (mesmo que normamelmente só tenha um item selecionado)
            foreach (ListViewItem item in clientedaselecao)
            {
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);

                // Exibe uma MessageBox com o código do cliente
                MessageBox.Show("Código do Cliente: " + codigo_cliente.ToString(),
                                "Código Selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                // Preenche os campos de texto com os dados do cliente selecionado
                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCPF.Text = item.SubItems[4].Text;
            }
        }*/
    }
}
