namespace Leitura_de_solicitação_de_cliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btnAdicionar = new Button();
            btnConsutar = new Button();
            btnConfiguracao = new Button();
            btnSair = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 200, 83);
            label1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(-34, -5);
            label1.Name = "label1";
            label1.Padding = new Padding(150, 20, 150, 20);
            label1.Size = new Size(808, 79);
            label1.TabIndex = 0;
            label1.Text = "Bem-Vindo ao Estoque Fácil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Location = new Point(-15, 74);
            label2.Name = "label2";
            label2.Padding = new Padding(400, 20, 400, 10);
            label2.Size = new Size(800, 45);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.BackColor = Color.FromArgb(0, 200, 83);
            btnAdicionar.Cursor = Cursors.Hand;
            btnAdicionar.Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.ForeColor = SystemColors.ActiveCaptionText;
            btnAdicionar.Location = new Point(61, 176);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(170, 61);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar Produto";
            btnAdicionar.UseVisualStyleBackColor = false;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnConsutar
            // 
            btnConsutar.BackColor = Color.DarkGray;
            btnConsutar.Cursor = Cursors.Hand;
            btnConsutar.Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConsutar.ForeColor = SystemColors.ActiveCaptionText;
            btnConsutar.Location = new Point(274, 176);
            btnConsutar.Name = "btnConsutar";
            btnConsutar.Size = new Size(170, 61);
            btnConsutar.TabIndex = 3;
            btnConsutar.Text = "Consultar Estoque";
            btnConsutar.UseVisualStyleBackColor = false;
            btnConsutar.Click += btnConsutar_Click;
            // 
            // btnConfiguracao
            // 
            btnConfiguracao.BackColor = Color.DarkGray;
            btnConfiguracao.Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfiguracao.Location = new Point(493, 176);
            btnConfiguracao.Name = "btnConfiguracao";
            btnConfiguracao.Size = new Size(170, 61);
            btnConfiguracao.TabIndex = 4;
            btnConfiguracao.Text = "Configurações";
            btnConfiguracao.UseVisualStyleBackColor = false;
            btnConfiguracao.Click += btnConfiguracao_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.OrangeRed;
            btnSair.Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(644, 284);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 40);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 200, 83);
            label3.Location = new Point(-6, 338);
            label3.Name = "label3";
            label3.Padding = new Padding(500, 20, 300, 10);
            label3.Size = new Size(800, 45);
            label3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 200, 86);
            label4.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(12, 353);
            label4.Name = "label4";
            label4.Size = new Size(82, 16);
            label4.TabIndex = 7;
            label4.Text = "Contatos -";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 200, 86);
            label5.Font = new Font("Swis721 Blk BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(91, 354);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 8;
            label5.Text = "(12) 991232-1234";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 200, 86);
            label6.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(465, 354);
            label6.Name = "label6";
            label6.Size = new Size(60, 16);
            label6.TabIndex = 9;
            label6.Text = "E-mail -";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 200, 86);
            label7.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(522, 354);
            label7.Name = "label7";
            label7.Size = new Size(186, 16);
            label7.TabIndex = 10;
            label7.Text = "Estoque.facil@gmail.com";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkGray;
            label8.Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Green;
            label8.Location = new Point(103, 88);
            label8.Name = "label8";
            label8.Size = new Size(92, 18);
            label8.TabIndex = 11;
            label8.Text = "Sobre Nós";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkGray;
            label9.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(274, 88);
            label9.Name = "label9";
            label9.Size = new Size(173, 16);
            label9.TabIndex = 12;
            label9.Text = "Missão Visão e Valores";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGray;
            label10.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(534, 90);
            label10.Name = "label10";
            label10.Size = new Size(78, 16);
            label10.TabIndex = 13;
            label10.Text = "FeedBack";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(742, 387);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSair);
            Controls.Add(label3);
            Controls.Add(btnConfiguracao);
            Controls.Add(btnConsutar);
            Controls.Add(btnAdicionar);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pagina inicial";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnAdicionar;
        private Button btnConsutar;
        private Button btnConfiguracao;
        private Button btnSair;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
