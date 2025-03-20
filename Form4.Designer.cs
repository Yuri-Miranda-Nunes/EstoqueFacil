namespace Leitura_de_solicitação_de_cliente
{
    partial class Form4
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            btnVoltar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 200, 83);
            label1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(66, 19);
            label1.Name = "label1";
            label1.Padding = new Padding(150, 20, 150, 20);
            label1.Size = new Size(640, 79);
            label1.TabIndex = 1;
            label1.Text = "Edição de Produto";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 200, 83);
            button1.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(25, 288);
            button1.Name = "button1";
            button1.Size = new Size(77, 40);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 200, 83);
            button2.Font = new Font("Swis721 Blk BT", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(642, 288);
            button2.Name = "button2";
            button2.Size = new Size(77, 40);
            button2.TabIndex = 9;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Gainsboro;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(718, 258);
            label2.TabIndex = 2;
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_1;
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.Seta_pequena_esquerda_branca;
            btnVoltar.Location = new Point(-1, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(76, 52);
            btnVoltar.TabIndex = 10;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 200, 83);
            ClientSize = new Size(742, 387);
            Controls.Add(btnVoltar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Tela de Edição de Produtos ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label btnVoltar;
    }
}