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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.AcceptButton = btnCadastrarCliente;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
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
            if (!txtCPF.Text.Contains("@"))
            {
                MessageBox.Show("CPF inválido!");
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
                }
            }



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
