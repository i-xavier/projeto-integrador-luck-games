namespace projeto_integrador
{
    partial class FormNovoAparelho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNovoAparelho));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoDoCliente = new System.Windows.Forms.Label();
            this.txtCodigoDoCliente = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTipodeAparelho = new System.Windows.Forms.Label();
            this.cbTipodeAparelho = new System.Windows.Forms.ComboBox();
            this.lblNumerodeSerie = new System.Windows.Forms.Label();
            this.txtNumerodeSerie = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnexarFoto = new System.Windows.Forms.Label();
            this.btnAnexarFoto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDescriçãoDoProblema = new System.Windows.Forms.Label();
            this.txtDescriçãoDoProblema = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpDataEntrada = new System.Windows.Forms.DateTimePicker();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Aparelho";
            // 
            // lblCodigoDoCliente
            // 
            this.lblCodigoDoCliente.AutoSize = true;
            this.lblCodigoDoCliente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoDoCliente.ForeColor = System.Drawing.Color.White;
            this.lblCodigoDoCliente.Location = new System.Drawing.Point(18, 78);
            this.lblCodigoDoCliente.Name = "lblCodigoDoCliente";
            this.lblCodigoDoCliente.Size = new System.Drawing.Size(116, 17);
            this.lblCodigoDoCliente.TabIndex = 1;
            this.lblCodigoDoCliente.Text = "Código do Cliente";
            // 
            // txtCodigoDoCliente
            // 
            this.txtCodigoDoCliente.Location = new System.Drawing.Point(21, 98);
            this.txtCodigoDoCliente.Name = "txtCodigoDoCliente";
            this.txtCodigoDoCliente.Size = new System.Drawing.Size(398, 20);
            this.txtCodigoDoCliente.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(21, 154);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(131, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marca";
            // 
            // lblTipodeAparelho
            // 
            this.lblTipodeAparelho.AutoSize = true;
            this.lblTipodeAparelho.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeAparelho.ForeColor = System.Drawing.Color.White;
            this.lblTipodeAparelho.Location = new System.Drawing.Point(210, 128);
            this.lblTipodeAparelho.Name = "lblTipodeAparelho";
            this.lblTipodeAparelho.Size = new System.Drawing.Size(112, 17);
            this.lblTipodeAparelho.TabIndex = 5;
            this.lblTipodeAparelho.Text = "Tipo de Aparelho";
            // 
            // cbTipodeAparelho
            // 
            this.cbTipodeAparelho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbTipodeAparelho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipodeAparelho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipodeAparelho.FormattingEnabled = true;
            this.cbTipodeAparelho.Items.AddRange(new object[] {
            "Console",
            "Gabinete",
            "Notebook",
            "Computador",
            "Controles"});
            this.cbTipodeAparelho.Location = new System.Drawing.Point(213, 148);
            this.cbTipodeAparelho.Name = "cbTipodeAparelho";
            this.cbTipodeAparelho.Size = new System.Drawing.Size(191, 29);
            this.cbTipodeAparelho.TabIndex = 27;
            this.cbTipodeAparelho.Text = "Selecione";
            // 
            // lblNumerodeSerie
            // 
            this.lblNumerodeSerie.AutoSize = true;
            this.lblNumerodeSerie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumerodeSerie.ForeColor = System.Drawing.Color.White;
            this.lblNumerodeSerie.Location = new System.Drawing.Point(18, 194);
            this.lblNumerodeSerie.Name = "lblNumerodeSerie";
            this.lblNumerodeSerie.Size = new System.Drawing.Size(110, 17);
            this.lblNumerodeSerie.TabIndex = 28;
            this.lblNumerodeSerie.Text = "Número de Série";
            // 
            // txtNumerodeSerie
            // 
            this.txtNumerodeSerie.Location = new System.Drawing.Point(21, 214);
            this.txtNumerodeSerie.Name = "txtNumerodeSerie";
            this.txtNumerodeSerie.Size = new System.Drawing.Size(398, 20);
            this.txtNumerodeSerie.TabIndex = 29;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelo.ForeColor = System.Drawing.Color.White;
            this.lblModelo.Location = new System.Drawing.Point(18, 250);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(54, 17);
            this.lblModelo.TabIndex = 30;
            this.lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(21, 270);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(398, 20);
            this.txtModelo.TabIndex = 31;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbEstado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Recebido",
            "Em análise",
            "Em reparo",
            "Pronto",
            "Entregue"});
            this.cbEstado.Location = new System.Drawing.Point(21, 330);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(191, 29);
            this.cbEstado.TabIndex = 32;
            this.cbEstado.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Estado";
            // 
            // lblAnexarFoto
            // 
            this.lblAnexarFoto.AutoSize = true;
            this.lblAnexarFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexarFoto.ForeColor = System.Drawing.Color.White;
            this.lblAnexarFoto.Location = new System.Drawing.Point(306, 336);
            this.lblAnexarFoto.Name = "lblAnexarFoto";
            this.lblAnexarFoto.Size = new System.Drawing.Size(83, 17);
            this.lblAnexarFoto.TabIndex = 34;
            this.lblAnexarFoto.Text = "Anexar Foto";
            // 
            // btnAnexarFoto
            // 
            this.btnAnexarFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAnexarFoto.FlatAppearance.BorderSize = 0;
            this.btnAnexarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnexarFoto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnexarFoto.Image = ((System.Drawing.Image)(resources.GetObject("btnAnexarFoto.Image")));
            this.btnAnexarFoto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAnexarFoto.Location = new System.Drawing.Point(327, 364);
            this.btnAnexarFoto.Name = "btnAnexarFoto";
            this.btnAnexarFoto.Size = new System.Drawing.Size(39, 38);
            this.btnAnexarFoto.TabIndex = 35;
            this.btnAnexarFoto.UseVisualStyleBackColor = true;
       
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data Entrada";
            // 
            // lblDescriçãoDoProblema
            // 
            this.lblDescriçãoDoProblema.AutoSize = true;
            this.lblDescriçãoDoProblema.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescriçãoDoProblema.ForeColor = System.Drawing.Color.White;
            this.lblDescriçãoDoProblema.Location = new System.Drawing.Point(18, 456);
            this.lblDescriçãoDoProblema.Name = "lblDescriçãoDoProblema";
            this.lblDescriçãoDoProblema.Size = new System.Drawing.Size(147, 17);
            this.lblDescriçãoDoProblema.TabIndex = 38;
            this.lblDescriçãoDoProblema.Text = "Descrição do Problema";
            // 
            // txtDescriçãoDoProblema
            // 
            this.txtDescriçãoDoProblema.Location = new System.Drawing.Point(21, 476);
            this.txtDescriçãoDoProblema.Name = "txtDescriçãoDoProblema";
            this.txtDescriçãoDoProblema.Size = new System.Drawing.Size(398, 20);
            this.txtDescriçãoDoProblema.TabIndex = 39;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(79, 514);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(293, 28);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 364);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 38);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // dtpDataEntrada
            // 
            this.dtpDataEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDataEntrada.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.dtpDataEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEntrada.Location = new System.Drawing.Point(21, 405);
            this.dtpDataEntrada.Name = "dtpDataEntrada";
            this.dtpDataEntrada.Size = new System.Drawing.Size(214, 25);
            this.dtpDataEntrada.TabIndex = 42;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(12, 21);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 43;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // FormNovoAparelho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(456, 567);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtpDataEntrada);
            this.Controls.Add(this.btnAnexarFoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtDescriçãoDoProblema);
            this.Controls.Add(this.lblDescriçãoDoProblema);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblAnexarFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txtNumerodeSerie);
            this.Controls.Add(this.lblNumerodeSerie);
            this.Controls.Add(this.cbTipodeAparelho);
            this.Controls.Add(this.lblTipodeAparelho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtCodigoDoCliente);
            this.Controls.Add(this.lblCodigoDoCliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNovoAparelho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Aparelho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodigoDoCliente;
        private System.Windows.Forms.TextBox txtCodigoDoCliente;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTipodeAparelho;
        private System.Windows.Forms.ComboBox cbTipodeAparelho;
        private System.Windows.Forms.Label lblNumerodeSerie;
        private System.Windows.Forms.TextBox txtNumerodeSerie;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAnexarFoto;
        private System.Windows.Forms.Button btnAnexarFoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDescriçãoDoProblema;
        private System.Windows.Forms.TextBox txtDescriçãoDoProblema;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpDataEntrada;
        private System.Windows.Forms.Button btnFechar;
    }
}