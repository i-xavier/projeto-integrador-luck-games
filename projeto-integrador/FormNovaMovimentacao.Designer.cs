namespace projeto_integrador
{
    partial class FormNovaMovimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaMovimentacao));
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.btnEnviarMovimentacao = new System.Windows.Forms.Button();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTipoMovimentacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(12, 23);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFechar.Size = new System.Drawing.Size(123, 35);
            this.btnFechar.TabIndex = 22;
            this.btnFechar.Text = "  Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.White;
            this.lblCPF.Location = new System.Drawing.Point(60, 301);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(52, 17);
            this.lblCPF.TabIndex = 20;
            this.lblCPF.Text = "Motivo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(60, 243);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 17);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Quantidade";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompleto.Location = new System.Drawing.Point(60, 128);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(150, 17);
            this.lblNomeCompleto.TabIndex = 17;
            this.lblNomeCompleto.Text = "Tipo de Movimentação";
            // 
            // btnEnviarMovimentacao
            // 
            this.btnEnviarMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnEnviarMovimentacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnviarMovimentacao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnEnviarMovimentacao.FlatAppearance.BorderSize = 0;
            this.btnEnviarMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMovimentacao.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.btnEnviarMovimentacao.Location = new System.Drawing.Point(141, 373);
            this.btnEnviarMovimentacao.Name = "btnEnviarMovimentacao";
            this.btnEnviarMovimentacao.Size = new System.Drawing.Size(137, 40);
            this.btnEnviarMovimentacao.TabIndex = 16;
            this.btnEnviarMovimentacao.Text = "Enviar";
            this.btnEnviarMovimentacao.UseVisualStyleBackColor = false;
            this.btnEnviarMovimentacao.Click += new System.EventHandler(this.btnEnviarMovimentacao_Click);
            // 
            // txtMotivo
            // 
            this.txtMotivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivo.Location = new System.Drawing.Point(63, 321);
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(292, 28);
            this.txtMotivo.TabIndex = 15;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantidade.Location = new System.Drawing.Point(63, 263);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(292, 28);
            this.txtQuantidade.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Registrar Movimentação";
            // 
            // cbProdutos
            // 
            this.cbProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdutos.FormattingEnabled = true;
            this.cbProdutos.Location = new System.Drawing.Point(63, 206);
            this.cbProdutos.Name = "cbProdutos";
            this.cbProdutos.Size = new System.Drawing.Size(292, 29);
            this.cbProdutos.TabIndex = 24;
            this.cbProdutos.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Produto";
            // 
            // cbTipoMovimentacao
            // 
            this.cbTipoMovimentacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbTipoMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoMovimentacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoMovimentacao.FormattingEnabled = true;
            this.cbTipoMovimentacao.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipoMovimentacao.Location = new System.Drawing.Point(63, 149);
            this.cbTipoMovimentacao.Name = "cbTipoMovimentacao";
            this.cbTipoMovimentacao.Size = new System.Drawing.Size(292, 29);
            this.cbTipoMovimentacao.TabIndex = 26;
            this.cbTipoMovimentacao.Text = "Selecione";
            // 
            // FormNovaMovimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(420, 456);
            this.Controls.Add(this.cbTipoMovimentacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbProdutos);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.btnEnviarMovimentacao);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(420, 456);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 456);
            this.Name = "FormNovaMovimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastrarMovimentacao";
            this.Load += new System.EventHandler(this.FormNovaMovimentacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button btnEnviarMovimentacao;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTipoMovimentacao;
    }
}