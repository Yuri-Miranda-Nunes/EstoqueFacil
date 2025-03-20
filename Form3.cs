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

namespace Leitura_de_solicitação_de_cliente
{

    public partial class ConsultaEstoque : Form
    {
        public ConsultaEstoque()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            carregarDados();
        }

        private void setaVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
        private void setaVoltar_MouseEnter(object sender, EventArgs e)
        {

        }
        private void carregarDados()
        {

            string connStr = "Server=Localhost;Database=estoquefacil;User ID=root;password=;";

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT * FROM produtos";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connStr);

                    DataTable dataTable = new DataTable();

                    dataAdapter.Fill(dataTable);


                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao carregar os dados; " + ex.Message);

                }
            }
        }



        private void setaVoltar_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obter o Id do registro selecionado
                int idParaExcluir = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value); // Substitua "Id" pelo nome correto da coluna

                // String de conexão com o banco de dados
                string connStr = "Server=Localhost;Database=estoquefacil;User ID=root;password=;";

                // Comando SQL para exclusão
                string query = "DELETE FROM produtos WHERE Id = @Id";

                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connStr))
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            // Definir o valor do parâmetro @Id
                            cmd.Parameters.AddWithValue("@Id", idParaExcluir);

                            // Executar o comando DELETE
                            int linhasAfetadas = cmd.ExecuteNonQuery();

                            // Verificar se a exclusão foi bem-sucedida
                            if (linhasAfetadas > 0)
                            {
                                MessageBox.Show("Registro excluído com sucesso!");
                                // Atualizar o DataGridView após a exclusão
                                carregarDados();
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um registro para excluir.");
            }
        }
    }
}

