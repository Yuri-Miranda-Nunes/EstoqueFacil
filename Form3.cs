using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void setaVoltar_MouseLeave(object sender, EventArgs e)
        {
          
        }
    }
}
