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
            this.notificaoEstoqueMinimo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbProdutosAbaixoDoEstoque = new System.Windows.Forms.ComboBox();
            this.lblnotificaoEstoqueMinimo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblItensEstoque = new System.Windows.Forms.Label();
            this.lblTituloItensEstoque = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalCategorias = new System.Windows.Forms.Label();
            this.lblTituloTotalCategoria = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalProdutos = new System.Windows.Forms.Label();
            this.lblTituloTotalProdutos = new System.Windows.Forms.Label();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFundo.SuspendLayout();
            this.notificaoEstoqueMinimo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovaMovimentacao
            // 
            this.btnNovaMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnNovaMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnNovaMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaMovimentacao.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.btnNovaMovimentacao.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaMovimentacao.Image")));
            this.btnNovaMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaMovimentacao.Location = new System.Drawing.Point(1317, 169);
            this.btnNovaMovimentacao.Name = "btnNovaMovimentacao";
            this.btnNovaMovimentacao.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNovaMovimentacao.Size = new System.Drawing.Size(205, 34);
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
            this.panelMedidaMenu.Size = new System.Drawing.Size(236, 697);
            this.panelMedidaMenu.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(596, 173);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 28);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Black;
            this.panelFundo.Controls.Add(this.btnPesquisar);
            this.panelFundo.Controls.Add(this.txtBuscar);
            this.panelFundo.Controls.Add(this.notificaoEstoqueMinimo);
            this.panelFundo.Controls.Add(this.panel3);
            this.panelFundo.Controls.Add(this.flowLayoutPanel1);
            this.panelFundo.Controls.Add(this.dgvProduto);
            this.panelFundo.Controls.Add(this.pictureBox1);
            this.panelFundo.Controls.Add(this.panel4);
            this.panelFundo.Controls.Add(this.cmbFiltro);
            this.panelFundo.Controls.Add(this.panel2);
            this.panelFundo.Controls.Add(this.btnNovoProduto);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.btnNovaMovimentacao);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1561, 697);
            this.panelFundo.TabIndex = 7;
            // 
            // notificaoEstoqueMinimo
            // 
            this.notificaoEstoqueMinimo.BackColor = System.Drawing.Color.DarkOrange;
            this.notificaoEstoqueMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificaoEstoqueMinimo.Controls.Add(this.pictureBox2);
            this.notificaoEstoqueMinimo.Controls.Add(this.cbProdutosAbaixoDoEstoque);
            this.notificaoEstoqueMinimo.Controls.Add(this.lblnotificaoEstoqueMinimo);
            this.notificaoEstoqueMinimo.Controls.Add(this.label2);
            this.notificaoEstoqueMinimo.Location = new System.Drawing.Point(533, 12);
            this.notificaoEstoqueMinimo.Name = "notificaoEstoqueMinimo";
            this.notificaoEstoqueMinimo.Size = new System.Drawing.Size(555, 106);
            this.notificaoEstoqueMinimo.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // cbProdutosAbaixoDoEstoque
            // 
            this.cbProdutosAbaixoDoEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdutosAbaixoDoEstoque.FormattingEnabled = true;
            this.cbProdutosAbaixoDoEstoque.Location = new System.Drawing.Point(140, 66);
            this.cbProdutosAbaixoDoEstoque.Name = "cbProdutosAbaixoDoEstoque";
            this.cbProdutosAbaixoDoEstoque.Size = new System.Drawing.Size(365, 29);
            this.cbProdutosAbaixoDoEstoque.TabIndex = 2;
            // 
            // lblnotificaoEstoqueMinimo
            // 
            this.lblnotificaoEstoqueMinimo.AutoSize = true;
            this.lblnotificaoEstoqueMinimo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotificaoEstoqueMinimo.Location = new System.Drawing.Point(136, 39);
            this.lblnotificaoEstoqueMinimo.Name = "lblnotificaoEstoqueMinimo";
            this.lblnotificaoEstoqueMinimo.Size = new System.Drawing.Size(0, 21);
            this.lblnotificaoEstoqueMinimo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Atenção:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.lblItensEstoque);
            this.panel3.Controls.Add(this.lblTituloItensEstoque);
            this.panel3.Location = new System.Drawing.Point(423, 245);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(269, 126);
            this.panel3.TabIndex = 9;
            // 
            // lblItensEstoque
            // 
            this.lblItensEstoque.AutoSize = true;
            this.lblItensEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItensEstoque.Location = new System.Drawing.Point(137, 71);
            this.lblItensEstoque.Name = "lblItensEstoque";
            this.lblItensEstoque.Size = new System.Drawing.Size(115, 47);
            this.lblItensEstoque.TabIndex = 1;
            this.lblItensEstoque.Text = "label5";
            // 
            // lblTituloItensEstoque
            // 
            this.lblTituloItensEstoque.AutoSize = true;
            this.lblTituloItensEstoque.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloItensEstoque.Location = new System.Drawing.Point(40, 12);
            this.lblTituloItensEstoque.Name = "lblTituloItensEstoque";
            this.lblTituloItensEstoque.Size = new System.Drawing.Size(181, 30);
            this.lblTituloItensEstoque.TabIndex = 0;
            this.lblTituloItensEstoque.Text = "Itens em Estoque";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(423, 245);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 126);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dgvProduto
            // 
            this.dgvProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(287, 386);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(1235, 237);
            this.dgvProduto.TabIndex = 11;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.lblTotalCategorias);
            this.panel4.Controls.Add(this.lblTituloTotalCategoria);
            this.panel4.Location = new System.Drawing.Point(1109, 245);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(269, 126);
            this.panel4.TabIndex = 9;
            // 
            // lblTotalCategorias
            // 
            this.lblTotalCategorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalCategorias.AutoSize = true;
            this.lblTotalCategorias.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCategorias.Location = new System.Drawing.Point(157, 71);
            this.lblTotalCategorias.Name = "lblTotalCategorias";
            this.lblTotalCategorias.Size = new System.Drawing.Size(115, 47);
            this.lblTotalCategorias.TabIndex = 1;
            this.lblTotalCategorias.Text = "label7";
            // 
            // lblTituloTotalCategoria
            // 
            this.lblTituloTotalCategoria.AutoSize = true;
            this.lblTituloTotalCategoria.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalCategoria.Location = new System.Drawing.Point(78, 12);
            this.lblTituloTotalCategoria.Name = "lblTituloTotalCategoria";
            this.lblTituloTotalCategoria.Size = new System.Drawing.Size(107, 30);
            this.lblTituloTotalCategoria.TabIndex = 0;
            this.lblTituloTotalCategoria.Text = "Categoria";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.lblTotalProdutos);
            this.panel2.Controls.Add(this.lblTituloTotalProdutos);
            this.panel2.Location = new System.Drawing.Point(766, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(269, 126);
            this.panel2.TabIndex = 8;
            // 
            // lblTotalProdutos
            // 
            this.lblTotalProdutos.AutoSize = true;
            this.lblTotalProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProdutos.Location = new System.Drawing.Point(133, 71);
            this.lblTotalProdutos.Name = "lblTotalProdutos";
            this.lblTotalProdutos.Size = new System.Drawing.Size(115, 47);
            this.lblTotalProdutos.TabIndex = 1;
            this.lblTotalProdutos.Text = "label3";
            // 
            // lblTituloTotalProdutos
            // 
            this.lblTituloTotalProdutos.AutoSize = true;
            this.lblTituloTotalProdutos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTotalProdutos.Location = new System.Drawing.Point(33, 12);
            this.lblTituloTotalProdutos.Name = "lblTituloTotalProdutos";
            this.lblTituloTotalProdutos.Size = new System.Drawing.Size(187, 30);
            this.lblTituloTotalProdutos.TabIndex = 0;
            this.lblTituloTotalProdutos.Text = "Total de Produtos";
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovoProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnNovoProduto.FlatAppearance.BorderSize = 0;
            this.btnNovoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoProduto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoProduto.ForeColor = System.Drawing.Color.Black;
            this.btnNovoProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoProduto.Image")));
            this.btnNovoProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoProduto.Location = new System.Drawing.Point(1100, 171);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNovoProduto.Size = new System.Drawing.Size(176, 34);
            this.btnNovoProduto.TabIndex = 7;
            this.btnNovoProduto.Text = "    Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            this.btnNovoProduto.Click += new System.EventHandler(this.btnNovoProduto_Click);
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
            this.panel1.Size = new System.Drawing.Size(1235, 5);
            this.panel1.TabIndex = 5;
            // 
            // FormEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 697);
            this.Controls.Add(this.panelMedidaMenu);
            this.Controls.Add(this.panelFundo);
            this.MinimumSize = new System.Drawing.Size(1577, 736);
            this.Name = "FormEstoque";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEstoque_Load);
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            this.notificaoEstoqueMinimo.ResumeLayout(false);
            this.notificaoEstoqueMinimo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaMovimentacao;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelMedidaMenu;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblItensEstoque;
        private System.Windows.Forms.Label lblTituloItensEstoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalCategorias;
        private System.Windows.Forms.Label lblTituloTotalCategoria;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalProdutos;
        private System.Windows.Forms.Label lblTituloTotalProdutos;
        private System.Windows.Forms.Panel notificaoEstoqueMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbProdutosAbaixoDoEstoque;
        private System.Windows.Forms.Label lblnotificaoEstoqueMinimo;
    }
}