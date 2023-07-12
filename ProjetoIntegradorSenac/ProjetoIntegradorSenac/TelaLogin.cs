using System.Security.Cryptography.X509Certificates;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoIntegradorSenac
{
    public partial class TelaLogin : Form
    {

        //Campos
        public IconButton btnAtual; //Botão atual
        //public Panel btnBordaEsquerda; //Borda esquerda do botão atual

        public TelaLogin()
        {
            InitializeComponent();
            /* btnBordaEsquerda = new Panel();
             btnBordaEsquerda.Size = new Size(7, 60);*/
            //PainelLateralLogin.Controls.Add(btnBordaEsquerda);
            AtivarBotao(BtnLogin, CoresRGB.cor1);
            PainelCadastro.Visible = false;
        }
        //Structs
        public struct CoresRGB
        {
            public static Color cor1 = Color.FromArgb(18, 13, 66);
            public static Color cor2 = Color.FromArgb(249, 118, 176);
            public static Color cor3 = Color.FromArgb(253, 138, 114);
            public static Color cor4 = Color.FromArgb(95, 77, 221);
            public static Color cor5 = Color.FromArgb(249, 88, 155);
            public static Color cor6 = Color.FromArgb(24, 161, 251);
        }

        //Métodos
        public void AtivarBotao(object senderBtn, Color cor)
        {
            DesativarBotao();
            if (senderBtn != null)
            {
                //Botão
                btnAtual = (IconButton)senderBtn;
                btnAtual.BackColor = Color.FromArgb(18, 13, 66);
                btnAtual.ForeColor = Color.Gainsboro;
                btnAtual.TextAlign = ContentAlignment.BottomCenter;
                btnAtual.IconColor = Color.Gainsboro;
                btnAtual.TextImageRelation = TextImageRelation.ImageAboveText;
                btnAtual.ImageAlign = ContentAlignment.MiddleCenter;
                //Borda esquerda do botão
                /*btnBordaEsquerda.BackColor = cor;
                btnBordaEsquerda.Location = new Point(0, btnAtual.Location.Y);
                btnBordaEsquerda.Visible = true;
                btnBordaEsquerda.BringToFront();*/
            }
        }
        public void DesativarBotao()
        {
            if (btnAtual != null)
            {
                btnAtual.BackColor = Color.Gainsboro;
                btnAtual.ForeColor = Color.FromArgb(18, 13, 66);
                btnAtual.TextAlign = ContentAlignment.BottomCenter;
                btnAtual.IconColor = Color.FromArgb(18, 13, 66);
                btnAtual.TextImageRelation = TextImageRelation.ImageAboveText;
                btnAtual.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRGB.cor1);
            PainelCadastro.Visible = false;




        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRGB.cor1);
            PainelCadastro.Visible = true;



        }

        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            textBoxSenhaLogin.UseSystemPasswordChar = false;
        }
    }
}