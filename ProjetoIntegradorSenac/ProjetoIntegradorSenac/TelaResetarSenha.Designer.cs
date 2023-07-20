namespace ProjetoIntegradorSenac
{
    partial class TelaResetarSenha
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
            LabelDefinirNovaSenha = new Label();
            label1 = new Label();
            label2 = new Label();
            TextBoxNovaSenha = new TextBox();
            IconButtonTrocarSenha = new FontAwesome.Sharp.IconButton();
            TextBoxCPF = new MaskedTextBox();
            BtnVoltar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // LabelDefinirNovaSenha
            // 
            LabelDefinirNovaSenha.AutoSize = true;
            LabelDefinirNovaSenha.Font = new Font("Candara", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDefinirNovaSenha.ForeColor = Color.FromArgb(242, 242, 242);
            LabelDefinirNovaSenha.Location = new Point(72, 30);
            LabelDefinirNovaSenha.Name = "LabelDefinirNovaSenha";
            LabelDefinirNovaSenha.Size = new Size(242, 36);
            LabelDefinirNovaSenha.TabIndex = 0;
            LabelDefinirNovaSenha.Text = "Definir nova senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(67, 139);
            label1.Name = "label1";
            label1.Size = new Size(39, 19);
            label1.TabIndex = 1;
            label1.Text = "CPF:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(12, 212);
            label2.Name = "label2";
            label2.Size = new Size(94, 19);
            label2.TabIndex = 2;
            label2.Text = "Nova Senha:";
            // 
            // TextBoxNovaSenha
            // 
            TextBoxNovaSenha.BackColor = Color.FromArgb(242, 242, 242);
            TextBoxNovaSenha.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxNovaSenha.Location = new Point(120, 204);
            TextBoxNovaSenha.Name = "TextBoxNovaSenha";
            TextBoxNovaSenha.Size = new Size(208, 27);
            TextBoxNovaSenha.TabIndex = 4;
            TextBoxNovaSenha.UseSystemPasswordChar = true;
            TextBoxNovaSenha.TextChanged += TextBoxNovaSenha_TextChanged;
            // 
            // IconButtonTrocarSenha
            // 
            IconButtonTrocarSenha.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            IconButtonTrocarSenha.FlatStyle = FlatStyle.Flat;
            IconButtonTrocarSenha.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IconButtonTrocarSenha.ForeColor = Color.FromArgb(242, 242, 242);
            IconButtonTrocarSenha.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            IconButtonTrocarSenha.IconColor = Color.FromArgb(242, 242, 242);
            IconButtonTrocarSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconButtonTrocarSenha.IconSize = 40;
            IconButtonTrocarSenha.Location = new Point(192, 300);
            IconButtonTrocarSenha.Name = "IconButtonTrocarSenha";
            IconButtonTrocarSenha.Size = new Size(136, 50);
            IconButtonTrocarSenha.TabIndex = 5;
            IconButtonTrocarSenha.Text = "Trocar senha";
            IconButtonTrocarSenha.TextImageRelation = TextImageRelation.TextBeforeImage;
            IconButtonTrocarSenha.UseVisualStyleBackColor = true;
            IconButtonTrocarSenha.Click += IconButtonTrocarSenha_Click;
            // 
            // TextBoxCPF
            // 
            TextBoxCPF.BackColor = Color.FromArgb(242, 242, 242);
            TextBoxCPF.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxCPF.Location = new Point(120, 136);
            TextBoxCPF.Mask = "000,000,000-00";
            TextBoxCPF.Name = "TextBoxCPF";
            TextBoxCPF.Size = new Size(208, 27);
            TextBoxCPF.TabIndex = 6;
            // 
            // BtnVoltar
            // 
            BtnVoltar.FlatAppearance.BorderColor = Color.FromArgb(242, 242, 242);
            BtnVoltar.FlatStyle = FlatStyle.Flat;
            BtnVoltar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVoltar.ForeColor = Color.FromArgb(242, 242, 242);
            BtnVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            BtnVoltar.IconColor = Color.FromArgb(242, 242, 242);
            BtnVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVoltar.IconSize = 40;
            BtnVoltar.ImageAlign = ContentAlignment.MiddleRight;
            BtnVoltar.Location = new Point(50, 299);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(136, 50);
            BtnVoltar.TabIndex = 7;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // TelaResetarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 55);
            ClientSize = new Size(378, 451);
            Controls.Add(BtnVoltar);
            Controls.Add(TextBoxCPF);
            Controls.Add(IconButtonTrocarSenha);
            Controls.Add(TextBoxNovaSenha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelDefinirNovaSenha);
            Name = "TelaResetarSenha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaResetarSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDefinirNovaSenha;
        private Label label1;
        private Label label2;
        private TextBox TextBoxNovaSenha;
        private FontAwesome.Sharp.IconButton IconButtonTrocarSenha;
        private MaskedTextBox TextBoxCPF;
        private FontAwesome.Sharp.IconButton BtnVoltar;
    }
}