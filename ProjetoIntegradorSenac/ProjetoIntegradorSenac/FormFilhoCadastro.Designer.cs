namespace ProjetoIntegradorSenac
{
    partial class FormFilhoCadastro
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
            LabelCadastro = new Label();
            LabelNome = new Label();
            LabelCpf = new Label();
            LabelGenero = new Label();
            LabelDataNascimento = new Label();
            LabelEmail = new Label();
            LabelSenha = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            textBoxSenha = new TextBox();
            textBoxCpf = new MaskedTextBox();
            comboBoxGenero = new ComboBox();
            BtnContinuar = new FontAwesome.Sharp.IconButton();
            PainelCadastroEndereco = new Panel();
            textBoxCep = new MaskedTextBox();
            BtnVoltar = new FontAwesome.Sharp.IconButton();
            BtnCadastrar = new FontAwesome.Sharp.IconButton();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxRua = new TextBox();
            LabelCep = new Label();
            LabelComplemento = new Label();
            LabelNúmero = new Label();
            LabelBairro = new Label();
            LabelRua = new Label();
            labelEndereco = new Label();
            dateTimePicker1 = new DateTimePicker();
            PainelCadastroEndereco.SuspendLayout();
            SuspendLayout();
            // 
            // LabelCadastro
            // 
            LabelCadastro.AutoSize = true;
            LabelCadastro.Font = new Font("Candara", 36F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCadastro.ForeColor = Color.FromArgb(242, 242, 242);
            LabelCadastro.Location = new Point(207, 9);
            LabelCadastro.Name = "LabelCadastro";
            LabelCadastro.Size = new Size(206, 59);
            LabelCadastro.TabIndex = 0;
            LabelCadastro.Text = "Cadastro";
            // 
            // LabelNome
            // 
            LabelNome.AutoSize = true;
            LabelNome.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNome.ForeColor = Color.FromArgb(242, 242, 242);
            LabelNome.Location = new Point(112, 94);
            LabelNome.Name = "LabelNome";
            LabelNome.Size = new Size(50, 19);
            LabelNome.TabIndex = 1;
            LabelNome.Text = "Nome";
            // 
            // LabelCpf
            // 
            LabelCpf.AutoSize = true;
            LabelCpf.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCpf.ForeColor = Color.FromArgb(242, 242, 242);
            LabelCpf.Location = new Point(112, 136);
            LabelCpf.Name = "LabelCpf";
            LabelCpf.Size = new Size(35, 19);
            LabelCpf.TabIndex = 2;
            LabelCpf.Text = "CPF";
            // 
            // LabelGenero
            // 
            LabelGenero.AutoSize = true;
            LabelGenero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelGenero.ForeColor = Color.FromArgb(242, 242, 242);
            LabelGenero.Location = new Point(112, 177);
            LabelGenero.Name = "LabelGenero";
            LabelGenero.Size = new Size(59, 19);
            LabelGenero.TabIndex = 3;
            LabelGenero.Text = "Genero";
            // 
            // LabelDataNascimento
            // 
            LabelDataNascimento.AutoSize = true;
            LabelDataNascimento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDataNascimento.ForeColor = Color.FromArgb(242, 242, 242);
            LabelDataNascimento.Location = new Point(112, 217);
            LabelDataNascimento.Name = "LabelDataNascimento";
            LabelDataNascimento.Size = new Size(101, 19);
            LabelDataNascimento.TabIndex = 4;
            LabelDataNascimento.Text = "Data de Nasc.";
            LabelDataNascimento.Click += label3_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.ForeColor = Color.FromArgb(242, 242, 242);
            LabelEmail.Location = new Point(112, 259);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(45, 19);
            LabelEmail.TabIndex = 5;
            LabelEmail.Text = "Email";
            LabelEmail.Click += LabelEmail_Click;
            // 
            // LabelSenha
            // 
            LabelSenha.AutoSize = true;
            LabelSenha.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelSenha.ForeColor = Color.FromArgb(242, 242, 242);
            LabelSenha.Location = new Point(112, 301);
            LabelSenha.Name = "LabelSenha";
            LabelSenha.Size = new Size(51, 19);
            LabelSenha.TabIndex = 6;
            LabelSenha.Text = "Senha";
            // 
            // textBoxNome
            // 
            textBoxNome.BackColor = Color.FromArgb(242, 242, 242);
            textBoxNome.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNome.Location = new Point(219, 90);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(183, 23);
            textBoxNome.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.FromArgb(242, 242, 242);
            textBoxEmail.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point(219, 255);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(183, 23);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxSenha
            // 
            textBoxSenha.BackColor = Color.FromArgb(242, 242, 242);
            textBoxSenha.Font = new Font("Candara", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSenha.Location = new Point(219, 297);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(183, 23);
            textBoxSenha.TabIndex = 9;
            // 
            // textBoxCpf
            // 
            textBoxCpf.BackColor = Color.FromArgb(242, 242, 242);
            textBoxCpf.Location = new Point(219, 132);
            textBoxCpf.Mask = "000,000,000-00";
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(183, 23);
            textBoxCpf.TabIndex = 10;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.BackColor = Color.FromArgb(242, 242, 242);
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Prefiro não informar", "Outros" });
            comboBoxGenero.Location = new Point(219, 173);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(183, 23);
            comboBoxGenero.TabIndex = 11;
            comboBoxGenero.Text = "Selecione...";
            comboBoxGenero.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // BtnContinuar
            // 
            BtnContinuar.FlatStyle = FlatStyle.Flat;
            BtnContinuar.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnContinuar.ForeColor = Color.FromArgb(242, 242, 242);
            BtnContinuar.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            BtnContinuar.IconColor = Color.FromArgb(242, 242, 242);
            BtnContinuar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnContinuar.IconSize = 32;
            BtnContinuar.Location = new Point(239, 340);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(145, 42);
            BtnContinuar.TabIndex = 13;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnContinuar.UseVisualStyleBackColor = true;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // PainelCadastroEndereco
            // 
            PainelCadastroEndereco.Controls.Add(textBoxCep);
            PainelCadastroEndereco.Controls.Add(BtnVoltar);
            PainelCadastroEndereco.Controls.Add(BtnCadastrar);
            PainelCadastroEndereco.Controls.Add(textBoxBairro);
            PainelCadastroEndereco.Controls.Add(textBoxNumero);
            PainelCadastroEndereco.Controls.Add(textBoxComplemento);
            PainelCadastroEndereco.Controls.Add(textBoxRua);
            PainelCadastroEndereco.Controls.Add(LabelCep);
            PainelCadastroEndereco.Controls.Add(LabelComplemento);
            PainelCadastroEndereco.Controls.Add(LabelNúmero);
            PainelCadastroEndereco.Controls.Add(LabelBairro);
            PainelCadastroEndereco.Controls.Add(LabelRua);
            PainelCadastroEndereco.Controls.Add(labelEndereco);
            PainelCadastroEndereco.Dock = DockStyle.Fill;
            PainelCadastroEndereco.Location = new Point(0, 0);
            PainelCadastroEndereco.Name = "PainelCadastroEndereco";
            PainelCadastroEndereco.Size = new Size(596, 411);
            PainelCadastroEndereco.TabIndex = 14;
            PainelCadastroEndereco.Paint += PainelFormFilho_Paint;
            // 
            // textBoxCep
            // 
            textBoxCep.BackColor = Color.FromArgb(242, 242, 242);
            textBoxCep.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCep.Location = new Point(193, 245);
            textBoxCep.Mask = "00000-000";
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(194, 27);
            textBoxCep.TabIndex = 28;
            // 
            // BtnVoltar
            // 
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVoltar.ForeColor = Color.FromArgb(242, 242, 242);
            BtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            BtnVoltar.IconColor = Color.FromArgb(242, 242, 242);
            BtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVoltar.IconSize = 32;
            BtnVoltar.Location = new Point(127, 344);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(153, 47);
            BtnVoltar.TabIndex = 27;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.TextAlign = ContentAlignment.MiddleRight;
            BtnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnCadastrar
            // 
            BtnCadastrar.FlatStyle = FlatStyle.Flat;
            BtnCadastrar.Font = new Font("Candara", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastrar.ForeColor = Color.FromArgb(242, 242, 242);
            BtnCadastrar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            BtnCadastrar.IconColor = Color.FromArgb(242, 242, 242);
            BtnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastrar.IconSize = 32;
            BtnCadastrar.Location = new Point(300, 344);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(153, 47);
            BtnCadastrar.TabIndex = 26;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            BtnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // textBoxBairro
            // 
            textBoxBairro.BackColor = Color.FromArgb(242, 242, 242);
            textBoxBairro.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBairro.Location = new Point(192, 193);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(195, 27);
            textBoxBairro.TabIndex = 24;
            // 
            // textBoxNumero
            // 
            textBoxNumero.BackColor = Color.FromArgb(242, 242, 242);
            textBoxNumero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumero.Location = new Point(192, 141);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(52, 27);
            textBoxNumero.TabIndex = 23;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.BackColor = Color.FromArgb(242, 242, 242);
            textBoxComplemento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComplemento.Location = new Point(193, 297);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(195, 27);
            textBoxComplemento.TabIndex = 22;
            // 
            // textBoxRua
            // 
            textBoxRua.BackColor = Color.FromArgb(242, 242, 242);
            textBoxRua.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRua.Location = new Point(192, 89);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(195, 27);
            textBoxRua.TabIndex = 21;
            // 
            // LabelCep
            // 
            LabelCep.AutoSize = true;
            LabelCep.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCep.ForeColor = Color.FromArgb(242, 242, 242);
            LabelCep.Location = new Point(193, 223);
            LabelCep.Name = "LabelCep";
            LabelCep.Size = new Size(35, 19);
            LabelCep.TabIndex = 20;
            LabelCep.Text = "CEP";
            // 
            // LabelComplemento
            // 
            LabelComplemento.AutoSize = true;
            LabelComplemento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelComplemento.ForeColor = Color.FromArgb(242, 242, 242);
            LabelComplemento.Location = new Point(192, 275);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(106, 19);
            LabelComplemento.TabIndex = 19;
            LabelComplemento.Text = "Complemento";
            // 
            // LabelNúmero
            // 
            LabelNúmero.AutoSize = true;
            LabelNúmero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNúmero.ForeColor = Color.FromArgb(242, 242, 242);
            LabelNúmero.Location = new Point(192, 119);
            LabelNúmero.Name = "LabelNúmero";
            LabelNúmero.Size = new Size(25, 19);
            LabelNúmero.TabIndex = 18;
            LabelNúmero.Text = "Nº";
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBairro.ForeColor = Color.FromArgb(242, 242, 242);
            LabelBairro.Location = new Point(192, 171);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(50, 19);
            LabelBairro.TabIndex = 17;
            LabelBairro.Text = "Bairro";
            // 
            // LabelRua
            // 
            LabelRua.AutoSize = true;
            LabelRua.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRua.ForeColor = Color.FromArgb(242, 242, 242);
            LabelRua.Location = new Point(192, 67);
            LabelRua.Name = "LabelRua";
            LabelRua.Size = new Size(36, 19);
            LabelRua.TabIndex = 16;
            LabelRua.Text = "Rua";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereco.ForeColor = Color.FromArgb(242, 242, 242);
            labelEndereco.Location = new Point(158, 19);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(281, 39);
            labelEndereco.TabIndex = 15;
            labelEndereco.Text = "Cadastrar Endereco";
            labelEndereco.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(219, 217);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(183, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // FormFilhoCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 33);
            ClientSize = new Size(596, 411);
            Controls.Add(PainelCadastroEndereco);
            Controls.Add(dateTimePicker1);
            Controls.Add(BtnContinuar);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxCpf);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(LabelSenha);
            Controls.Add(LabelEmail);
            Controls.Add(LabelDataNascimento);
            Controls.Add(LabelGenero);
            Controls.Add(LabelCpf);
            Controls.Add(LabelNome);
            Controls.Add(LabelCadastro);
            Name = "FormFilhoCadastro";
            Text = "FormFilhoCadastro";
            Load += FormFilhoCadastro_Load;
            PainelCadastroEndereco.ResumeLayout(false);
            PainelCadastroEndereco.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCadastro;
        private Label LabelNome;
        private Label LabelCpf;
        private Label LabelGenero;
        private Label LabelDataNascimento;
        private Label LabelEmail;
        private Label LabelSenha;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private TextBox textBoxSenha;
        private MaskedTextBox textBoxCpf;
        private ComboBox comboBoxGenero;
        private FontAwesome.Sharp.IconButton BtnContinuar;
        private Panel PainelCadastroEndereco;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton BtnCadastrar;
        private TextBox textBoxBairro;
        private TextBox textBoxNumero;
        private TextBox textBoxComplemento;
        private TextBox textBoxRua;
        private Label LabelCep;
        private Label LabelComplemento;
        private Label LabelNúmero;
        private Label LabelBairro;
        private Label LabelRua;
        private Label labelEndereco;
        private FontAwesome.Sharp.IconButton BtnVoltar;
        private MaskedTextBox textBoxCep;
    }
}