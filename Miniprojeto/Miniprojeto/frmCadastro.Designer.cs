namespace Miniprojeto
{
    partial class frmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbID = new System.Windows.Forms.GroupBox();
            this.bto = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbCadastro = new System.Windows.Forms.GroupBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.lblObs = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mskcpf = new System.Windows.Forms.MaskedTextBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbBotoes = new System.Windows.Forms.GroupBox();
            this.btoCadastrar = new System.Windows.Forms.Button();
            this.btoAlterar = new System.Windows.Forms.Button();
            this.btoLimpar = new System.Windows.Forms.Button();
            this.btoExcluir = new System.Windows.Forms.Button();
            this.btoSair = new System.Windows.Forms.Button();
            this.gpbID.SuspendLayout();
            this.gpbCadastro.SuspendLayout();
            this.gpbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbID
            // 
            this.gpbID.Controls.Add(this.bto);
            this.gpbID.Controls.Add(this.txtCodigo);
            this.gpbID.Controls.Add(this.lblCodigo);
            this.gpbID.Location = new System.Drawing.Point(12, 12);
            this.gpbID.Name = "gpbID";
            this.gpbID.Size = new System.Drawing.Size(458, 70);
            this.gpbID.TabIndex = 0;
            this.gpbID.TabStop = false;
            // 
            // bto
            // 
            this.bto.BackColor = System.Drawing.SystemColors.Window;
            this.bto.Location = new System.Drawing.Point(175, 37);
            this.bto.Name = "bto";
            this.bto.Size = new System.Drawing.Size(27, 23);
            this.bto.TabIndex = 2;
            this.bto.Text = "...";
            this.bto.UseVisualStyleBackColor = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(6, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(163, 23);
            this.txtCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(6, 19);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // gpbCadastro
            // 
            this.gpbCadastro.Controls.Add(this.txtObs);
            this.gpbCadastro.Controls.Add(this.lblObs);
            this.gpbCadastro.Controls.Add(this.cbxStatus);
            this.gpbCadastro.Controls.Add(this.lblStatus);
            this.gpbCadastro.Controls.Add(this.mskcpf);
            this.gpbCadastro.Controls.Add(this.lblcpf);
            this.gpbCadastro.Controls.Add(this.txtSenha);
            this.gpbCadastro.Controls.Add(this.lblSenha);
            this.gpbCadastro.Controls.Add(this.txtLogin);
            this.gpbCadastro.Controls.Add(this.lblLogin);
            this.gpbCadastro.Controls.Add(this.txtNome);
            this.gpbCadastro.Controls.Add(this.lblNome);
            this.gpbCadastro.Location = new System.Drawing.Point(12, 88);
            this.gpbCadastro.Name = "gpbCadastro";
            this.gpbCadastro.Size = new System.Drawing.Size(458, 269);
            this.gpbCadastro.TabIndex = 1;
            this.gpbCadastro.TabStop = false;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(6, 125);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(446, 138);
            this.txtObs.TabIndex = 11;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Location = new System.Drawing.Point(6, 107);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(28, 15);
            this.lblObs.TabIndex = 10;
            this.lblObs.Text = "Obs";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Items.AddRange(new object[] {
            "ATIVADO",
            "DESATIVADO"});
            this.cbxStatus.Location = new System.Drawing.Point(328, 81);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(124, 23);
            this.cbxStatus.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(328, 63);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 15);
            this.lblStatus.TabIndex = 8;
            this.lblStatus.Text = "Status";
            // 
            // mskcpf
            // 
            this.mskcpf.Location = new System.Drawing.Point(222, 81);
            this.mskcpf.Mask = "000,000,000-00";
            this.mskcpf.Name = "mskcpf";
            this.mskcpf.Size = new System.Drawing.Size(100, 23);
            this.mskcpf.TabIndex = 7;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(222, 63);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(28, 15);
            this.lblcpf.TabIndex = 6;
            this.lblcpf.Text = "CPF";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(116, 81);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 23);
            this.txtSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(116, 63);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(6, 81);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(104, 23);
            this.txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(6, 63);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(37, 15);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(446, 23);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // gpbBotoes
            // 
            this.gpbBotoes.Controls.Add(this.btoCadastrar);
            this.gpbBotoes.Controls.Add(this.btoAlterar);
            this.gpbBotoes.Controls.Add(this.btoLimpar);
            this.gpbBotoes.Controls.Add(this.btoExcluir);
            this.gpbBotoes.Controls.Add(this.btoSair);
            this.gpbBotoes.Location = new System.Drawing.Point(12, 363);
            this.gpbBotoes.Name = "gpbBotoes";
            this.gpbBotoes.Size = new System.Drawing.Size(458, 55);
            this.gpbBotoes.TabIndex = 2;
            this.gpbBotoes.TabStop = false;
            // 
            // btoCadastrar
            // 
            this.btoCadastrar.Location = new System.Drawing.Point(50, 22);
            this.btoCadastrar.Name = "btoCadastrar";
            this.btoCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btoCadastrar.TabIndex = 4;
            this.btoCadastrar.Text = "Cadastrar";
            this.btoCadastrar.UseVisualStyleBackColor = true;
            this.btoCadastrar.Click += new System.EventHandler(this.btoCadastrar_Click);
            // 
            // btoAlterar
            // 
            this.btoAlterar.Location = new System.Drawing.Point(131, 22);
            this.btoAlterar.Name = "btoAlterar";
            this.btoAlterar.Size = new System.Drawing.Size(75, 23);
            this.btoAlterar.TabIndex = 3;
            this.btoAlterar.Text = "Alterar";
            this.btoAlterar.UseVisualStyleBackColor = true;
            // 
            // btoLimpar
            // 
            this.btoLimpar.Location = new System.Drawing.Point(212, 22);
            this.btoLimpar.Name = "btoLimpar";
            this.btoLimpar.Size = new System.Drawing.Size(75, 23);
            this.btoLimpar.TabIndex = 2;
            this.btoLimpar.Text = "Limpar";
            this.btoLimpar.UseVisualStyleBackColor = true;
            this.btoLimpar.Click += new System.EventHandler(this.btoLimpar_Click);
            // 
            // btoExcluir
            // 
            this.btoExcluir.Location = new System.Drawing.Point(293, 22);
            this.btoExcluir.Name = "btoExcluir";
            this.btoExcluir.Size = new System.Drawing.Size(75, 23);
            this.btoExcluir.TabIndex = 1;
            this.btoExcluir.Text = "Excluir";
            this.btoExcluir.UseVisualStyleBackColor = true;
            // 
            // btoSair
            // 
            this.btoSair.Location = new System.Drawing.Point(374, 22);
            this.btoSair.Name = "btoSair";
            this.btoSair.Size = new System.Drawing.Size(75, 23);
            this.btoSair.TabIndex = 0;
            this.btoSair.Text = "Sair";
            this.btoSair.UseVisualStyleBackColor = true;
            this.btoSair.Click += new System.EventHandler(this.btoSair_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 437);
            this.Controls.Add(this.gpbBotoes);
            this.Controls.Add(this.gpbCadastro);
            this.Controls.Add(this.gpbID);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbID.ResumeLayout(false);
            this.gpbID.PerformLayout();
            this.gpbCadastro.ResumeLayout(false);
            this.gpbCadastro.PerformLayout();
            this.gpbBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbID;
        private Button bto;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private GroupBox gpbCadastro;
        private ComboBox cbxStatus;
        private Label lblStatus;
        private MaskedTextBox mskcpf;
        private Label lblcpf;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtLogin;
        private Label lblLogin;
        private TextBox txtNome;
        private Label lblNome;
        private GroupBox gpbBotoes;
        private Label lblObs;
        private Button btoCadastrar;
        private Button btoAlterar;
        private Button btoLimpar;
        private Button btoExcluir;
        private Button btoSair;
        private TextBox txtObs;
    }
}