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
            PainelFormFilho = new Panel();
            dateTimePicker1 = new DateTimePicker();
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
            // PainelFormFilho
            // 
            PainelFormFilho.Dock = DockStyle.Fill;
            PainelFormFilho.Location = new Point(0, 0);
            PainelFormFilho.Name = "PainelFormFilho";
            PainelFormFilho.Size = new Size(596, 411);
            PainelFormFilho.TabIndex = 14;
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
            Controls.Add(PainelFormFilho);
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
        private Panel PainelFormFilho;
        private DateTimePicker dateTimePicker1;
    }
}