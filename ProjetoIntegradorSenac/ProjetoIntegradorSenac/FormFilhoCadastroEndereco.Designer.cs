namespace ProjetoIntegradorSenac
{
    partial class FormFilhoCadastroEndereco
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
            labelEndereco = new Label();
            LabelRua = new Label();
            LabelBairro = new Label();
            LabelNúmero = new Label();
            LabelComplemento = new Label();
            LabelCep = new Label();
            textBoxRua = new TextBox();
            textBoxComplemento = new TextBox();
            textBoxNumero = new TextBox();
            textBoxBairro = new TextBox();
            textBoxCep = new TextBox();
            BtnCadastrar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Candara", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelEndereco.ForeColor = Color.FromArgb(242, 242, 242);
            labelEndereco.Location = new Point(151, 9);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(281, 39);
            labelEndereco.TabIndex = 0;
            labelEndereco.Text = "Cadastrar Endereco";
            labelEndereco.TextAlign = ContentAlignment.TopCenter;
            // 
            // LabelRua
            // 
            LabelRua.AutoSize = true;
            LabelRua.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRua.ForeColor = Color.FromArgb(242, 242, 242);
            LabelRua.Location = new Point(185, 57);
            LabelRua.Name = "LabelRua";
            LabelRua.Size = new Size(36, 19);
            LabelRua.TabIndex = 2;
            LabelRua.Text = "Rua";
            // 
            // LabelBairro
            // 
            LabelBairro.AutoSize = true;
            LabelBairro.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBairro.ForeColor = Color.FromArgb(242, 242, 242);
            LabelBairro.Location = new Point(185, 161);
            LabelBairro.Name = "LabelBairro";
            LabelBairro.Size = new Size(50, 19);
            LabelBairro.TabIndex = 3;
            LabelBairro.Text = "Bairro";
            // 
            // LabelNúmero
            // 
            LabelNúmero.AutoSize = true;
            LabelNúmero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNúmero.ForeColor = Color.FromArgb(242, 242, 242);
            LabelNúmero.Location = new Point(185, 109);
            LabelNúmero.Name = "LabelNúmero";
            LabelNúmero.Size = new Size(25, 19);
            LabelNúmero.TabIndex = 4;
            LabelNúmero.Text = "Nº";
            // 
            // LabelComplemento
            // 
            LabelComplemento.AutoSize = true;
            LabelComplemento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelComplemento.ForeColor = Color.FromArgb(242, 242, 242);
            LabelComplemento.Location = new Point(185, 265);
            LabelComplemento.Name = "LabelComplemento";
            LabelComplemento.Size = new Size(106, 19);
            LabelComplemento.TabIndex = 5;
            LabelComplemento.Text = "Complemento";
            // 
            // LabelCep
            // 
            LabelCep.AutoSize = true;
            LabelCep.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCep.ForeColor = Color.FromArgb(242, 242, 242);
            LabelCep.Location = new Point(186, 213);
            LabelCep.Name = "LabelCep";
            LabelCep.Size = new Size(35, 19);
            LabelCep.TabIndex = 6;
            LabelCep.Text = "CEP";
            // 
            // textBoxRua
            // 
            textBoxRua.BackColor = Color.FromArgb(242, 242, 242);
            textBoxRua.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRua.Location = new Point(185, 79);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(195, 27);
            textBoxRua.TabIndex = 7;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.BackColor = Color.FromArgb(242, 242, 242);
            textBoxComplemento.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxComplemento.Location = new Point(186, 287);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(195, 27);
            textBoxComplemento.TabIndex = 8;
            // 
            // textBoxNumero
            // 
            textBoxNumero.BackColor = Color.FromArgb(242, 242, 242);
            textBoxNumero.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNumero.Location = new Point(185, 131);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(52, 27);
            textBoxNumero.TabIndex = 9;
            // 
            // textBoxBairro
            // 
            textBoxBairro.BackColor = Color.FromArgb(242, 242, 242);
            textBoxBairro.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxBairro.Location = new Point(185, 183);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(195, 27);
            textBoxBairro.TabIndex = 10;
            // 
            // textBoxCep
            // 
            textBoxCep.BackColor = Color.FromArgb(242, 242, 242);
            textBoxCep.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCep.Location = new Point(186, 235);
            textBoxCep.Name = "textBoxCep";
            textBoxCep.Size = new Size(195, 27);
            textBoxCep.TabIndex = 11;
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
            BtnCadastrar.Location = new Point(206, 334);
            BtnCadastrar.Name = "BtnCadastrar";
            BtnCadastrar.Size = new Size(153, 47);
            BtnCadastrar.TabIndex = 14;
            BtnCadastrar.Text = "Cadastrar";
            BtnCadastrar.TextAlign = ContentAlignment.MiddleRight;
            BtnCadastrar.TextImageRelation = TextImageRelation.TextBeforeImage;
            BtnCadastrar.UseVisualStyleBackColor = true;
            BtnCadastrar.Click += BtnCadastrar_Click;
            // 
            // FormFilhoCadastroEndereco
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 33);
            ClientSize = new Size(596, 411);
            Controls.Add(BtnCadastrar);
            Controls.Add(textBoxCep);
            Controls.Add(textBoxBairro);
            Controls.Add(textBoxNumero);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxRua);
            Controls.Add(LabelCep);
            Controls.Add(LabelComplemento);
            Controls.Add(LabelNúmero);
            Controls.Add(LabelBairro);
            Controls.Add(LabelRua);
            Controls.Add(labelEndereco);
            Name = "FormFilhoCadastroEndereco";
            Text = "FormFilhoCadastroEndereco";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEndereco;
        private Label LabelRua;
        private Label LabelBairro;
        private Label LabelNúmero;
        private Label LabelComplemento;
        private Label LabelCep;
        private TextBox textBoxRua;
        private TextBox textBoxComplemento;
        private TextBox textBoxNumero;
        private TextBox textBoxBairro;
        private TextBox textBoxCep;
        private FontAwesome.Sharp.IconButton BtnCadastrar;
    }
}