namespace projeto_integrador
{
    partial class FormGerenciarOrdem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGerenciarOrdem));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAparelho = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbAprovacaoOrcamento = new System.Windows.Forms.ComboBox();
            this.lblAprovaçãoOrcamento = new System.Windows.Forms.Label();
            this.txtValorEstimado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtOrdem = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdicionarItens = new System.Windows.Forms.Label();
            this.cmbAdicionarItens = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.dgvOrdemItens = new System.Windows.Forms.DataGridView();
            this.id_itens_ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apagar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtQtdItens = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.btnAdicionarItens = new System.Windows.Forms.Button();
            this.txtIDOrdem = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdemItens)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(240, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(376, 45);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nova Ordem de Serviço";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(26, 145);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(61, 21);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(26, 169);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(338, 21);
            this.cmbCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aparelho";
            // 
            // cmbAparelho
            // 
            this.cmbAparelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbAparelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAparelho.FormattingEnabled = true;
            this.cmbAparelho.Location = new System.Drawing.Point(26, 218);
            this.cmbAparelho.Name = "cmbAparelho";
            this.cmbAparelho.Size = new System.Drawing.Size(338, 21);
            this.cmbAparelho.TabIndex = 6;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.ForeColor = System.Drawing.Color.White;
            this.lblTecnico.Location = new System.Drawing.Point(22, 243);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(65, 21);
            this.lblTecnico.TabIndex = 8;
            this.lblTecnico.Text = "Técnico";
            // 
            // cmbAprovacaoOrcamento
            // 
            this.cmbAprovacaoOrcamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbAprovacaoOrcamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAprovacaoOrcamento.FormattingEnabled = true;
            this.cmbAprovacaoOrcamento.Items.AddRange(new object[] {
            "pendente",
            "aprovado",
            "recusado"});
            this.cmbAprovacaoOrcamento.Location = new System.Drawing.Point(26, 319);
            this.cmbAprovacaoOrcamento.Name = "cmbAprovacaoOrcamento";
            this.cmbAprovacaoOrcamento.Size = new System.Drawing.Size(162, 21);
            this.cmbAprovacaoOrcamento.TabIndex = 9;
            // 
            // lblAprovaçãoOrcamento
            // 
            this.lblAprovaçãoOrcamento.AutoSize = true;
            this.lblAprovaçãoOrcamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovaçãoOrcamento.ForeColor = System.Drawing.Color.White;
            this.lblAprovaçãoOrcamento.Location = new System.Drawing.Point(23, 295);
            this.lblAprovaçãoOrcamento.Name = "lblAprovaçãoOrcamento";
            this.lblAprovaçãoOrcamento.Size = new System.Drawing.Size(76, 17);
            this.lblAprovaçãoOrcamento.TabIndex = 10;
            this.lblAprovaçãoOrcamento.Text = "Orçamento";
            // 
            // txtValorEstimado
            // 
            this.txtValorEstimado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtValorEstimado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorEstimado.Location = new System.Drawing.Point(645, 320);
            this.txtValorEstimado.Name = "txtValorEstimado";
            this.txtValorEstimado.Size = new System.Drawing.Size(182, 20);
            this.txtValorEstimado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(641, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor do Serviço";
            // 
            // dtOrdem
            // 
            this.dtOrdem.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.dtOrdem.Location = new System.Drawing.Point(387, 270);
            this.dtOrdem.Name = "dtOrdem";
            this.dtOrdem.Size = new System.Drawing.Size(440, 20);
            this.dtOrdem.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(387, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Data";
            // 
            // lblAdicionarItens
            // 
            this.lblAdicionarItens.AutoSize = true;
            this.lblAdicionarItens.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarItens.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarItens.Location = new System.Drawing.Point(387, 96);
            this.lblAdicionarItens.Name = "lblAdicionarItens";
            this.lblAdicionarItens.Size = new System.Drawing.Size(120, 21);
            this.lblAdicionarItens.TabIndex = 17;
            this.lblAdicionarItens.Text = "Adicionar Itens";
            // 
            // cmbAdicionarItens
            // 
            this.cmbAdicionarItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbAdicionarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAdicionarItens.FormattingEnabled = true;
            this.cmbAdicionarItens.Location = new System.Drawing.Point(387, 120);
            this.cmbAdicionarItens.Name = "cmbAdicionarItens";
            this.cmbAdicionarItens.Size = new System.Drawing.Size(162, 21);
            this.cmbAdicionarItens.TabIndex = 21;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(12, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(66, 24);
            this.btnFechar.TabIndex = 44;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbTecnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(26, 266);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(338, 21);
            this.cmbTecnico.TabIndex = 7;
            // 
            // dgvOrdemItens
            // 
            this.dgvOrdemItens.AllowUserToAddRows = false;
            this.dgvOrdemItens.AllowUserToDeleteRows = false;
            this.dgvOrdemItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrdemItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdemItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_itens_ordem,
            this.Item,
            this.Quantidade,
            this.Apagar});
            this.dgvOrdemItens.Location = new System.Drawing.Point(387, 157);
            this.dgvOrdemItens.Name = "dgvOrdemItens";
            this.dgvOrdemItens.ReadOnly = true;
            this.dgvOrdemItens.Size = new System.Drawing.Size(440, 79);
            this.dgvOrdemItens.TabIndex = 45;
            this.dgvOrdemItens.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrdemItens_CellClick);
            // 
            // id_itens_ordem
            // 
            this.id_itens_ordem.HeaderText = "";
            this.id_itens_ordem.Name = "id_itens_ordem";
            this.id_itens_ordem.ReadOnly = true;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Apagar
            // 
            this.Apagar.HeaderText = "Apagar";
            this.Apagar.Name = "Apagar";
            this.Apagar.ReadOnly = true;
            // 
            // txtQtdItens
            // 
            this.txtQtdItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtQtdItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtdItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtdItens.Location = new System.Drawing.Point(567, 121);
            this.txtQtdItens.Name = "txtQtdItens";
            this.txtQtdItens.Size = new System.Drawing.Size(100, 22);
            this.txtQtdItens.TabIndex = 46;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.ForeColor = System.Drawing.Color.White;
            this.lblQuantidade.Location = new System.Drawing.Point(564, 96);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(95, 21);
            this.lblQuantidade.TabIndex = 47;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // btnAdicionarItens
            // 
            this.btnAdicionarItens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnAdicionarItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarItens.FlatAppearance.BorderSize = 0;
            this.btnAdicionarItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarItens.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarItens.Location = new System.Drawing.Point(696, 119);
            this.btnAdicionarItens.Name = "btnAdicionarItens";
            this.btnAdicionarItens.Size = new System.Drawing.Size(131, 25);
            this.btnAdicionarItens.TabIndex = 48;
            this.btnAdicionarItens.Text = "Adicionar";
            this.btnAdicionarItens.UseVisualStyleBackColor = false;
            this.btnAdicionarItens.Click += new System.EventHandler(this.btnAdicionarItens_Click);
            // 
            // txtIDOrdem
            // 
            this.txtIDOrdem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtIDOrdem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDOrdem.Location = new System.Drawing.Point(26, 122);
            this.txtIDOrdem.Name = "txtIDOrdem";
            this.txtIDOrdem.ReadOnly = true;
            this.txtIDOrdem.Size = new System.Drawing.Size(338, 22);
            this.txtIDOrdem.TabIndex = 49;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(23, 96);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 21);
            this.lblID.TabIndex = 50;
            this.lblID.Text = "ID Ordem";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(334, 376);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(215, 41);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Em diagnóstico",
            "Aguardando orçamento",
            "Aguardando peça",
            "Em manutenção",
            "Consertado",
            "Sem possibilidade de reparo"});
            this.cmbStatus.Location = new System.Drawing.Point(202, 320);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(162, 21);
            this.cmbStatus.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(199, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 52;
            this.label1.Text = "Status";
            // 
            // FormGerenciarOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(855, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtIDOrdem);
            this.Controls.Add(this.btnAdicionarItens);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.txtQtdItens);
            this.Controls.Add(this.dgvOrdemItens);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cmbAdicionarItens);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAdicionarItens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtOrdem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorEstimado);
            this.Controls.Add(this.lblAprovaçãoOrcamento);
            this.Controls.Add(this.cmbAprovacaoOrcamento);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbAparelho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGerenciarOrdem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNovaOrdem";
            this.Load += new System.EventHandler(this.FormGerenciarOrdem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdemItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAparelho;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cmbAprovacaoOrcamento;
        private System.Windows.Forms.Label lblAprovaçãoOrcamento;
        private System.Windows.Forms.TextBox txtValorEstimado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.ComboBox cmbAdicionarItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.DataGridView dgvOrdemItens;
        private System.Windows.Forms.TextBox txtQtdItens;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Button btnAdicionarItens;
        private System.Windows.Forms.TextBox txtIDOrdem;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_itens_ordem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewImageColumn Apagar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label1;
    }
}