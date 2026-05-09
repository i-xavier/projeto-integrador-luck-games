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

        private int? codigo_aparelho = null;
        public FormAparelho()
        {
            InitializeComponent();

            cmbFiltro.DataSource = new List<string>
            {
                "Selecione",
                "N°Serie",
                "Tipo",
                "Marca",
                "Modelo",
                "Cliente",
                "Data Entrada",
                "Estado"
            };

            //Configuração inciial do ListView para exibição dos dados dos clientes
            lstAparelho.View = View.Details; //Define a visualização em "detalhes"
            lstAparelho.LabelEdit = true; //Permite editar os títulos das colunas
            lstAparelho.AllowColumnReorder = true; //Permite reordenar as colunas
            lstAparelho.FullRowSelect = true; //Seleciona a linha inteira ao clica
            lstAparelho.GridLines = false; //Exibe a slinhas de grade no ListView
            lstAparelho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstAparelho.OwnerDraw = true;



            lstAparelho.DrawColumnHeader += (sender, e) =>
            {
                using (Brush backBrush = new SolidBrush(Color.Black)) // cor do fundo
                using (Brush textBrush = new SolidBrush(Color.White))    // cor do texto
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(e.Header.Text, e.Font, textBrush, e.Bounds);
                }
            };

            lstAparelho.DrawItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            lstAparelho.DrawSubItem += (sender, e) =>
            {
                e.DrawDefault = true;
            };

            //Definindo as colunas do ListView

            lstAparelho.Columns.Add("NºSerie", 79, HorizontalAlignment.Left); //Coluna do Código/Número de série
            lstAparelho.Columns.Add("Tipo", 158, HorizontalAlignment.Left);//Coluna do tipo do aparelho
            lstAparelho.Columns.Add("Marca", 158, HorizontalAlignment.Left);//Coluna da marca do aparelho
            lstAparelho.Columns.Add("Modelo", 158, HorizontalAlignment.Left);//Coluna do modelo do aparelho
            lstAparelho.Columns.Add("Cliente", 158, HorizontalAlignment.Left);//Coluna do cliente
            lstAparelho.Columns.Add("Data Entrada", 158, HorizontalAlignment.Left);//Coluna da data de entrada do aparelho
            lstAparelho.Columns.Add("Estado", 158, HorizontalAlignment.Left);//Coluna do estado do aparelho

            AjustarColunasIgualmente();

            lstAparelho.Resize += (s, e) => AjustarColunasIgualmente();
            this.Resize += (s, e) => AjustarColunasIgualmente();
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

                // 1. Verificamos se o item selecionado é nulo ANTES de converter para string
                // Usamos ?.ToString() que retorna nulo se o objeto for nulo, sem dar erro.
                string selecionado = cmbFiltro.SelectedItem?.ToString();

                // 2. Lógica de decisão do filtro
                if (string.IsNullOrEmpty(selecionado) || selecionado == "Selecione")
                {
                    // Caso Geral: Busca em todas as colunas
                    query = @"
            SELECT id_aparelho, tipo, marca, modelo, cliente, data_entrada, estado
            FROM aparelho
            WHERE CAST(id_aparelho AS CHAR) LIKE @q
               OR tipo LIKE @q
               OR marca LIKE @q
               OR modelo LIKE @q
               OR cliente LIKE @q
               OR data_entrada LIKE @q
               OR estado LIKE @q
            ORDER BY id_aparelho DESC;";
                }
                else
                {
                    // Caso Específico: Mapeia o nome amigável para o nome da coluna no banco
                    switch (selecionado)
                    {
                        case "NºSerie": campo = "CAST(id_aparelho AS CHAR)"; break;
                        case "Tipo": campo = "tipo"; break;
                        case "Marca": campo = "marca"; break;
                        case "Modelo": campo = "modelo"; break;
                        case "Cliente": campo = "cliente"; break;
                        case "Data Entrada": campo = "data_entrada"; break;
                        case "Estado": campo = "estado"; break;
                        default: campo = "tipo"; break;
                    }

                    query = $@"
            SELECT id_aparelho, tipo, marca, modelo, cliente, data_entrada, estado
            FROM aparelho
            WHERE {campo} LIKE @q
            ORDER BY id_aparelho DESC;";
                }

                // 3. Execução
                carregar_aparelhos_com_query(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar: " + ex.Message);
            }

        }

        private void carregar_aparelhos_com_query(string query)
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
                lstAparelho.Items.Clear();

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
                    lstAparelho.Items.Add(new ListViewItem(row));
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

        private void AjustarColunasIgualmente()
        {
            int totalColunas = lstAparelho.Columns.Count;
            if (totalColunas == 0) return;

            int larguraTotal = lstAparelho.ClientSize.Width;
            int larguraBase = larguraTotal / totalColunas;
            int resto = larguraTotal % totalColunas;

            for (int i = 0; i < totalColunas; i++)
            {
                lstAparelho.Columns[i].Width = larguraBase;

                if (resto > 0)
                {
                    lstAparelho.Columns[i].Width += 1;
                    resto--;
                }
            }
        }
    }
    }
    
    
    

