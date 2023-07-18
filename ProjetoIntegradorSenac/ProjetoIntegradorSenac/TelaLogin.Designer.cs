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
            PainelLateral = new Panel();
            PainelLateralCadastro = new Panel();
            PainelLateralLogin = new Panel();
            LabelLogin = new Label();
            textBoxLoginEmail = new TextBox();
            labelEmail = new Label();
            labelSenha = new Label();
            textBoxSenhaLogin = new TextBox();
            BtnEfetuarLogin = new FontAwesome.Sharp.IconButton();
            linkResetarSenha = new LinkLabel();
            BtnMostrarSenha = new FontAwesome.Sharp.IconButton();
            PainelFormFilho = new Panel();
            PainelLateral.SuspendLayout();
            PainelLateralCadastro.SuspendLayout();
            PainelLateralLogin.SuspendLayout();
            SuspendLayout();
            // 
            // BtnLogin
            // 
            BtnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLogin.BackColor = Color.FromArgb(242, 242, 242);
            BtnLogin.Dock = DockStyle.Top;
            BtnLogin.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Candara", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.FromArgb(6, 7, 33);
            BtnLogin.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            BtnLogin.IconColor = Color.FromArgb(6, 7, 33);
            BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLogin.IconSize = 64;
            BtnLogin.Location = new Point(0, 0);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(188, 225);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.TextAlign = ContentAlignment.BottomCenter;
            BtnLogin.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // BtnCadastro
            // 
            BtnCadastro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCadastro.BackColor = Color.FromArgb(242, 242, 242);
            BtnCadastro.Dock = DockStyle.Bottom;
            BtnCadastro.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Candara", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.ForeColor = Color.FromArgb(6, 7, 33);
            BtnCadastro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BtnCadastro.IconColor = Color.FromArgb(6, 7, 33);
            BtnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastro.IconSize = 80;
            BtnCadastro.Location = new Point(0, 0);
            BtnCadastro.Name = "BtnCadastro";
            BtnCadastro.Size = new Size(188, 225);
            BtnCadastro.TabIndex = 7;
            BtnCadastro.Text = "Cadastre-se";
            BtnCadastro.TextAlign = ContentAlignment.BottomCenter;
            BtnCadastro.TextImageRelation = TextImageRelation.ImageAboveText;
            BtnCadastro.UseVisualStyleBackColor = false;
            BtnCadastro.Click += BtnCadastro_Click;
            // 
            // PainelLateral
            // 
            PainelLateral.Controls.Add(PainelLateralCadastro);
            PainelLateral.Controls.Add(PainelLateralLogin);
            PainelLateral.Dock = DockStyle.Left;
            PainelLateral.Location = new Point(0, 0);
            PainelLateral.Name = "PainelLateral";
            PainelLateral.Size = new Size(188, 450);
            PainelLateral.TabIndex = 8;
            // 
            // PainelLateralCadastro
            // 
            PainelLateralCadastro.Controls.Add(BtnCadastro);
            PainelLateralCadastro.Dock = DockStyle.Bottom;
            PainelLateralCadastro.Location = new Point(0, 225);
            PainelLateralCadastro.Name = "PainelLateralCadastro";
            PainelLateralCadastro.Size = new Size(188, 225);
            PainelLateralCadastro.TabIndex = 1;
            // 
            // PainelLateralLogin
            // 
            PainelLateralLogin.Controls.Add(BtnLogin);
            PainelLateralLogin.Dock = DockStyle.Top;
            PainelLateralLogin.Location = new Point(0, 0);
            PainelLateralLogin.Name = "PainelLateralLogin";
            PainelLateralLogin.Size = new Size(188, 225);
            PainelLateralLogin.TabIndex = 0;
            // 
            // LabelLogin
            // 
            LabelLogin.Anchor = AnchorStyles.None;
            LabelLogin.AutoSize = true;
            LabelLogin.Font = new Font("Candara", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLogin.ForeColor = Color.FromArgb(242, 242, 242);
            LabelLogin.Location = new Point(427, 21);
            LabelLogin.Name = "LabelLogin";
            LabelLogin.Size = new Size(138, 59);
            LabelLogin.TabIndex = 11;
            LabelLogin.Text = "Login";
            // 
            // textBoxLoginEmail
            // 
            textBoxLoginEmail.Anchor = AnchorStyles.None;
            textBoxLoginEmail.BackColor = Color.FromArgb(242, 242, 242);
            textBoxLoginEmail.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLoginEmail.Location = new Point(402, 124);
            textBoxLoginEmail.Name = "textBoxLoginEmail";
            textBoxLoginEmail.Size = new Size(212, 33);
            textBoxLoginEmail.TabIndex = 13;
            // 
            // labelEmail
            // 
            labelEmail.Anchor = AnchorStyles.None;
            labelEmail.Font = new Font("Candara", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(242, 242, 242);
            labelEmail.Location = new Point(298, 124);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(86, 35);
            labelEmail.TabIndex = 14;
            labelEmail.Text = "Email";
            // 
            // labelSenha
            // 
            labelSenha.Anchor = AnchorStyles.None;
            labelSenha.Font = new Font("Candara", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelSenha.ForeColor = Color.FromArgb(242, 242, 242);
            labelSenha.Location = new Point(298, 191);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(86, 34);
            labelSenha.TabIndex = 15;
            labelSenha.Text = "Senha";
            // 
            // textBoxSenhaLogin
            // 
            textBoxSenhaLogin.Anchor = AnchorStyles.None;
            textBoxSenhaLogin.BackColor = Color.FromArgb(242, 242, 242);
            textBoxSenhaLogin.Font = new Font("Candara", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenhaLogin.Location = new Point(402, 191);
            textBoxSenhaLogin.Name = "textBoxSenhaLogin";
            textBoxSenhaLogin.Size = new Size(212, 33);
            textBoxSenhaLogin.TabIndex = 16;
            textBoxSenhaLogin.UseSystemPasswordChar = true;
            // 
            // BtnEfetuarLogin
            // 
            BtnEfetuarLogin.Anchor = AnchorStyles.None;
            BtnEfetuarLogin.FlatAppearance.BorderSize = 3;
            BtnEfetuarLogin.FlatStyle = FlatStyle.Flat;
            BtnEfetuarLogin.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEfetuarLogin.ForeColor = Color.FromArgb(242, 242, 242);
            BtnEfetuarLogin.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            BtnEfetuarLogin.IconColor = Color.FromArgb(242, 242, 242);
            BtnEfetuarLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEfetuarLogin.IconSize = 36;
            BtnEfetuarLogin.Location = new Point(414, 296);
            BtnEfetuarLogin.Name = "BtnEfetuarLogin";
            BtnEfetuarLogin.Size = new Size(200, 50);
            BtnEfetuarLogin.TabIndex = 17;
            BtnEfetuarLogin.Text = "Logar";
            BtnEfetuarLogin.TextAlign = ContentAlignment.MiddleRight;
            BtnEfetuarLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnEfetuarLogin.UseVisualStyleBackColor = true;
            BtnEfetuarLogin.Click += BtnEfetuarLogin_Click;
            // 
            // linkResetarSenha
            // 
            linkResetarSenha.Anchor = AnchorStyles.None;
            linkResetarSenha.AutoSize = true;
            linkResetarSenha.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkResetarSenha.LinkColor = Color.FromArgb(242, 242, 242);
            linkResetarSenha.Location = new Point(439, 366);
            linkResetarSenha.Name = "linkResetarSenha";
            linkResetarSenha.Size = new Size(154, 19);
            linkResetarSenha.TabIndex = 18;
            linkResetarSenha.TabStop = true;
            linkResetarSenha.Text = "esqueceu sua senha ?";
            linkResetarSenha.Click += linkResetarSenha_Click;
            // 
            // BtnMostrarSenha
            // 
            BtnMostrarSenha.Anchor = AnchorStyles.None;
            BtnMostrarSenha.AutoSize = true;
            BtnMostrarSenha.FlatAppearance.BorderSize = 0;
            BtnMostrarSenha.FlatStyle = FlatStyle.Flat;
            BtnMostrarSenha.ForeColor = Color.FromArgb(242, 242, 242);
            BtnMostrarSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            BtnMostrarSenha.IconColor = Color.FromArgb(242, 242, 242);
            BtnMostrarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMostrarSenha.IconSize = 24;
            BtnMostrarSenha.Location = new Point(620, 191);
            BtnMostrarSenha.Name = "BtnMostrarSenha";
            BtnMostrarSenha.Size = new Size(34, 34);
            BtnMostrarSenha.TabIndex = 19;
            BtnMostrarSenha.UseVisualStyleBackColor = true;
            BtnMostrarSenha.Click += BtnMostrarSenha_Click;
            // 
            // PainelFormFilho
            // 
            PainelFormFilho.Dock = DockStyle.Fill;
            PainelFormFilho.Location = new Point(188, 0);
            PainelFormFilho.Name = "PainelFormFilho";
            PainelFormFilho.Size = new Size(612, 450);
            PainelFormFilho.TabIndex = 20;
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 33);
            ClientSize = new Size(800, 450);
            Controls.Add(PainelFormFilho);
            Controls.Add(BtnMostrarSenha);
            Controls.Add(linkResetarSenha);
            Controls.Add(BtnEfetuarLogin);
            Controls.Add(textBoxSenhaLogin);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(textBoxLoginEmail);
            Controls.Add(LabelLogin);
            Controls.Add(PainelLateral);
            ForeColor = Color.FromArgb(242, 242, 242);
            Name = "TelaLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PainelLateral.ResumeLayout(false);
            PainelLateralCadastro.ResumeLayout(false);
            PainelLateralLogin.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton BtnLogin;
        private FontAwesome.Sharp.IconButton BtnCadastro;
        private Panel PainelLateral;
        private Label LabelLogin;
        private TextBox textBoxLoginEmail;
        private Label labelEmail;
        private Label labelSenha;
        private TextBox textBoxSenhaLogin;
        private FontAwesome.Sharp.IconButton BtnEfetuarLogin;
        private LinkLabel linkResetarSenha;
        private FontAwesome.Sharp.IconButton BtnMostrarSenha;
        private Panel PainelLateralCadastro;
        private Panel PainelLateralLogin;
        private Panel PainelFormFilho;
    }
}