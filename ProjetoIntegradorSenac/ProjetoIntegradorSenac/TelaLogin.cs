using FontAwesome.Sharp;

namespace ProjetoIntegradorSenac
{
    public partial class TelaLogin : Form
    {

        //Campos
        public IconButton btnAtual; //Botão atual

        public TelaLogin()
        {
            InitializeComponent();
            AtivarBotao(BtnLogin, CoresRGB.cor1);
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
                btnAtual.BackColor = Color.FromArgb(6, 7, 33);
                btnAtual.ForeColor = Color.FromArgb(242, 242, 242);
                btnAtual.TextAlign = ContentAlignment.BottomCenter;
                btnAtual.IconColor = Color.FromArgb(242, 242, 242);
                btnAtual.TextImageRelation = TextImageRelation.ImageAboveText;
                btnAtual.ImageAlign = ContentAlignment.MiddleCenter;

            }
        }
        public void DesativarBotao()
        {
            if (btnAtual != null)
            {
                btnAtual.BackColor = Color.FromArgb(242, 242, 242);
                btnAtual.ForeColor = Color.FromArgb(6, 7, 33);
                btnAtual.TextAlign = ContentAlignment.BottomCenter;
                btnAtual.IconColor = Color.FromArgb(6, 7, 33);
                btnAtual.TextImageRelation = TextImageRelation.ImageAboveText;
                btnAtual.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRGB.cor1);
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRGB.cor1);
        }

        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            textBoxSenhaLogin.UseSystemPasswordChar = false;
        }

        private void BtnEfetuarLogin_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();

            usuario.Email = textBoxLoginEmail.Text;
            usuario.Senha = textBoxSenhaLogin.Text;

            var retorno = db.BuscarUsuario(usuario.Email, usuario.Senha, true);

            if (!retorno)
            {
                MessageBox.Show("Usuário não encontrado");
            }
            else
            {
                MessageBox.Show("Usuário encontrado");
            }
        }
    }
}