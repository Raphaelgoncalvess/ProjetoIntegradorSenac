namespace ProjetoIntegradorSenac
{
    partial class DeletarDependente
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
            textBoxCpf = new MaskedTextBox();
            iconButtonDeletar = new FontAwesome.Sharp.IconButton();
            iconButtonVoltar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Candara", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(242, 242, 242);
            label1.Location = new Point(82, 29);
            label1.Name = "label1";
            label1.Size = new Size(217, 29);
            label1.TabIndex = 0;
            label1.Text = "Deletar Dependente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(242, 242, 242);
            label2.Location = new Point(39, 95);
            label2.Name = "label2";
            label2.Size = new Size(310, 19);
            label2.TabIndex = 1;
            label2.Text = "Informe o CPF do dependente a ser deletado";
            label2.Click += label2_Click;
            // 
            // textBoxCpf
            // 
            textBoxCpf.BackColor = Color.FromArgb(242, 242, 242);
            textBoxCpf.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCpf.Location = new Point(133, 162);
            textBoxCpf.Mask = "000,000,000-00";
            textBoxCpf.Name = "textBoxCpf";
            textBoxCpf.Size = new Size(111, 27);
            textBoxCpf.TabIndex = 2;
            // 
            // iconButtonDeletar
            // 
            iconButtonDeletar.FlatStyle = FlatStyle.Flat;
            iconButtonDeletar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonDeletar.ForeColor = Color.FromArgb(242, 242, 242);
            iconButtonDeletar.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            iconButtonDeletar.IconColor = Color.FromArgb(242, 242, 242);
            iconButtonDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonDeletar.Location = new Point(196, 359);
            iconButtonDeletar.Name = "iconButtonDeletar";
            iconButtonDeletar.Size = new Size(170, 50);
            iconButtonDeletar.TabIndex = 3;
            iconButtonDeletar.Text = "Deletar";
            iconButtonDeletar.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButtonDeletar.UseVisualStyleBackColor = true;
            iconButtonDeletar.Click += iconButtonDeletar_Click;
            // 
            // iconButtonVoltar
            // 
            iconButtonVoltar.FlatStyle = FlatStyle.Flat;
            iconButtonVoltar.Font = new Font("Candara", 12F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonVoltar.ForeColor = Color.FromArgb(242, 242, 242);
            iconButtonVoltar.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            iconButtonVoltar.IconColor = Color.FromArgb(242, 242, 242);
            iconButtonVoltar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonVoltar.Location = new Point(12, 359);
            iconButtonVoltar.Name = "iconButtonVoltar";
            iconButtonVoltar.Size = new Size(170, 50);
            iconButtonVoltar.TabIndex = 4;
            iconButtonVoltar.Text = "Voltar";
            iconButtonVoltar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonVoltar.UseVisualStyleBackColor = true;
            iconButtonVoltar.Click += iconButtonVoltar_Click;
            // 
            // DeletarDependente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(6, 7, 33);
            ClientSize = new Size(378, 451);
            Controls.Add(iconButtonVoltar);
            Controls.Add(iconButtonDeletar);
            Controls.Add(textBoxCpf);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DeletarDependente";
            Text = "DeletarDependente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private MaskedTextBox textBoxCpf;
        private FontAwesome.Sharp.IconButton iconButtonDeletar;
        private FontAwesome.Sharp.IconButton iconButtonVoltar;
    }
}