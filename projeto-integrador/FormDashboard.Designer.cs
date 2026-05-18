namespace projeto_integrador
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.panelMedidaMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAparelhos = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnOrdens = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalClientes = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPeçasEstoque = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOrdensFinalizadas = new System.Windows.Forms.Label();
            this.lblTituloItensEstoque = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMedidaMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnAtualizar.Image")));
            this.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.Location = new System.Drawing.Point(992, 367);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(161, 48);
            this.btnAtualizar.TabIndex = 4;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // panelMedidaMenu
            // 
            this.panelMedidaMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.panelMedidaMenu.Controls.Add(this.btnLogout);
            this.panelMedidaMenu.Controls.Add(this.btnAparelhos);
            this.panelMedidaMenu.Controls.Add(this.btnEstoque);
            this.panelMedidaMenu.Controls.Add(this.btnOrdens);
            this.panelMedidaMenu.Controls.Add(this.btnClientes);
            this.panelMedidaMenu.Controls.Add(this.btnDashboard);
            this.panelMedidaMenu.Controls.Add(this.panelLogo);
            this.panelMedidaMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMedidaMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMedidaMenu.Name = "panelMedidaMenu";
            this.panelMedidaMenu.Size = new System.Drawing.Size(236, 842);
            this.panelMedidaMenu.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 335);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(236, 47);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAparelhos
            // 
            this.btnAparelhos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAparelhos.FlatAppearance.BorderSize = 0;
            this.btnAparelhos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAparelhos.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAparelhos.ForeColor = System.Drawing.Color.White;
            this.btnAparelhos.Image = ((System.Drawing.Image)(resources.GetObject("btnAparelhos.Image")));
            this.btnAparelhos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAparelhos.Location = new System.Drawing.Point(0, 288);
            this.btnAparelhos.Name = "btnAparelhos";
            this.btnAparelhos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAparelhos.Size = new System.Drawing.Size(236, 47);
            this.btnAparelhos.TabIndex = 19;
            this.btnAparelhos.Text = "          Aparelhos";
            this.btnAparelhos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAparelhos.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = ((System.Drawing.Image)(resources.GetObject("btnEstoque.Image")));
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 241);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEstoque.Size = new System.Drawing.Size(236, 47);
            this.btnEstoque.TabIndex = 18;
            this.btnEstoque.Text = "          Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnOrdens
            // 
            this.btnOrdens.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdens.FlatAppearance.BorderSize = 0;
            this.btnOrdens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdens.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdens.ForeColor = System.Drawing.Color.White;
            this.btnOrdens.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdens.Image")));
            this.btnOrdens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdens.Location = new System.Drawing.Point(0, 194);
            this.btnOrdens.Name = "btnOrdens";
            this.btnOrdens.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrdens.Size = new System.Drawing.Size(236, 47);
            this.btnOrdens.TabIndex = 17;
            this.btnOrdens.Text = "          Ordens de Serviço";
            this.btnOrdens.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdens.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 147);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(236, 47);
            this.btnClientes.TabIndex = 16;
            this.btnClientes.Text = "          Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 100);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(236, 47);
            this.btnDashboard.TabIndex = 15;
            this.btnDashboard.Text = "          Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(236, 100);
            this.panelLogo.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, -18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 159);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.Black;
            this.panelFundo.Controls.Add(this.chart1);
            this.panelFundo.Controls.Add(this.panel2);
            this.panelFundo.Controls.Add(this.panel4);
            this.panelFundo.Controls.Add(this.panel3);
            this.panelFundo.Controls.Add(this.label1);
            this.panelFundo.Controls.Add(this.panel1);
            this.panelFundo.Controls.Add(this.btnAtualizar);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1753, 842);
            this.panelFundo.TabIndex = 7;
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(263, 438);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1464, 392);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel2.Controls.Add(this.lblTotalClientes);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(798, 147);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 195);
            this.panel2.TabIndex = 11;
            // 
            // lblTotalClientes
            // 
            this.lblTotalClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalClientes.AutoSize = true;
            this.lblTotalClientes.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalClientes.Location = new System.Drawing.Point(116, 79);
            this.lblTotalClientes.Name = "lblTotalClientes";
            this.lblTotalClientes.Size = new System.Drawing.Size(166, 65);
            this.lblTotalClientes.TabIndex = 1;
            this.lblTotalClientes.Text = "label5";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(43, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total de Clientes";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel4.Controls.Add(this.lblPeçasEstoque);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(1348, 147);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 195);
            this.panel4.TabIndex = 12;
            // 
            // lblPeçasEstoque
            // 
            this.lblPeçasEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeçasEstoque.AutoSize = true;
            this.lblPeçasEstoque.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeçasEstoque.Location = new System.Drawing.Point(117, 79);
            this.lblPeçasEstoque.Name = "lblPeçasEstoque";
            this.lblPeçasEstoque.Size = new System.Drawing.Size(166, 65);
            this.lblPeçasEstoque.TabIndex = 1;
            this.lblPeçasEstoque.Text = "label5";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(41, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Peças em Estoque";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel3.Controls.Add(this.lblOrdensFinalizadas);
            this.panel3.Controls.Add(this.lblTituloItensEstoque);
            this.panel3.Location = new System.Drawing.Point(260, 147);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 195);
            this.panel3.TabIndex = 13;
            // 
            // lblOrdensFinalizadas
            // 
            this.lblOrdensFinalizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrdensFinalizadas.AutoSize = true;
            this.lblOrdensFinalizadas.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblOrdensFinalizadas.Location = new System.Drawing.Point(117, 79);
            this.lblOrdensFinalizadas.Name = "lblOrdensFinalizadas";
            this.lblOrdensFinalizadas.Size = new System.Drawing.Size(166, 65);
            this.lblOrdensFinalizadas.TabIndex = 1;
            this.lblOrdensFinalizadas.Text = "label5";
            // 
            // lblTituloItensEstoque
            // 
            this.lblTituloItensEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTituloItensEstoque.AutoSize = true;
            this.lblTituloItensEstoque.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloItensEstoque.Location = new System.Drawing.Point(30, 6);
            this.lblTituloItensEstoque.Name = "lblTituloItensEstoque";
            this.lblTituloItensEstoque.Size = new System.Drawing.Size(323, 47);
            this.lblTituloItensEstoque.TabIndex = 0;
            this.lblTituloItensEstoque.Text = "Ordens finalizadas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.panel1.Location = new System.Drawing.Point(287, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 5);
            this.panel1.TabIndex = 5;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1753, 842);
            this.Controls.Add(this.panelMedidaMenu);
            this.Controls.Add(this.panelFundo);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panelMedidaMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelFundo.ResumeLayout(false);
            this.panelFundo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panelMedidaMenu;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAparelhos;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnOrdens;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPeçasEstoque;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOrdensFinalizadas;
        private System.Windows.Forms.Label lblTituloItensEstoque;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}