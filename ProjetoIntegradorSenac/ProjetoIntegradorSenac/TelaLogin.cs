using FontAwesome.Sharp;
using System.Security.Cryptography;

namespace ProjetoIntegradorSenac
{
    public partial class TelaLogin : Form
    {

        //Campos
        public IconButton btnAtual; //Bot�o atual
        public Form formFilho; //Formul�rio filho

        public TelaLogin()
        {
            InitializeComponent();
            AtivarBotao(BtnLogin, CoresRGB.cor1);
            PainelFormFilho.Visible = false;
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

        //M�todos
        public void AtivarBotao(object senderBtn, Color cor)
        {
            DesativarBotao();
            if (senderBtn != null)
            {
                //Bot�o
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
            PainelFormFilho.Visible = false;
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRGB.cor1);
            PainelFormFilho.Visible = true;
            AbrirFormFilho(new FormFilhoCadastro());
        }

        private void BtnMostrarSenha_Click(object sender, EventArgs e)
        {
            textBoxSenhaLogin.UseSystemPasswordChar = false;
        }

        public void AbrirFormFilho(Form formFilho)
        {
            this.formFilho = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            PainelFormFilho.Controls.Add(formFilho);
            PainelFormFilho.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();

        }

        private void BtnEfetuarLogin_Click(object sender, EventArgs e)
        {
            //Abre a conex�o com o banco de dados e valida o login
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();

            usuario.Email = textBoxLoginEmail.Text;
            usuario.Senha = textBoxSenhaLogin.Text;

            var retorno = db.ValidarLogin(usuario.Email, usuario.Senha, true);
            db.Desconectar();
            //Fim da valida��o do login - necess�rio fechar o reader pra poder abrir um novo se n�o d� erro


            //In�cio da valida��o do usu�rio logado (Busca o nome e se � titular)
            db.Conectar(); 

            usuario.EhTitular = db.BuscarUsuarioLogadoEhTitular(usuario);
            usuario.Nome = db.BuscarNomeUsuarioLogado(usuario);

            string nomeUsuarioLogado = usuario.Nome;
            bool usuarioEhTitular = usuario.EhTitular;

            if (!retorno)
            {
                MessageBox.Show("Usu�rio ou senha inv�lidos. Tente novamente!");
            }
            else
            {
                MessageBox.Show("Login efetuado com sucesso!");
                //Instancia a pr�xima tela e passa o nome do usu�rio logado e se � titular para ela
                var telaPrincipal = new TelaPrincipal(nomeUsuarioLogado, usuarioEhTitular);
                telaPrincipal.Show();
                this.Hide();

            }
        }
    }
}