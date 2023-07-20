namespace ProjetoIntegradorSenac
{
    partial class CadastrarDependente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            iconButtonCadastrar = new FontAwesome.Sharp.IconButton();
            textBoxNome = new TextBox();
            textBoxSenha = new TextBox();
            textBoxEmail = new TextBox();
            comboBoxGenero = new ComboBox();
            dateTimePickerDataNascimento = new DateTimePicker();
            textBoxCpf = new MaskedTextBox();
            iconButtonVoltar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            comboBoxParentesco = new ComboBox();
            labelReceberCpf = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(70, 26);
            label1.Name = "label1";
            label1.Size = new Size(241, 29);
            label1.TabIndex = 0;
            label1.Text = "Cadastrar Dependente";
            // 
            // label2
            // 
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(73, 82);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(242, 242, 242);
            label3.Location = new Point(73, 156);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 2;
            label3.Text = "Senha";
            // 
            // label4
            // 
            label4.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(242, 242, 242);
            label4.Location = new Point(73, 236);
            label4.Name = "label4";
            label4.Size = new Size(35, 23);
            label4.TabIndex = 3;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(242, 242, 242);
            label5.Location = new Point(73, 195);
            label5.Name = "label5";
            label5.Size = new Size(45, 23);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(242, 242, 242);
            label6.Location = new Point(73, 275);
            label6.Name = "label6";
            label6.Size = new Size(59, 23);
            label6.TabIndex = 5;
            label6.Text = "Genero";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(242, 242, 242);
            label7.Location = new Point(73, 313);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 6;
            label7.Text = "Data Nasc.";
            // 
            // iconButtonCadastrar
            // 
            iconButtonCadastrar.FlatStyle = FlatStyle.Flat;
            iconButtonCadastrar.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonCadastrar.ForeColor = Color.FromArgb(242, 242, 242);
            iconButtonCadastrar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromFile;
            iconButtonCadastrar.IconColor = Color.FromArgb(242, 242, 242);
            iconButtonCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCadastrar.IconSize = 40;
            iconButtonCadastrar.Location = new Point(196, 359);
            iconButtonCadastrar.Name = "iconButtonCadastrar";
            iconButtonCadastrar.Size = new Size(170, 50);
            iconButtonCadastrar.TabIndex = 7;
            iconButtonCadastrar.Text = "Cadastrar";
            iconButtonCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButtonCadastrar.UseVisualStyleBackColor = true;
            iconButtonCadastrar.Click += iconButtonCadastrar_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(175, 78);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(95, 23);
            textBoxNome.TabIndex = 8;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(175, 152);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(95, 23);
            textBoxSenha.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(175, 191);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(95, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Prefiro não informar", "Outros" });
            comboBoxGenero.Location = new Point(175, 271);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 12;
            comboBoxGenero.Text = "Selecione...";
            // 
            // dateTimePickerDataNascimento
            // 
            dateTimePickerDataNascimento.Location = new Point(175, 309);
            dateTimePickerDataNascimento.Name = "dateTimePickerDataNascimento";
            dateTimePickerDataNascimento.Size = new Size(136, 23);
            dateTimePickerDataNascimento.TabIndex = 13;
            // 
            // textBoxCpf
            // 
            textBoxCpf.Location = new Point(175, 232);
            textBoxCpf.Mask = "000,000,000-00";
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(100, 23);
            textBoxCpf.TabIndex = 14;
            // 
            // iconButtonVoltar
            // 
            iconButtonVoltar.FlatStyle = FlatStyle.Flat;
            iconButtonVoltar.Font = new Font("Candara", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonVoltar.ForeColor = Color.FromArgb(242, 242, 242);
            iconButtonVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            iconButtonVoltar.IconColor = Color.FromArgb(242, 242, 242);
            iconButtonVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonVoltar.IconSize = 40;
            iconButtonVoltar.Location = new Point(15, 359);
            iconButtonVoltar.Name = "iconButtonVoltar";
            iconButtonVoltar.Size = new Size(170, 50);
            iconButtonVoltar.TabIndex = 15;
            iconButtonVoltar.Text = "Voltar";
            iconButtonVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonVoltar.UseVisualStyleBackColor = true;
            iconButtonVoltar.Click += iconButtonVoltar_Click;
            // 
            // label8
            // 
            label8.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(242, 242, 242);
            label8.Location = new Point(73, 117);
            label8.Name = "label8";
            label8.Size = new Size(87, 23);
            label8.TabIndex = 16;
            label8.Text = "Parentesco";
            // 
            // comboBoxParentesco
            // 
            comboBoxParentesco.FormattingEnabled = true;
            comboBoxParentesco.Items.AddRange(new object[] { "Filho(a)", "Sobrinho(a)", "Cônjuge" });
            comboBoxParentesco.Location = new Point(175, 107);
            comboBoxParentesco.Name = "comboBoxParentesco";
            comboBoxParentesco.Size = new Size(121, 23);
            comboBoxParentesco.TabIndex = 17;
            comboBoxParentesco.Text = "Selecione...";
            // 
            // labelReceberCpf
            // 
            labelReceberCpf.AutoSize = true;
            labelReceberCpf.ForeColor = Color.FromArgb(242, 242, 242);
            labelReceberCpf.Location = new Point(340, 9);
            labelReceberCpf.Name = "labelReceberCpf";
            labelReceberCpf.Size = new Size(38, 15);
            labelReceberCpf.TabIndex = 18;
            labelReceberCpf.Text = "label9";
            labelReceberCpf.Visible = false;
            labelReceberCpf.Click += labelReceberCpf_Click;
            // 
            // CadastrarDependente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 55);
            ClientSize = new Size(378, 451);
            Controls.Add(labelReceberCpf);
            Controls.Add(comboBoxParentesco);
            Controls.Add(label8);
            Controls.Add(iconButtonVoltar);
            Controls.Add(textBoxCpf);
            Controls.Add(dateTimePickerDataNascimento);
            Controls.Add(comboBoxGenero);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxNome);
            Controls.Add(iconButtonCadastrar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CadastrarDependente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastrarDependente";
            Load += CadastrarDependente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButtonCadastrar;
        private TextBox textBoxNome;
        private TextBox textBoxSenha;
        private TextBox textBoxEmail;
        private ComboBox comboBoxGenero;
        private DateTimePicker dateTimePickerDataNascimento;
        private MaskedTextBox textBoxCpf;
        private FontAwesome.Sharp.IconButton iconButtonVoltar;
        private Label label8;
        private ComboBox comboBoxParentesco;
        private Label labelReceberCpf;
    }
}