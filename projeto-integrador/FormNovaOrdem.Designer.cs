namespace projeto_integrador
{
    partial class FormNovaOrdem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovaOrdem));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblIDOrdem = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdOrdem = new System.Windows.Forms.TextBox();
            this.cmbEquipamento = new System.Windows.Forms.ComboBox();
            this.lblTecnico = new System.Windows.Forms.Label();
            this.cmbAprovaçãoOrçamento = new System.Windows.Forms.ComboBox();
            this.lblAprovaçãoOrcamento = new System.Windows.Forms.Label();
            this.txtValorEstimado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdicionarItens = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cmbAdicionarItens = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Abrir Nova Ordem";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(29, 87);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 17);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(29, 107);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(338, 21);
            this.cmbCliente.TabIndex = 2;
           
            // 
            // lblIDOrdem
            // 
            this.lblIDOrdem.AutoSize = true;
            this.lblIDOrdem.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDOrdem.ForeColor = System.Drawing.Color.White;
            this.lblIDOrdem.Location = new System.Drawing.Point(29, 140);
            this.lblIDOrdem.Name = "lblIDOrdem";
            this.lblIDOrdem.Size = new System.Drawing.Size(67, 17);
            this.lblIDOrdem.TabIndex = 3;
            this.lblIDOrdem.Text = "ID Ordem";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Equipamentos";
            // 
            // txtIdOrdem
            // 
            this.txtIdOrdem.Location = new System.Drawing.Point(29, 160);
            this.txtIdOrdem.Name = "txtIdOrdem";
            this.txtIdOrdem.Size = new System.Drawing.Size(338, 20);
            this.txtIdOrdem.TabIndex = 5;
            // 
            // cmbEquipamento
            // 
            this.cmbEquipamento.FormattingEnabled = true;
            this.cmbEquipamento.Location = new System.Drawing.Point(29, 215);
            this.cmbEquipamento.Name = "cmbEquipamento";
            this.cmbEquipamento.Size = new System.Drawing.Size(338, 21);
            this.cmbEquipamento.TabIndex = 6;
            // 
            // lblTecnico
            // 
            this.lblTecnico.AutoSize = true;
            this.lblTecnico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnico.ForeColor = System.Drawing.Color.White;
            this.lblTecnico.Location = new System.Drawing.Point(26, 247);
            this.lblTecnico.Name = "lblTecnico";
            this.lblTecnico.Size = new System.Drawing.Size(52, 17);
            this.lblTecnico.TabIndex = 8;
            this.lblTecnico.Text = "Técnico";
            // 
            // cmbAprovaçãoOrçamento
            // 
            this.cmbAprovaçãoOrçamento.FormattingEnabled = true;
            this.cmbAprovaçãoOrçamento.Items.AddRange(new object[] {
            "Em Análise",
            "Aprovado",
            "Reprovado",
            "Pendente"});
            this.cmbAprovaçãoOrçamento.Location = new System.Drawing.Point(29, 325);
            this.cmbAprovaçãoOrçamento.Name = "cmbAprovaçãoOrçamento";
            this.cmbAprovaçãoOrçamento.Size = new System.Drawing.Size(148, 21);
            this.cmbAprovaçãoOrçamento.TabIndex = 9;
            // 
            // lblAprovaçãoOrcamento
            // 
            this.lblAprovaçãoOrcamento.AutoSize = true;
            this.lblAprovaçãoOrcamento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAprovaçãoOrcamento.ForeColor = System.Drawing.Color.White;
            this.lblAprovaçãoOrcamento.Location = new System.Drawing.Point(26, 305);
            this.lblAprovaçãoOrcamento.Name = "lblAprovaçãoOrcamento";
            this.lblAprovaçãoOrcamento.Size = new System.Drawing.Size(165, 17);
            this.lblAprovaçãoOrcamento.TabIndex = 10;
            this.lblAprovaçãoOrcamento.Text = "Aprovação do Orçamento";
            // 
            // txtValorEstimado
            // 
            this.txtValorEstimado.Location = new System.Drawing.Point(227, 325);
            this.txtValorEstimado.Name = "txtValorEstimado";
            this.txtValorEstimado.Size = new System.Drawing.Size(140, 20);
            this.txtValorEstimado.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor Estimado";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 382);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "DATA";
            // 
            // lblAdicionarItens
            // 
            this.lblAdicionarItens.AutoSize = true;
            this.lblAdicionarItens.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarItens.ForeColor = System.Drawing.Color.White;
            this.lblAdicionarItens.Location = new System.Drawing.Point(29, 411);
            this.lblAdicionarItens.Name = "lblAdicionarItens";
            this.lblAdicionarItens.Size = new System.Drawing.Size(99, 17);
            this.lblAdicionarItens.TabIndex = 17;
            this.lblAdicionarItens.Text = "Adicionar Itens";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(228)))), ((int)(((byte)(45)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Location = new System.Drawing.Point(82, 479);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(215, 25);
            this.btnSalvar.TabIndex = 20;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            // 
            // cmbAdicionarItens
            // 
            this.cmbAdicionarItens.FormattingEnabled = true;
            this.cmbAdicionarItens.Location = new System.Drawing.Point(29, 431);
            this.cmbAdicionarItens.Name = "cmbAdicionarItens";
            this.cmbAdicionarItens.Size = new System.Drawing.Size(338, 21);
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
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(29, 267);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(338, 21);
            this.cmbTecnico.TabIndex = 7;
            // 
            // FormNovaOrdem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(392, 530);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cmbAdicionarItens);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblAdicionarItens);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorEstimado);
            this.Controls.Add(this.lblAprovaçãoOrcamento);
            this.Controls.Add(this.cmbAprovaçãoOrçamento);
            this.Controls.Add(this.lblTecnico);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbEquipamento);
            this.Controls.Add(this.txtIdOrdem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIDOrdem);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovaOrdem";
            this.Text = "FormNovaOrdem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblIDOrdem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIdOrdem;
        private System.Windows.Forms.ComboBox cmbEquipamento;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.ComboBox cmbAprovaçãoOrçamento;
        private System.Windows.Forms.Label lblAprovaçãoOrcamento;
        private System.Windows.Forms.TextBox txtValorEstimado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdicionarItens;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cmbAdicionarItens;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ComboBox cmbTecnico;
    }
}