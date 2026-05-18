namespace projeto_integrador
{
    partial class FormOrdemDeServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrdemDeServico));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panelMedidaMenu = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovaOS = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.dgvOS = new System.Windows.Forms.DataGridView();
            this.labelOS = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(289, 173);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(334, 28);
            this.txtBuscar.TabIndex = 5;
            // 
            // panelMedidaMenu
            // 
            this.panelMedidaMenu.BackColor = System.Drawing.Color.White;
            this.panelMedidaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMedidaMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMedidaMenu.Name = "panelMedidaMenu";
            this.panelMedidaMenu.Size = new System.Drawing.Size(236, 638);
            this.panelMedidaMenu.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(598, 173);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(37, 28);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnNovaOS
            // 
            this.btnNovaOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovaOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnNovaOS.FlatAppearance.BorderSize = 0;
            this.btnNovaOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaOS.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaOS.ForeColor = System.Drawing.Color.Black;
            this.btnNovaOS.Image = ((System.Drawing.Image)(resources.GetObject("btnNovaOS.Image")));
            this.btnNovaOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaOS.Location = new System.Drawing.Point(1011, 171);
            this.btnNovaOS.Name = "btnNovaOS";
            this.btnNovaOS.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNovaOS.Size = new System.Drawing.Size(176, 34);
            this.btnNovaOS.TabIndex = 4;
            this.btnNovaOS.Text = "    Nova Ordem";
            this.btnNovaOS.UseVisualStyleBackColor = false;
            this.btnNovaOS.Click += new System.EventHandler(this.btnNovaOS_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Black;
            this.panelFundo.Controls.Add(this.btnPesquisar);
            this.panelFundo.Controls.Add(this.txtBuscar);
            this.panelFundo.Controls.Add(this.pictureBox1);
            this.panelFundo.Controls.Add(this.cmbFiltro);
            this.panelFundo.Controls.Add(this.dgvOS);
            this.panelFundo.Controls.Add(this.labelOS);
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.btnNovaOS);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1238, 638);
            this.panelFundo.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 21);
            this.pictureBox1.TabIndex = 12;
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
            this.cmbFiltro.Location = new System.Drawing.Point(326, 218);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 11;
            // 
            // dgvOS
            // 
            this.dgvOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOS.Location = new System.Drawing.Point(287, 261);
            this.dgvOS.Name = "dgvOS";
            this.dgvOS.Size = new System.Drawing.Size(916, 342);
            this.dgvOS.TabIndex = 7;
            // 
            // labelOS
            // 
            this.labelOS.AutoSize = true;
            this.labelOS.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOS.ForeColor = System.Drawing.Color.White;
            this.labelOS.Location = new System.Drawing.Point(280, 93);
            this.labelOS.Name = "labelOS";
            this.labelOS.Size = new System.Drawing.Size(239, 37);
            this.labelOS.TabIndex = 6;
            this.labelOS.Text = "Ordens de Serviço";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(287, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 5);
            this.panel1.TabIndex = 5;
            // 
            // FormOrdemDeServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 638);
            this.Controls.Add(this.panelMedidaMenu);
            this.Controls.Add(this.panelFundo);
            this.Name = "FormOrdemDeServico";
            this.Text = "FormOrdens";
            this.Load += new System.EventHandler(this.FormOrdemDeServico_Load);
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Panel panelMedidaMenu;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovaOS;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvOS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbFiltro;
    }
}