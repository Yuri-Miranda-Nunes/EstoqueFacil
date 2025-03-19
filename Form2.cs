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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Leitura_de_solicitação_de_cliente
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeproduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstoque_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescricao.Clear();
            txtNomeproduto.Clear();
            txtCategoria.Clear();
            txtEstoque.Clear();
            txtPreco.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeProduto = txtNomeproduto.Text;
            string descricao = txtDescricao.Text;
            string preco = txtPreco.Text;
            string estoque = txtEstoque.Text;
            string categoria = txtCategoria.Text;

            // Verifica se os campos não estão vazios
            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(descricao) || string.IsNullOrEmpty(preco) || string.IsNullOrEmpty(estoque) || string.IsNullOrEmpty(categoria))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            // Conectar ao banco de dados
            string connStr = "Server=Localhost;Database=estoquefacil;User ID=root;password=;"; // Atualize com suas credenciais
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                try
                {
                    // Abre a conexão
                    conn.Open();

                    // Comando SQL para inserir os dados
                    string query = "INSERT INTO produtos (nome, descricao, preco, estoque, categoria) VALUES (@nome, @descricao, @preco, @estoque, @categoria)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Adiciona os parâmetros para evitar SQL Injection
                    cmd.Parameters.AddWithValue("@nome", nomeProduto);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@preco", preco);
                    cmd.Parameters.AddWithValue("@estoque", estoque);
                    cmd.Parameters.AddWithValue("@categoria", categoria);

                    // Executa o comando no banco
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Verifica se a inserção foi bem-sucedida
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao salvar os dados.");
                    }
                }
                catch (Exception ex)
                {
                    // Exibe erro caso haja algum problema na conexão ou execução do comando
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }

            txtDescricao.Clear();
            txtNomeproduto.Clear();
            txtCategoria.Clear();
            txtEstoque.Clear();
            txtPreco.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
