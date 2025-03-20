namespace Leitura_de_solicitação_de_cliente
{
    partial class ConsultaEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEstoque));
            label1 = new Label();
            dataGridView1 = new DataGridView();
            setaVoltar = new Label();
            btnExcluir = new Label();
            label4 = new Label();
            btnEditar = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(181, 22);
            label1.Name = "label1";
            label1.Size = new Size(381, 39);
            label1.TabIndex = 0;
            label1.Text = "Consulta de Estoque";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(122, 64);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(498, 227);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // setaVoltar
            // 
            setaVoltar.Image = Properties.Resources.Seta_pequena_esquerda_branca;
            setaVoltar.Location = new Point(12, 13);
            setaVoltar.Name = "setaVoltar";
            setaVoltar.Size = new Size(48, 48);
            setaVoltar.TabIndex = 4;
            setaVoltar.Click += setaVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = true;
            btnExcluir.Image = Properties.Resources.delete;
            btnExcluir.Location = new Point(478, 319);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Padding = new Padding(15, 10, 15, 10);
            btnExcluir.Size = new Size(30, 35);
            btnExcluir.TabIndex = 5;
            btnExcluir.Tag = "";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(467, 354);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 6;
            label4.Text = "Excluir";
            // 
            // btnEditar
            // 
            btnEditar.AutoSize = true;
            btnEditar.Image = Properties.Resources.edit_pequeno;
            btnEditar.Location = new Point(205, 319);
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(15, 10, 15, 10);
            btnEditar.Size = new Size(30, 35);
            btnEditar.TabIndex = 7;
            btnEditar.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(195, 354);
            label6.Name = "label6";
            label6.Size = new Size(50, 16);
            label6.TabIndex = 8;
            label6.Text = "Editar";
            // 
            // ConsultaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 200, 83);
            ClientSize = new Size(742, 387);
            Controls.Add(label6);
            Controls.Add(btnEditar);
            Controls.Add(label4);
            Controls.Add(btnExcluir);
            Controls.Add(setaVoltar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConsultaEstoque";
            Text = "Consultar Estoque";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label setaVoltar;
        private Label btnExcluir;
        private Label label4;
        private Label btnEditar;
        private Label label6;

    }
}