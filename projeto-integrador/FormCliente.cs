using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projeto_integrador
{
    public partial class FormCliente : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=projeto_luck_games";

        private int? codigo_cliente = null;
        public FormCliente()
        {
            InitializeComponent();

            //Configuração inciial do ListView para exibição dos dados dos clientes
            lstCliente.View = View.Details; //Define a visualização em "detalhes"
            lstCliente.LabelEdit = true; //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true; //Permite reordenar as colunas
            lstCliente.FullRowSelect = true; //Seleciona a linha inteira ao clica
            lstCliente.GridLines = true; //Exibe a slinhas de grade no ListView

            //Definindo as colunas do ListView
            lstCliente.Columns.Add("ID", 79, HorizontalAlignment.Left); //Coluna do Código
            lstCliente.Columns.Add("Nome completo", 158, HorizontalAlignment.Left);//Coluna do Nome completo
            lstCliente.Columns.Add("Telefone", 158, HorizontalAlignment.Left);//Coluna do Nome social
            lstCliente.Columns.Add("CPF", 158, HorizontalAlignment.Left);//Coluna do E-mail
            //lstCliente.Columns.Add("CPF", 158, HorizontalAlignment.Left);//Coluna do CPF

            //Carregar os dados dos clientes na interface
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

        private void carregar_clientes()
        {
            string query = "Select * FROM cliente ORDER BY id_cliente DESC";
            carregar_clientes_com_query(query);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM cliente WHERE nome LIKE @q OR id_cliente LIKE @q ORDER BY id_cliente DESC";
            carregar_clientes_com_query(query);
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
            //this.Hide();
            //this.Close();
            form.ShowDialog();
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
