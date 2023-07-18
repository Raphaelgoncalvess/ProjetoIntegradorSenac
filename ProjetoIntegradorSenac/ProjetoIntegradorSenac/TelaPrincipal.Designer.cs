namespace ProjetoIntegradorSenac
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            PainelMenuLateral = new Panel();
            BtnLogout = new FontAwesome.Sharp.IconButton();
            BtnFatura = new FontAwesome.Sharp.IconButton();
            BtnExame = new FontAwesome.Sharp.IconButton();
            BtnEventos = new FontAwesome.Sharp.IconButton();
            BtnMenuUsuario = new FontAwesome.Sharp.IconButton();
            PainelLogo = new Panel();
            PainelBarraTitulo = new Panel();
            LabelNomeUsuario = new Label();
            BtnHome = new FontAwesome.Sharp.IconButton();
            PainelUsuario = new Panel();
            LabelEmail = new Label();
            LabelCpf = new Label();
            LabelGenero = new Label();
            LabelDataNascimento = new Label();
            LabelId = new Label();
            BtnExcluirDependente = new FontAwesome.Sharp.IconButton();
            BtnCadastrarDependente = new FontAwesome.Sharp.IconButton();
            BtnRedefinirSenha = new FontAwesome.Sharp.IconButton();
            usuarioBindingSource = new BindingSource(components);
            PainelMenuLateral.SuspendLayout();
            PainelBarraTitulo.SuspendLayout();
            PainelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // PainelMenuLateral
            // 
            PainelMenuLateral.BackColor = Color.FromArgb(6, 7, 33);
            PainelMenuLateral.Controls.Add(BtnLogout);
            PainelMenuLateral.Controls.Add(BtnFatura);
            PainelMenuLateral.Controls.Add(BtnExame);
            PainelMenuLateral.Controls.Add(BtnEventos);
            PainelMenuLateral.Controls.Add(BtnMenuUsuario);
            PainelMenuLateral.Controls.Add(PainelLogo);
            PainelMenuLateral.Dock = DockStyle.Left;
            PainelMenuLateral.Location = new Point(0, 0);
            PainelMenuLateral.Name = "PainelMenuLateral";
            PainelMenuLateral.Size = new Size(188, 450);
            PainelMenuLateral.TabIndex = 0;
            // 
            // BtnLogout
            // 
            BtnLogout.Dock = DockStyle.Bottom;
            BtnLogout.FlatAppearance.BorderSize = 0;
            BtnLogout.FlatStyle = FlatStyle.Flat;
            BtnLogout.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnLogout.ForeColor = Color.FromArgb(242, 242, 242);
            BtnLogout.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            BtnLogout.IconColor = Color.FromArgb(242, 242, 242);
            BtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLogout.IconSize = 40;
            BtnLogout.Location = new Point(0, 400);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(188, 50);
            BtnLogout.TabIndex = 5;
            BtnLogout.Text = "Logout";
            BtnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLogout.UseVisualStyleBackColor = true;
            // 
            // BtnFatura
            // 
            BtnFatura.Dock = DockStyle.Top;
            BtnFatura.FlatAppearance.BorderSize = 0;
            BtnFatura.FlatStyle = FlatStyle.Flat;
            BtnFatura.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnFatura.ForeColor = Color.FromArgb(242, 242, 242);
            BtnFatura.IconChar = FontAwesome.Sharp.IconChar.Donate;
            BtnFatura.IconColor = Color.FromArgb(242, 242, 242);
            BtnFatura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnFatura.IconSize = 40;
            BtnFatura.Location = new Point(0, 270);
            BtnFatura.Name = "BtnFatura";
            BtnFatura.Size = new Size(188, 60);
            BtnFatura.TabIndex = 4;
            BtnFatura.Text = "Faturas";
            BtnFatura.TextAlign = ContentAlignment.MiddleRight;
            BtnFatura.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnFatura.UseVisualStyleBackColor = true;
            BtnFatura.Click += BtnFatura_Click;
            // 
            // BtnExame
            // 
            BtnExame.Dock = DockStyle.Top;
            BtnExame.FlatAppearance.BorderSize = 0;
            BtnExame.FlatStyle = FlatStyle.Flat;
            BtnExame.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExame.ForeColor = Color.FromArgb(242, 242, 242);
            BtnExame.IconChar = FontAwesome.Sharp.IconChar.BriefcaseMedical;
            BtnExame.IconColor = Color.FromArgb(242, 242, 242);
            BtnExame.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExame.IconSize = 40;
            BtnExame.Location = new Point(0, 210);
            BtnExame.Name = "BtnExame";
            BtnExame.Size = new Size(188, 60);
            BtnExame.TabIndex = 3;
            BtnExame.Text = "Exame";
            BtnExame.TextAlign = ContentAlignment.MiddleRight;
            BtnExame.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExame.UseVisualStyleBackColor = true;
            BtnExame.Click += BtnExame_Click;
            // 
            // BtnEventos
            // 
            BtnEventos.Dock = DockStyle.Top;
            BtnEventos.FlatAppearance.BorderSize = 0;
            BtnEventos.FlatStyle = FlatStyle.Flat;
            BtnEventos.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEventos.ForeColor = Color.FromArgb(242, 242, 242);
            BtnEventos.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            BtnEventos.IconColor = Color.FromArgb(242, 242, 242);
            BtnEventos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEventos.IconSize = 40;
            BtnEventos.Location = new Point(0, 150);
            BtnEventos.Name = "BtnEventos";
            BtnEventos.Size = new Size(188, 60);
            BtnEventos.TabIndex = 2;
            BtnEventos.Text = "Eventos";
            BtnEventos.TextAlign = ContentAlignment.MiddleRight;
            BtnEventos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEventos.UseVisualStyleBackColor = true;
            BtnEventos.Click += BtnEventos_Click;
            // 
            // BtnMenuUsuario
            // 
            BtnMenuUsuario.Dock = DockStyle.Top;
            BtnMenuUsuario.FlatAppearance.BorderSize = 0;
            BtnMenuUsuario.FlatStyle = FlatStyle.Flat;
            BtnMenuUsuario.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnMenuUsuario.ForeColor = Color.FromArgb(242, 242, 242);
            BtnMenuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            BtnMenuUsuario.IconColor = Color.FromArgb(242, 242, 242);
            BtnMenuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMenuUsuario.IconSize = 40;
            BtnMenuUsuario.Location = new Point(0, 90);
            BtnMenuUsuario.Name = "BtnMenuUsuario";
            BtnMenuUsuario.Size = new Size(188, 60);
            BtnMenuUsuario.TabIndex = 1;
            BtnMenuUsuario.Text = "Usuario";
            BtnMenuUsuario.TextAlign = ContentAlignment.MiddleRight;
            BtnMenuUsuario.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnMenuUsuario.UseVisualStyleBackColor = true;
            BtnMenuUsuario.Click += BtnMenuUsuario_Click;
            // 
            // PainelLogo
            // 
            PainelLogo.Dock = DockStyle.Top;
            PainelLogo.Location = new Point(0, 0);
            PainelLogo.Name = "PainelLogo";
            PainelLogo.Size = new Size(188, 90);
            PainelLogo.TabIndex = 0;
            // 
            // PainelBarraTitulo
            // 
            PainelBarraTitulo.BackColor = Color.FromArgb(6, 7, 33);
            PainelBarraTitulo.Controls.Add(LabelNomeUsuario);
            PainelBarraTitulo.Controls.Add(BtnHome);
            PainelBarraTitulo.Dock = DockStyle.Top;
            PainelBarraTitulo.Location = new Point(188, 0);
            PainelBarraTitulo.Name = "PainelBarraTitulo";
            PainelBarraTitulo.Size = new Size(612, 90);
            PainelBarraTitulo.TabIndex = 1;
            // 
            // LabelNomeUsuario
            // 
            LabelNomeUsuario.AutoSize = true;
            LabelNomeUsuario.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNomeUsuario.ForeColor = Color.FromArgb(242, 242, 242);
            LabelNomeUsuario.Location = new Point(524, 35);
            LabelNomeUsuario.Name = "LabelNomeUsuario";
            LabelNomeUsuario.Size = new Size(42, 18);
            LabelNomeUsuario.TabIndex = 1;
            LabelNomeUsuario.Text = "label1";
            // 
            // BtnHome
            // 
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnHome.ForeColor = Color.FromArgb(242, 242, 242);
            BtnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            BtnHome.IconColor = Color.FromArgb(242, 242, 242);
            BtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnHome.IconSize = 40;
            BtnHome.Location = new Point(6, 24);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(105, 40);
            BtnHome.TabIndex = 0;
            BtnHome.Text = "Home";
            BtnHome.TextAlign = ContentAlignment.MiddleRight;
            BtnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnHome.UseVisualStyleBackColor = true;
            // 
            // PainelUsuario
            // 
            PainelUsuario.BackColor = Color.FromArgb(6, 7, 45);
            PainelUsuario.Controls.Add(LabelEmail);
            PainelUsuario.Controls.Add(LabelCpf);
            PainelUsuario.Controls.Add(LabelGenero);
            PainelUsuario.Controls.Add(LabelDataNascimento);
            PainelUsuario.Controls.Add(LabelId);
            PainelUsuario.Controls.Add(BtnExcluirDependente);
            PainelUsuario.Controls.Add(BtnCadastrarDependente);
            PainelUsuario.Controls.Add(BtnRedefinirSenha);
            PainelUsuario.Dock = DockStyle.Fill;
            PainelUsuario.Location = new Point(188, 90);
            PainelUsuario.Name = "PainelUsuario";
            PainelUsuario.Size = new Size(612, 360);
            PainelUsuario.TabIndex = 2;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.FromArgb(242, 242, 242);
            LabelEmail.Location = new Point(36, 180);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(50, 19);
            LabelEmail.TabIndex = 7;
            LabelEmail.Text = "label3";
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCpf.ForeColor = Color.FromArgb(242, 242, 242);
            LabelCpf.Location = new Point(33, 142);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(50, 19);
            LabelCpf.TabIndex = 6;
            LabelCpf.Text = "label3";
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelGenero.ForeColor = Color.FromArgb(242, 242, 242);
            LabelGenero.Location = new Point(158, 161);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(50, 19);
            LabelGenero.TabIndex = 5;
            LabelGenero.Text = "label3";
            // 
            // LabelDataNascimento
            // 
            LabelDataNascimento.AutoSize = true;
            LabelDataNascimento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDataNascimento.ForeColor = Color.FromArgb(242, 242, 242);
            LabelDataNascimento.Location = new Point(320, 180);
            LabelDataNascimento.Name = "LabelDataNascimento";
            LabelDataNascimento.Size = new Size(49, 19);
            LabelDataNascimento.TabIndex = 4;
            LabelDataNascimento.Text = "label2";
            // 
            // LabelId
            // 
            LabelId.AutoSize = true;
            LabelId.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelId.ForeColor = Color.FromArgb(242, 242, 242);
            LabelId.Location = new Point(309, 120);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(48, 19);
            LabelId.TabIndex = 3;
            LabelId.Text = "label1";
            // 
            // BtnExcluirDependente
            // 
            BtnExcluirDependente.FlatStyle = FlatStyle.Flat;
            BtnExcluirDependente.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnExcluirDependente.ForeColor = Color.FromArgb(242, 242, 242);
            BtnExcluirDependente.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            BtnExcluirDependente.IconColor = Color.FromArgb(242, 242, 242);
            BtnExcluirDependente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnExcluirDependente.IconSize = 40;
            BtnExcluirDependente.Location = new Point(236, 310);
            BtnExcluirDependente.Name = "BtnExcluirDependente";
            BtnExcluirDependente.Size = new Size(147, 47);
            BtnExcluirDependente.TabIndex = 2;
            BtnExcluirDependente.Text = "Excluir Dependente";
            BtnExcluirDependente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnExcluirDependente.UseVisualStyleBackColor = true;
            // 
            // BtnCadastrarDependente
            // 
            BtnCadastrarDependente.FlatStyle = FlatStyle.Flat;
            BtnCadastrarDependente.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrarDependente.ForeColor = Color.FromArgb(242, 242, 242);
            BtnCadastrarDependente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BtnCadastrarDependente.IconColor = Color.FromArgb(242, 242, 242);
            BtnCadastrarDependente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastrarDependente.IconSize = 40;
            BtnCadastrarDependente.Location = new Point(83, 310);
            BtnCadastrarDependente.Name = "BtnCadastrarDependente";
            BtnCadastrarDependente.Size = new Size(147, 47);
            BtnCadastrarDependente.TabIndex = 1;
            BtnCadastrarDependente.Text = "Cadastrar Dependente";
            BtnCadastrarDependente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnCadastrarDependente.UseVisualStyleBackColor = true;
            // 
            // BtnRedefinirSenha
            // 
            BtnRedefinirSenha.FlatStyle = FlatStyle.Flat;
            BtnRedefinirSenha.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnRedefinirSenha.ForeColor = Color.FromArgb(242, 242, 242);
            BtnRedefinirSenha.IconChar = FontAwesome.Sharp.IconChar.Keyboard;
            BtnRedefinirSenha.IconColor = Color.FromArgb(242, 242, 242);
            BtnRedefinirSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRedefinirSenha.IconSize = 40;
            BtnRedefinirSenha.Location = new Point(389, 310);
            BtnRedefinirSenha.Name = "BtnRedefinirSenha";
            BtnRedefinirSenha.Size = new Size(147, 47);
            BtnRedefinirSenha.TabIndex = 0;
            BtnRedefinirSenha.Text = "Redefinir Senha";
            BtnRedefinirSenha.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRedefinirSenha.UseVisualStyleBackColor = true;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Usuario);
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PainelUsuario);
            Controls.Add(PainelBarraTitulo);
            Controls.Add(PainelMenuLateral);
            Name = "TelaPrincipal";
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            PainelMenuLateral.ResumeLayout(false);
            PainelBarraTitulo.ResumeLayout(false);
            PainelBarraTitulo.PerformLayout();
            PainelUsuario.ResumeLayout(false);
            PainelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PainelMenuLateral;
        private FontAwesome.Sharp.IconButton BtnMenuUsuario;
        private Panel PainelLogo;
        private FontAwesome.Sharp.IconButton BtnLogout;
        private FontAwesome.Sharp.IconButton BtnFatura;
        private FontAwesome.Sharp.IconButton BtnExame;
        private FontAwesome.Sharp.IconButton BtnEventos;
        private Panel PainelBarraTitulo;
        private FontAwesome.Sharp.IconButton BtnHome;
        private Label LabelNomeUsuario;
        private Panel PainelUsuario;
        private FontAwesome.Sharp.IconButton BtnCadastrarDependente;
        private FontAwesome.Sharp.IconButton BtnRedefinirSenha;
        private FontAwesome.Sharp.IconButton BtnExcluirDependente;
        private BindingSource usuarioBindingSource;
        private Label LabelGenero;
        private Label LabelDataNascimento;
        private Label LabelId;
        private Label LabelCpf;
        private Label LabelEmail;
    }
}