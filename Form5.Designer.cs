namespace Leitura_de_solicitação_de_cliente
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            label1 = new Label();
            btnVoltar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(274, 20);
            label1.Name = "label1";
            label1.Size = new Size(253, 39);
            label1.TabIndex = 0;
            label1.Text = "Configuração";
            // 
            // btnVoltar
            // 
            btnVoltar.Image = Properties.Resources.Seta_pequena_esquerda_branca;
            btnVoltar.Location = new Point(2, 9);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 66);
            btnVoltar.TabIndex = 1;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 200, 83);
            ClientSize = new Size(800, 450);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form5";
            Text = "Configuração";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label btnVoltar;
    }
}