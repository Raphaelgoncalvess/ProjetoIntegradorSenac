namespace ProjetoIntegradorSenac
{
    partial class TelaLogin
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
            BtnLogin = new FontAwesome.Sharp.IconButton();
            BtnCadastro = new FontAwesome.Sharp.IconButton();
            PainelLateralLogin = new Panel();
            label7 = new Label();
            textBoxLoginEmail = new TextBox();
            labelEmail = new Label();
            labelSenha = new Label();
            textBoxSenhaLogin = new TextBox();
            BtnEfetuarLogin = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            BtnMostrarSenha = new FontAwesome.Sharp.IconButton();
            PainelLateralLogin.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.Anchor = AnchorStyles.None;
            BtnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLogin.BackColor = Color.Gainsboro;
            BtnLogin.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.FromArgb(18, 13, 66);
            BtnLogin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            BtnLogin.IconColor = Color.FromArgb(18, 13, 66);
            BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLogin.IconSize = 64;
            BtnLogin.Location = new Point(0, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(200, 225);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.TextAlign = ContentAlignment.BottomCenter;
            BtnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCadastro
            // 
            BtnCadastro.Anchor = AnchorStyles.None;
            BtnCadastro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCadastro.BackColor = Color.Gainsboro;
            BtnCadastro.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.ForeColor = Color.FromArgb(18, 13, 66);
            BtnCadastro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BtnCadastro.IconColor = Color.FromArgb(18, 13, 66);
            BtnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastro.IconSize = 80;
            BtnCadastro.Location = new Point(0, 225);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(200, 225);
            BtnCadastro.TabIndex = 7;
            BtnCadastro.Text = "Cadastre-se";
            BtnCadastro.TextAlign = ContentAlignment.BottomCenter;
            BtnCadastro.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // PainelLateralLogin
            // 
            PainelLateralLogin.Controls.Add(BtnLogin);
            PainelLateralLogin.Controls.Add(BtnCadastro);
            PainelLateralLogin.Dock = DockStyle.Left;
            PainelLateralLogin.Location = new Point(0, 0);
            PainelLateralLogin.Name = "PainelLateralLogin";
            PainelLateralLogin.Size = new Size(200, 450);
            PainelLateralLogin.TabIndex = 8;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(423, 30);
            label7.Name = "label7";
            label7.Size = new Size(155, 65);
            label7.TabIndex = 11;
            label7.Text = "Login";
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Anchor = AnchorStyles.None;
            textBoxLoginEmail.BackColor = Color.Gainsboro;
            textBoxLoginEmail.Location = new Point(494, 154);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(150, 23);
            textBoxLoginEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.Gainsboro;
            labelEmail.Location = new Point(396, 154);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(100, 23);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            labelSenha.Anchor = AnchorStyles.None;
            labelSenha.Font = new Font("Malgun Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.ForeColor = Color.Gainsboro;
            labelSenha.Location = new Point(396, 225);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(100, 25);
            labelSenha.TabIndex = 15;
            labelSenha.Text = "Senha";
            // 
            // textBoxSenhaLogin
            // 
            textBoxSenhaLogin.Anchor = AnchorStyles.None;
            textBoxSenhaLogin.BackColor = Color.Gainsboro;
            textBoxSenhaLogin.Location = new Point(494, 225);
            textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            textBoxSenhaLogin.Size = new Size(150, 23);
            textBoxSenhaLogin.TabIndex = 16;
            textBoxSenhaLogin.UseSystemPasswordChar = true;
            // 
            // BtnEfetuarLogin
            // 
            BtnEfetuarLogin.Anchor = AnchorStyles.None;
            BtnEfetuarLogin.FlatAppearance.BorderSize = 3;
            BtnEfetuarLogin.FlatStyle = FlatStyle.Flat;
            BtnEfetuarLogin.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEfetuarLogin.ForeColor = Color.Gainsboro;
            BtnEfetuarLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            BtnEfetuarLogin.IconColor = Color.Gainsboro;
            BtnEfetuarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEfetuarLogin.IconSize = 36;
            BtnEfetuarLogin.Location = new Point(402, 298);
            BtnEfetuarLogin.Name = "BtnEfetuarLogin";
            BtnEfetuarLogin.Size = new Size(200, 50);
            BtnEfetuarLogin.TabIndex = 17;
            BtnEfetuarLogin.Text = "Logar";
            BtnEfetuarLogin.TextAlign = ContentAlignment.MiddleRight;
            BtnEfetuarLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnEfetuarLogin.UseVisualStyleBackColor = true;
            BtnEfetuarLogin.Click += BtnEfetuarLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Malgun Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.Gainsboro;
            linkLabel1.Location = new Point(416, 376);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(171, 21);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "esqueceu sua senha ?";
            // 
            // BtnMostrarSenha
            // 
            BtnMostrarSenha.Anchor = AnchorStyles.None;
            BtnMostrarSenha.AutoSize = true;
            BtnMostrarSenha.FlatAppearance.BorderSize = 0;
            BtnMostrarSenha.FlatStyle = FlatStyle.Flat;
            BtnMostrarSenha.ForeColor = Color.Gainsboro;
            BtnMostrarSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            BtnMostrarSenha.IconColor = Color.Gainsboro;
            BtnMostrarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMostrarSenha.IconSize = 24;
            BtnMostrarSenha.Location = new Point(650, 223);
            BtnMostrarSenha.Name = "BtnMostrarSenha";
            BtnMostrarSenha.Size = new Size(34, 34);
            BtnMostrarSenha.TabIndex = 19;
            BtnMostrarSenha.UseVisualStyleBackColor = true;
            BtnMostrarSenha.Click += BtnMostrarSenha_Click;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 13, 66);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnMostrarSenha);
            Controls.Add(linkLabel1);
            Controls.Add(BtnEfetuarLogin);
            Controls.Add(textBoxSenhaLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(textBoxLoginEmail);
            Controls.Add(label7);
            Controls.Add(PainelLateralLogin);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PainelLateralLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnLogin;
        private FontAwesome.Sharp.IconButton BtnCadastro;
        private Panel PainelLateralLogin;
        private Label label7;
        private TextBox textBoxLoginEmail;
        private Label labelEmail;
        private Label labelSenha;
        private TextBox textBoxSenhaLogin;
        private FontAwesome.Sharp.IconButton BtnEfetuarLogin;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton BtnMostrarSenha;
    }
}