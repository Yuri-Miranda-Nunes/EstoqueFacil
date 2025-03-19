namespace Leitura_de_solicitação_de_cliente
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNomeproduto = new TextBox();
            txtDescricao = new TextBox();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            txtCategoria = new TextBox();
            btnLimpar = new Label();
            btnSalvar = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Image = Properties.Resources.Seta_pequena_esquerda_branca;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 48);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 40);
            label2.Name = "label2";
            label2.Size = new Size(344, 39);
            label2.TabIndex = 1;
            label2.Text = "Cadastrar Produto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Gainsboro;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(718, 258);
            label3.TabIndex = 2;
            label3.Click += label3_Click;
            // 
            // txtNomeproduto
            // 
            txtNomeproduto.Cursor = Cursors.IBeam;
            txtNomeproduto.Location = new Point(25, 111);
            txtNomeproduto.Name = "txtNomeproduto";
            txtNomeproduto.PlaceholderText = "Nome do Produto";
            txtNomeproduto.Size = new Size(694, 25);
            txtNomeproduto.TabIndex = 3;
            txtNomeproduto.TextChanged += txtNomeproduto_TextChanged;
            // 
            // txtDescricao
            // 
            txtDescricao.Cursor = Cursors.IBeam;
            txtDescricao.Location = new Point(25, 142);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PlaceholderText = "Descrição";
            txtDescricao.Size = new Size(694, 25);
            txtDescricao.TabIndex = 4;
            txtDescricao.TextChanged += txtDescricao_TextChanged;
            // 
            // txtPreco
            // 
            txtPreco.Cursor = Cursors.IBeam;
            txtPreco.Location = new Point(25, 173);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(694, 25);
            txtPreco.TabIndex = 5;
            txtPreco.TextChanged += txtPreco_TextChanged;
            // 
            // txtEstoque
            // 
            txtEstoque.Cursor = Cursors.IBeam;
            txtEstoque.Location = new Point(25, 204);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.PlaceholderText = "Estoque";
            txtEstoque.Size = new Size(694, 25);
            txtEstoque.TabIndex = 6;
            txtEstoque.TextChanged += txtEstoque_TextChanged;
            // 
            // txtCategoria
            // 
            txtCategoria.Cursor = Cursors.IBeam;
            txtCategoria.Location = new Point(25, 235);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.PlaceholderText = "Categoria";
            txtCategoria.Size = new Size(694, 25);
            txtCategoria.TabIndex = 7;
            txtCategoria.TextChanged += txtCategoria_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.BorderStyle = BorderStyle.FixedSingle;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.Location = new Point(25, 288);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(77, 40);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.MiddleCenter;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BorderStyle = BorderStyle.FixedSingle;
            btnSalvar.Cursor = Cursors.Hand;
            btnSalvar.FlatStyle = FlatStyle.Flat;
            btnSalvar.Location = new Point(642, 288);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(77, 40);
            btnSalvar.TabIndex = 9;
            btnSalvar.Text = "Salvar";
            btnSalvar.TextAlign = ContentAlignment.MiddleCenter;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 200, 83);
            ClientSize = new Size(742, 387);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(txtCategoria);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtNomeproduto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Swis721 Blk BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmCadastro";
            Text = "Cadastro de Produtos";
            Load += FrmCadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeproduto;
        private TextBox txtDescricao;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private TextBox txtCategoria;
        private Label btnLimpar;
        private Label btnSalvar;
    }
}