namespace Miniprojeto
{
    partial class frmProduto
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btoPesquisa = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDatCadastro = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblCodCateg = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCodCateg);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.lblDatCadastro);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 294);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btoPesquisa);
            this.groupBox3.Controls.Add(this.txtCod);
            this.groupBox3.Controls.Add(this.lblCod);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 60);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(6, 13);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(29, 15);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Cód";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(6, 31);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(158, 23);
            this.txtCod.TabIndex = 1;
            // 
            // btoPesquisa
            // 
            this.btoPesquisa.Location = new System.Drawing.Point(170, 30);
            this.btoPesquisa.Name = "btoPesquisa";
            this.btoPesquisa.Size = new System.Drawing.Size(27, 23);
            this.btoPesquisa.TabIndex = 2;
            this.btoPesquisa.Text = "...";
            this.btoPesquisa.UseVisualStyleBackColor = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(128, 20);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(40, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(502, 23);
            this.textBox1.TabIndex = 1;
            // 
            // lblDatCadastro
            // 
            this.lblDatCadastro.AutoSize = true;
            this.lblDatCadastro.Location = new System.Drawing.Point(636, 20);
            this.lblDatCadastro.Name = "lblDatCadastro";
            this.lblDatCadastro.Size = new System.Drawing.Size(81, 15);
            this.lblDatCadastro.TabIndex = 2;
            this.lblDatCadastro.Text = "Data Cadastro";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(636, 38);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(111, 23);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // lblCodCateg
            // 
            this.lblCodCateg.AutoSize = true;
            this.lblCodCateg.Location = new System.Drawing.Point(6, 19);
            this.lblCodCateg.Name = "lblCodCateg";
            this.lblCodCateg.Size = new System.Drawing.Size(60, 15);
            this.lblCodCateg.TabIndex = 4;
            this.lblCodCateg.Text = "CodCateg";
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label lblCodCateg;
        private MaskedTextBox maskedTextBox1;
        private Label lblDatCadastro;
        private TextBox textBox1;
        private Label lblNome;
        private Button btoPesquisa;
        private TextBox txtCod;
        private Label lblCod;
    }
}