namespace projeto_integrador
{
    partial class FormEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEstoque));
            this.btnNovaMovimentacao = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelMedidaMenu = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblItensEstoque = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.lstProduto = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.panelFundo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNovaMovimentacao
            // 
            this.btnNovaMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnNovaMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnNovaMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMovimentacao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.btnNovaMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaMovimentacao.Image")));
            this.btnNovaMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaMovimentacao.Location = new System.Drawing.Point(1348, 171);
            this.btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            this.btnNovaMovimentacao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNovaMovimentacao.Size = new System.Drawing.Size(176, 34);
            this.btnNovaMovimentacao.TabIndex = 4;
            this.btnNovaMovimentacao.Text = "    Nova Movimentação";
            this.btnNovaMovimentacao.UseVisualStyleBackColor = false;
            this.btnNovaMovimentacao.Click += new System.EventHandler(this.btnNovaMovimentacao_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(287, 173);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(334, 28);
            this.txtBuscar.TabIndex = 8;
            // 
            // panelMedidaMenu
            // 
            this.panelMedidaMenu.BackColor = System.Drawing.Color.White;
            this.panelMedidaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMedidaMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMedidaMenu.Name = "panelMedidaMenu";
            this.panelMedidaMenu.Size = new System.Drawing.Size(236, 807);
            this.panelMedidaMenu.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(618, 173);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 28);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Black;
            this.panelFundo.Controls.Add(this.pictureBox1);
            this.panelFundo.Controls.Add(this.panel4);
            this.panelFundo.Controls.Add(this.cmbFiltro);
            this.panelFundo.Controls.Add(this.panel3);
            this.panelFundo.Controls.Add(this.panel2);
            this.panelFundo.Controls.Add(this.btnNovoProduto);
            this.panelFundo.Controls.Add(this.lstProduto);
            this.panelFundo.Controls.Add(this.btnPesquisar);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.btnNovaMovimentacao);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1575, 807);
            this.panelFundo.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lblCategoria);
            this.panel4.Location = new System.Drawing.Point(1150, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 126);
            this.panel4.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(109, 25);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblItensEstoque);
            this.panel3.Location = new System.Drawing.Point(794, 245);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 126);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // lblItensEstoque
            // 
            this.lblItensEstoque.AutoSize = true;
            this.lblItensEstoque.Location = new System.Drawing.Point(99, 24);
            this.lblItensEstoque.Name = "lblItensEstoque";
            this.lblItensEstoque.Size = new System.Drawing.Size(89, 13);
            this.lblItensEstoque.TabIndex = 0;
            this.lblItensEstoque.Text = "Itens em Estoque";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblTotalProdutos);
            this.panel2.Location = new System.Drawing.Point(435, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 126);
            this.panel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Location = new System.Drawing.Point(75, 25);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(91, 13);
            this.lblTotalProdutos.TabIndex = 0;
            this.lblTotalProdutos.Text = "Total de Produtos";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.Black;
            this.btnNovoProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.Image")));
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.Location = new System.Drawing.Point(1150, 171);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNovoProduto.Size = new System.Drawing.Size(176, 34);
            this.btnNovoProduto.TabIndex = 7;
            this.btnNovoProduto.Text = "    Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
            // 
            // lstProduto
            // 
            this.lstProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(22)))));
            this.lstProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstProduto.ForeColor = System.Drawing.Color.White;
            this.lstProduto.HideSelection = false;
            this.lstProduto.Location = new System.Drawing.Point(287, 386);
            this.lstProduto.Name = "lstProduto";
            this.lstProduto.Size = new System.Drawing.Size(1237, 347);
            this.lstProduto.TabIndex = 0;
            this.lstProduto.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estoque";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(287, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 5);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(674, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 21);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "ID",
            "Nome",
            "CPF",
            "Telefone"});
            this.cmbFiltro.Location = new System.Drawing.Point(711, 173);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 9;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 807);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.panelMedidaMenu);
            this.Controls.Add(this.panelFundo);
            this.Name = "FormEstoque";
            this.Text = "Form2";
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaMovimentacao;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelMedidaMenu;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.ListView lstProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblItensEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}