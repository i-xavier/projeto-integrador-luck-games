namespace projeto_integrador
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlterasenha = new System.Windows.Forms.LinkLabel();
            this.btnCriarconta = new System.Windows.Forms.Button();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.lblTextoSenha = new System.Windows.Forms.Label();
            this.lblTextoCodigo = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCodigoUser = new System.Windows.Forms.TextBox();
            this.lblTextoBoasVindas = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAlterasenha);
            this.panel1.Controls.Add(this.btnCriarconta);
            this.panel1.Controls.Add(this.lblCopyRight);
            this.panel1.Controls.Add(this.lblTextoSenha);
            this.panel1.Controls.Add(this.lblTextoCodigo);
            this.panel1.Controls.Add(this.btnEntrar);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.txtCodigoUser);
            this.panel1.Controls.Add(this.lblTextoBoasVindas);
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(347, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 644);
            this.panel1.TabIndex = 0;
            // 
            // lblAlterasenha
            // 
            this.lblAlterasenha.AutoSize = true;
            this.lblAlterasenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlterasenha.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.lblAlterasenha.Location = new System.Drawing.Point(294, 427);
            this.lblAlterasenha.Name = "lblAlterasenha";
            this.lblAlterasenha.Size = new System.Drawing.Size(175, 20);
            this.lblAlterasenha.TabIndex = 9;
            this.lblAlterasenha.TabStop = true;
            this.lblAlterasenha.Text = "Esqueceu a Senha?";
            // 
            // btnCriarconta
            // 
            this.btnCriarconta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnCriarconta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCriarconta.FlatAppearance.BorderSize = 0;
            this.btnCriarconta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriarconta.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarconta.ForeColor = System.Drawing.Color.White;
            this.btnCriarconta.Location = new System.Drawing.Point(84, 526);
            this.btnCriarconta.Name = "btnCriarconta";
            this.btnCriarconta.Size = new System.Drawing.Size(390, 44);
            this.btnCriarconta.TabIndex = 8;
            this.btnCriarconta.Text = "Criar conta ";
            this.btnCriarconta.UseVisualStyleBackColor = false;
            this.btnCriarconta.Click += new System.EventHandler(this.CriarConta);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.lblCopyRight.Location = new System.Drawing.Point(95, 608);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(368, 20);
            this.lblCopyRight.TabIndex = 7;
            this.lblCopyRight.Text = "© 2026 Luck Games. Todos os direitos reservados.";
            // 
            // lblTextoSenha
            // 
            this.lblTextoSenha.AutoSize = true;
            this.lblTextoSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.lblTextoSenha.Location = new System.Drawing.Point(90, 348);
            this.lblTextoSenha.Name = "lblTextoSenha";
            this.lblTextoSenha.Size = new System.Drawing.Size(70, 30);
            this.lblTextoSenha.TabIndex = 6;
            this.lblTextoSenha.Text = "Senha";
            // 
            // lblTextoCodigo
            // 
            this.lblTextoCodigo.AutoSize = true;
            this.lblTextoCodigo.BackColor = System.Drawing.Color.White;
            this.lblTextoCodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.lblTextoCodigo.Location = new System.Drawing.Point(90, 265);
            this.lblTextoCodigo.Name = "lblTextoCodigo";
            this.lblTextoCodigo.Size = new System.Drawing.Size(83, 30);
            this.lblTextoCodigo.TabIndex = 5;
            this.lblTextoCodigo.Text = "Código";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrar.FlatAppearance.BorderSize = 0;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.White;
            this.btnEntrar.Location = new System.Drawing.Point(84, 477);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(390, 44);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.Logar);
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtSenha.Location = new System.Drawing.Point(84, 378);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(390, 38);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtCodigoUser
            // 
            this.txtCodigoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtCodigoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtCodigoUser.Location = new System.Drawing.Point(84, 297);
            this.txtCodigoUser.Name = "txtCodigoUser";
            this.txtCodigoUser.Size = new System.Drawing.Size(390, 38);
            this.txtCodigoUser.TabIndex = 2;
            // 
            // lblTextoBoasVindas
            // 
            this.lblTextoBoasVindas.AutoSize = true;
            this.lblTextoBoasVindas.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextoBoasVindas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.lblTextoBoasVindas.Location = new System.Drawing.Point(186, 197);
            this.lblTextoBoasVindas.Name = "lblTextoBoasVindas";
            this.lblTextoBoasVindas.Size = new System.Drawing.Size(200, 45);
            this.lblTextoBoasVindas.TabIndex = 1;
            this.lblTextoBoasVindas.Text = "Boas-Vindas";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(102, -6);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(348, 232);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1191, 720);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.MinimumSize = new System.Drawing.Size(511, 595);
            this.Name = "frmLogin";
            this.Text = "Login -- Luck Games";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmLogin_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTextoBoasVindas;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCodigoUser;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblTextoSenha;
        private System.Windows.Forms.Label lblTextoCodigo;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.Button btnCriarconta;
        private System.Windows.Forms.LinkLabel lblAlterasenha;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

