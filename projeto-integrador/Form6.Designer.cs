namespace projeto_integrador
{
    partial class Form6
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Cliente";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(63, 132);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(292, 20);
            this.txtNomeCompleto.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(63, 195);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(292, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(139, 304);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(147, 29);
            this.btnCadastrarCliente.TabIndex = 5;
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.Location = new System.Drawing.Point(60, 113);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(109, 17);
            this.lblNomeCompleto.TabIndex = 6;
            this.lblNomeCompleto.Text = "Nome Completo";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(60, 175);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 17);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "ID";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(225, 175);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(61, 17);
            this.lblTelefone.TabIndex = 8;
            this.lblTelefone.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(228, 195);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(127, 20);
            this.txtTelefone.TabIndex = 10;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(420, 456);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
    }
}