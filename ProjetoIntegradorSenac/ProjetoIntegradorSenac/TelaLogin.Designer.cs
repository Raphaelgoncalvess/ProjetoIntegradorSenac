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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnLogin = new FontAwesome.Sharp.IconButton();
            BtnCadastro = new FontAwesome.Sharp.IconButton();
            PainelLateralLogin = new Panel();
            PainelLogin = new Panel();
            label7 = new Label();
            PainelLateralLogin.SuspendLayout();
            PainelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(358, 143);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 199);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 243);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 330);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(356, 281);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 5;
            // 
            // BtnLogin
            // 
            BtnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnLogin.BackColor = Color.Gainsboro;
            BtnLogin.Dock = DockStyle.Top;
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
            BtnCadastro.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnCadastro.BackColor = Color.Gainsboro;
            BtnCadastro.Dock = DockStyle.Bottom;
            BtnCadastro.FlatAppearance.BorderColor = Color.Gainsboro;
            BtnCadastro.FlatAppearance.BorderSize = 0;
            BtnCadastro.FlatStyle = FlatStyle.Flat;
            BtnCadastro.Font = new Font("Malgun Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            BtnCadastro.ForeColor = Color.FromArgb(18, 13, 66);
            BtnCadastro.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            BtnCadastro.IconColor = Color.FromArgb(18, 13, 66);
            BtnCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCadastro.IconSize = 64;
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
            // PainelLogin
            // 
            PainelLogin.Controls.Add(label7);
            PainelLogin.Dock = DockStyle.Fill;
            PainelLogin.Location = new Point(200, 0);
            PainelLogin.Name = "PainelLogin";
            PainelLogin.Size = new Size(600, 450);
            PainelLogin.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Malgun Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gainsboro;
            label7.Location = new Point(204, 193);
            label7.Name = "label7";
            label7.Size = new Size(155, 65);
            label7.TabIndex = 0;
            label7.Text = "Login";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 13, 66);
            ClientSize = new Size(800, 450);
            Controls.Add(PainelLogin);
            Controls.Add(PainelLateralLogin);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaLogin";
            Text = "Form1";
            PainelLateralLogin.ResumeLayout(false);
            PainelLogin.ResumeLayout(false);
            PainelLogin.PerformLayout();
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
        private FontAwesome.Sharp.IconButton BtnLogin;
        private FontAwesome.Sharp.IconButton BtnCadastro;
        private Panel PainelLateralLogin;
        private Panel PainelLogin;
        private Label label7;
    }
}