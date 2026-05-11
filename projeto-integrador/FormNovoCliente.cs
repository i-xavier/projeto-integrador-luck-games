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
    public partial class FormNovoCliente : Form
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

        public FormNovoCliente(String codUser)
        {
            InitializeComponent();
            this.AcceptButton = btnCadastrarCliente;
            txtID.Text = codUser;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            int flag = 0;

            if (txtNomeCompleto.Text == "" || txtTelefone.Text == "" || txtCPF.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            // Validação telefone
            if (txtTelefone.Text.Length < 10)
            {
                MessageBox.Show("Telefone inválido!");
                return;
            }

            // Validação email
            /* if (!txtCPF.Text.Contains("@"))
             {
                 MessageBox.Show("CPF inválido!");
                 return;
             }*/

            //Validação cpf

            if (!txtCPF.Text.All(char.IsDigit) || txtCPF.Text.Length != 11)
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            flag = consultarCliente(txtCPF.Text.Trim());

            if (flag == 1)
            {
                MessageBox.Show("Cliente já foi cadastrado.", "Erro");
                return;
            }

            string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = "INSERT INTO cliente(nome, telefone, CPF) " +
             "VALUES(@nome, @telefone, @CPF)" ;

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();


                    MessageBox.Show("Cliente cadastrado com sucesso!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }

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

        private int consultarCliente(string cpfCliente)
        {
            int flag = 0;


            string conexao = "server=localhost;database=projeto_luck_games;uid=root;pwd=;";
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string query = "SELECT * FROM cliente WHERE CPF = @CPF";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@CPF", MySqlDbType.VarChar).Value = cpfCliente;
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            flag = 1;

                        }
                    }
                }
            }

            return flag;

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            txtCPF.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtCPF.Width,
               txtCPF.Height, 25, 25));

            txtID.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtID.Width,
               txtID.Height, 25, 25));

            txtNomeCompleto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtNomeCompleto.Width,
               txtNomeCompleto.Height, 25, 25));

            txtTelefone.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtTelefone.Width,
               txtTelefone.Height, 25, 25));

            btnCadastrarCliente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,btnCadastrarCliente.Width,
               btnCadastrarCliente.Height, 25, 25));
        }
    }
}
