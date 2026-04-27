namespace projeto_integrador
{
    partial class FormCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastrarUsuario));
            this.panelCadUser = new System.Windows.Forms.Panel();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.lblTituloResposta = new System.Windows.Forms.Label();
            this.lblTituloPerguntaSecreta = new System.Windows.Forms.Label();
            this.txtRespostaPerguntaSecreta = new System.Windows.Forms.TextBox();
            this.cbPerguntaSecreta = new System.Windows.Forms.ComboBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbTipoAcesso = new System.Windows.Forms.ComboBox();
            this.lblTipodeacesso = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCodigousuario = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtCodigoUser = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNomecompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblCadastrausuario = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelCadUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCadUser
            // 
            this.panelCadUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCadUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(98)))), ((int)(((byte)(131)))));
            this.panelCadUser.Controls.Add(this.cbCargo);
            this.panelCadUser.Controls.Add(this.lblTituloResposta);
            this.panelCadUser.Controls.Add(this.lblTituloPerguntaSecreta);
            this.panelCadUser.Controls.Add(this.txtRespostaPerguntaSecreta);
            this.panelCadUser.Controls.Add(this.cbPerguntaSecreta);
            this.panelCadUser.Controls.Add(this.txtTelefone);
            this.panelCadUser.Controls.Add(this.btnConfirmar);
            this.panelCadUser.Controls.Add(this.cbTipoAcesso);
            this.panelCadUser.Controls.Add(this.lblTipodeacesso);
            this.panelCadUser.Controls.Add(this.lblConfirmarSenha);
            this.panelCadUser.Controls.Add(this.lblSenha);
            this.panelCadUser.Controls.Add(this.lblCodigousuario);
            this.panelCadUser.Controls.Add(this.lblTelefone);
            this.panelCadUser.Controls.Add(this.txtConfirmarSenha);
            this.panelCadUser.Controls.Add(this.txtSenha);
            this.panelCadUser.Controls.Add(this.txtCodigoUser);
            this.panelCadUser.Controls.Add(this.lblCargo);
            this.panelCadUser.Controls.Add(this.lblNomecompleto);
            this.panelCadUser.Controls.Add(this.txtNomeCompleto);
            this.panelCadUser.Controls.Add(this.lblCadastrausuario);
            this.panelCadUser.Location = new System.Drawing.Point(433, 42);
            this.panelCadUser.Name = "panelCadUser";
            this.panelCadUser.Size = new System.Drawing.Size(550, 672);
            this.panelCadUser.TabIndex = 0;
            // 
            // cbCargo
            // 
            this.cbCargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbCargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Técnico",
            "Atendente",
            "Estoquista",
            "Proprietário"});
            this.cbCargo.Location = new System.Drawing.Point(297, 199);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(174, 33);
            this.cbCargo.TabIndex = 25;
            this.cbCargo.Text = "Selecione";
            // 
            // lblTituloResposta
            // 
            this.lblTituloResposta.AutoSize = true;
            this.lblTituloResposta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloResposta.ForeColor = System.Drawing.Color.White;
            this.lblTituloResposta.Location = new System.Drawing.Point(81, 517);
            this.lblTituloResposta.Name = "lblTituloResposta";
            this.lblTituloResposta.Size = new System.Drawing.Size(86, 25);
            this.lblTituloResposta.TabIndex = 24;
            this.lblTituloResposta.Text = "Resposta";
            // 
            // lblTituloPerguntaSecreta
            // 
            this.lblTituloPerguntaSecreta.AutoSize = true;
            this.lblTituloPerguntaSecreta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPerguntaSecreta.ForeColor = System.Drawing.Color.White;
            this.lblTituloPerguntaSecreta.Location = new System.Drawing.Point(78, 448);
            this.lblTituloPerguntaSecreta.Name = "lblTituloPerguntaSecreta";
            this.lblTituloPerguntaSecreta.Size = new System.Drawing.Size(153, 25);
            this.lblTituloPerguntaSecreta.TabIndex = 23;
            this.lblTituloPerguntaSecreta.Text = "Pergunta secreta";
            // 
            // txtRespostaPerguntaSecreta
            // 
            this.txtRespostaPerguntaSecreta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtRespostaPerguntaSecreta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRespostaPerguntaSecreta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespostaPerguntaSecreta.Location = new System.Drawing.Point(81, 545);
            this.txtRespostaPerguntaSecreta.Name = "txtRespostaPerguntaSecreta";
            this.txtRespostaPerguntaSecreta.Size = new System.Drawing.Size(390, 32);
            this.txtRespostaPerguntaSecreta.TabIndex = 22;
            // 
            // cbPerguntaSecreta
            // 
            this.cbPerguntaSecreta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbPerguntaSecreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPerguntaSecreta.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerguntaSecreta.FormattingEnabled = true;
            this.cbPerguntaSecreta.Items.AddRange(new object[] {
            "Qual o nome do seu primeiro pet?",
            "Qual sua comida favorita?",
            "Nome da sua primeira escola?"});
            this.cbPerguntaSecreta.Location = new System.Drawing.Point(81, 476);
            this.cbPerguntaSecreta.Name = "cbPerguntaSecreta";
            this.cbPerguntaSecreta.Size = new System.Drawing.Size(390, 33);
            this.cbPerguntaSecreta.TabIndex = 21;
            this.cbPerguntaSecreta.Text = "Selecione";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(297, 272);
            this.txtTelefone.Mask = "(##) #####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(174, 32);
            this.txtTelefone.TabIndex = 20;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(150, 605);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(252, 51);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbTipoAcesso
            // 
            this.cbTipoAcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.cbTipoAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTipoAcesso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoAcesso.FormattingEnabled = true;
            this.cbTipoAcesso.Items.AddRange(new object[] {
            "basico",
            "tecnico",
            "admin"});
            this.cbTipoAcesso.Location = new System.Drawing.Point(83, 199);
            this.cbTipoAcesso.Name = "cbTipoAcesso";
            this.cbTipoAcesso.Size = new System.Drawing.Size(174, 33);
            this.cbTipoAcesso.TabIndex = 18;
            this.cbTipoAcesso.Text = "Selecione";
            // 
            // lblTipodeacesso
            // 
            this.lblTipodeacesso.AutoSize = true;
            this.lblTipodeacesso.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipodeacesso.ForeColor = System.Drawing.Color.White;
            this.lblTipodeacesso.Location = new System.Drawing.Point(292, 171);
            this.lblTipodeacesso.Name = "lblTipodeacesso";
            this.lblTipodeacesso.Size = new System.Drawing.Size(138, 25);
            this.lblTipodeacesso.TabIndex = 17;
            this.lblTipodeacesso.Text = "Tipo de Acesso";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(78, 377);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(154, 25);
            this.lblConfirmarSenha.TabIndex = 14;
            this.lblConfirmarSenha.Text = "Confirmar Senha";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.White;
            this.lblSenha.Location = new System.Drawing.Point(78, 312);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(64, 25);
            this.lblSenha.TabIndex = 13;
            this.lblSenha.Text = "Senha";
            // 
            // lblCodigousuario
            // 
            this.lblCodigousuario.AutoSize = true;
            this.lblCodigousuario.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigousuario.ForeColor = System.Drawing.Color.White;
            this.lblCodigousuario.Location = new System.Drawing.Point(78, 243);
            this.lblCodigousuario.Name = "lblCodigousuario";
            this.lblCodigousuario.Size = new System.Drawing.Size(143, 25);
            this.lblCodigousuario.TabIndex = 12;
            this.lblCodigousuario.Text = "Código Usuário";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.Color.White;
            this.lblTelefone.Location = new System.Drawing.Point(292, 244);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(83, 25);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtConfirmarSenha
            // 
            this.txtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtConfirmarSenha.Location = new System.Drawing.Point(81, 405);
            this.txtConfirmarSenha.Name = "txtConfirmarSenha";
            this.txtConfirmarSenha.Size = new System.Drawing.Size(390, 28);
            this.txtConfirmarSenha.TabIndex = 10;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtSenha.Location = new System.Drawing.Point(81, 340);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(390, 28);
            this.txtSenha.TabIndex = 9;
            // 
            // txtCodigoUser
            // 
            this.txtCodigoUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtCodigoUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoUser.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtCodigoUser.Location = new System.Drawing.Point(81, 272);
            this.txtCodigoUser.Name = "txtCodigoUser";
            this.txtCodigoUser.Size = new System.Drawing.Size(176, 32);
            this.txtCodigoUser.TabIndex = 8;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(76, 171);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(63, 25);
            this.lblCargo.TabIndex = 6;
            this.lblCargo.Text = "Cargo";
            // 
            // lblNomecompleto
            // 
            this.lblNomecompleto.AutoSize = true;
            this.lblNomecompleto.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomecompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomecompleto.Location = new System.Drawing.Point(76, 102);
            this.lblNomecompleto.Name = "lblNomecompleto";
            this.lblNomecompleto.Size = new System.Drawing.Size(150, 25);
            this.lblNomecompleto.TabIndex = 4;
            this.lblNomecompleto.Text = "Nome Completo";
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.txtNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(134)))));
            this.txtNomeCompleto.Location = new System.Drawing.Point(81, 130);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(390, 28);
            this.txtNomeCompleto.TabIndex = 3;
            // 
            // lblCadastrausuario
            // 
            this.lblCadastrausuario.AutoSize = true;
            this.lblCadastrausuario.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrausuario.ForeColor = System.Drawing.Color.White;
            this.lblCadastrausuario.Location = new System.Drawing.Point(116, 35);
            this.lblCadastrausuario.Name = "lblCadastrausuario";
            this.lblCadastrausuario.Size = new System.Drawing.Size(320, 50);
            this.lblCadastrausuario.TabIndex = 0;
            this.lblCadastrausuario.Text = "Cadastrar Usuário";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(217)))), ((int)(((byte)(95)))));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(22, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVoltar.Size = new System.Drawing.Size(158, 51);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "    Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1356, 750);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panelCadUser);
            this.Name = "FormCadastrarUsuario";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCadastrarUsuario_Load);
            this.panelCadUser.ResumeLayout(false);
            this.panelCadUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCadUser;
        private System.Windows.Forms.Label lblCadastrausuario;
        private System.Windows.Forms.Label lblNomecompleto;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCodigousuario;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.ComboBox cbTipoAcesso;
        private System.Windows.Forms.Label lblTipodeacesso;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtConfirmarSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtCodigoUser;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label lblTituloPerguntaSecreta;
        private System.Windows.Forms.TextBox txtRespostaPerguntaSecreta;
        private System.Windows.Forms.ComboBox cbPerguntaSecreta;
        private System.Windows.Forms.Label lblTituloResposta;
        private System.Windows.Forms.ComboBox cbCargo;
    }
}