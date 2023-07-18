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
            label2 = new Label();
            label1 = new Label();
            LabelIdUsuario = new Label();
            LabelNomeUsuario = new Label();
            BtnHome = new FontAwesome.Sharp.IconButton();
            PainelUsuario = new Panel();
            LblDependentes = new Label();
            dataGridView1 = new DataGridView();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LabelEmail = new Label();
            LabelCpf = new Label();
            LabelGenero = new Label();
            LabelDataNascimento = new Label();
            BtnExcluirDependente = new FontAwesome.Sharp.IconButton();
            BtnCadastrarDependente = new FontAwesome.Sharp.IconButton();
            BtnRedefinirSenha = new FontAwesome.Sharp.IconButton();
            usuarioBindingSource = new BindingSource(components);
            PainelMenuLateral.SuspendLayout();
            PainelBarraTitulo.SuspendLayout();
            PainelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
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
            BtnLogout.Click += BtnLogout_Click;
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
            PainelBarraTitulo.Controls.Add(label2);
            PainelBarraTitulo.Controls.Add(label1);
            PainelBarraTitulo.Controls.Add(LabelIdUsuario);
            PainelBarraTitulo.Controls.Add(LabelNomeUsuario);
            PainelBarraTitulo.Controls.Add(BtnHome);
            PainelBarraTitulo.Dock = DockStyle.Top;
            PainelBarraTitulo.Location = new Point(188, 0);
            PainelBarraTitulo.Name = "PainelBarraTitulo";
            PainelBarraTitulo.Size = new Size(612, 90);
            PainelBarraTitulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(449, 53);
            label2.Name = "label2";
            label2.Size = new Size(13, 13);
            label2.TabIndex = 4;
            label2.Text = "#";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(375, 35);
            label1.Name = "label1";
            label1.Size = new Size(78, 18);
            label1.TabIndex = 3;
            label1.Text = "Bem vindo:";
            // 
            // LabelIdUsuario
            // 
            LabelIdUsuario.AutoSize = true;
            LabelIdUsuario.Font = new Font("Candara", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelIdUsuario.ForeColor = Color.FromArgb(242, 242, 242);
            LabelIdUsuario.Location = new Point(459, 53);
            LabelIdUsuario.Name = "LabelIdUsuario";
            LabelIdUsuario.Size = new Size(34, 13);
            LabelIdUsuario.TabIndex = 2;
            LabelIdUsuario.Text = "label1";
            LabelIdUsuario.Click += LabelIdUsuario_Click;
            // 
            // LabelNomeUsuario
            // 
            LabelNomeUsuario.AutoSize = true;
            LabelNomeUsuario.Font = new Font("Candara", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNomeUsuario.ForeColor = Color.FromArgb(242, 242, 242);
            LabelNomeUsuario.Location = new Point(450, 35);
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
            PainelUsuario.Controls.Add(LblDependentes);
            PainelUsuario.Controls.Add(dataGridView1);
            PainelUsuario.Controls.Add(iconPictureBox4);
            PainelUsuario.Controls.Add(iconPictureBox3);
            PainelUsuario.Controls.Add(iconPictureBox2);
            PainelUsuario.Controls.Add(iconPictureBox1);
            PainelUsuario.Controls.Add(LabelEmail);
            PainelUsuario.Controls.Add(LabelCpf);
            PainelUsuario.Controls.Add(LabelGenero);
            PainelUsuario.Controls.Add(LabelDataNascimento);
            PainelUsuario.Controls.Add(BtnExcluirDependente);
            PainelUsuario.Controls.Add(BtnCadastrarDependente);
            PainelUsuario.Controls.Add(BtnRedefinirSenha);
            PainelUsuario.Dock = DockStyle.Fill;
            PainelUsuario.Location = new Point(188, 90);
            PainelUsuario.Name = "PainelUsuario";
            PainelUsuario.Size = new Size(612, 360);
            PainelUsuario.TabIndex = 2;
            // 
            // LblDependentes
            // 
            LblDependentes.AutoSize = true;
            LblDependentes.Font = new Font("Candara", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblDependentes.ForeColor = Color.FromArgb(242, 242, 242);
            LblDependentes.Location = new Point(303, 19);
            LblDependentes.Name = "LblDependentes";
            LblDependentes.Size = new Size(218, 23);
            LblDependentes.TabIndex = 13;
            LblDependentes.Text = "Dependentes cadastrados";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(6, 7, 45);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(265, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(300, 244);
            dataGridView1.TabIndex = 12;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.FromArgb(6, 7, 45);
            iconPictureBox4.ForeColor = Color.FromArgb(242, 242, 242);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.MarsAndVenus;
            iconPictureBox4.IconColor = Color.FromArgb(242, 242, 242);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 44;
            iconPictureBox4.Location = new Point(16, 186);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(44, 45);
            iconPictureBox4.TabIndex = 11;
            iconPictureBox4.TabStop = false;
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.FromArgb(6, 7, 45);
            iconPictureBox3.ForeColor = Color.FromArgb(242, 242, 242);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.CakeCandles;
            iconPictureBox3.IconColor = Color.FromArgb(242, 242, 242);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 44;
            iconPictureBox3.Location = new Point(16, 135);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(44, 45);
            iconPictureBox3.TabIndex = 10;
            iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.FromArgb(6, 7, 45);
            iconPictureBox2.ForeColor = Color.FromArgb(242, 242, 242);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            iconPictureBox2.IconColor = Color.FromArgb(242, 242, 242);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 44;
            iconPictureBox2.Location = new Point(16, 84);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(44, 45);
            iconPictureBox2.TabIndex = 9;
            iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(6, 7, 45);
            iconPictureBox1.ForeColor = Color.FromArgb(242, 242, 242);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MailBulk;
            iconPictureBox1.IconColor = Color.FromArgb(242, 242, 242);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 44;
            iconPictureBox1.Location = new Point(16, 33);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(44, 45);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.FromArgb(242, 242, 242);
            LabelEmail.Location = new Point(66, 49);
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
            LabelCpf.Location = new Point(66, 100);
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
            LabelGenero.Location = new Point(67, 198);
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
            LabelDataNascimento.Location = new Point(67, 148);
            LabelDataNascimento.Name = "LabelDataNascimento";
            LabelDataNascimento.Size = new Size(49, 19);
            LabelDataNascimento.TabIndex = 4;
            LabelDataNascimento.Text = "label2";
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
            BtnExcluirDependente.Location = new Point(418, 310);
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
            BtnCadastrarDependente.Location = new Point(265, 310);
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
            BtnRedefinirSenha.Location = new Point(16, 310);
            BtnRedefinirSenha.Name = "BtnRedefinirSenha";
            BtnRedefinirSenha.Size = new Size(147, 47);
            BtnRedefinirSenha.TabIndex = 0;
            BtnRedefinirSenha.Text = "Redefinir Senha";
            BtnRedefinirSenha.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRedefinirSenha.UseVisualStyleBackColor = true;
            BtnRedefinirSenha.Click += BtnRedefinirSenha_Click;
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
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            PainelMenuLateral.ResumeLayout(false);
            PainelBarraTitulo.ResumeLayout(false);
            PainelBarraTitulo.PerformLayout();
            PainelUsuario.ResumeLayout(false);
            PainelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
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
        private Label LabelCpf;
        private Label LabelEmail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private Label LblDependentes;
        private DataGridView dataGridView1;
        private Label LabelIdUsuario;
        private Label label2;
        private Label label1;
    }
}