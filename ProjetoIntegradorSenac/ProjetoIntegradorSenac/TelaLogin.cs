using FontAwesome.Sharp;
using System.Security.Cryptography;

namespace ProjetoIntegradorSenac
{
    public partial class TelaLogin : Form
    {

        //Campos
        public IconButton btnAtual; //Botão atual
        public Form formFilho; //Formulário filho

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
        /*Método para chamar um form dentro de um painel*/
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
            //Abre a conexão com o banco de dados e valida o login
            Conexao db = new Conexao();
            db.Conectar();

            Usuario usuario = new Usuario();

            usuario.Email = textBoxLoginEmail.Text;
            usuario.Senha = textBoxSenhaLogin.Text;

            var retorno = db.ValidarLogin(usuario.Email, usuario.Senha, true);
            db.Desconectar();
            //Fim da validação do login - necessário fechar o reader pra poder abrir um novo se não dá erro


            //Início da validação do usuário logado (Busca o nome e se é titular)
            db.Conectar(); 

            usuario.EhTitular = db.BuscarUsuarioLogadoEhTitular(usuario);
            usuario.Nome = db.BuscarNomeUsuarioLogado(usuario);

            string nomeUsuarioLogado = usuario.Nome;
            bool usuarioEhTitular = usuario.EhTitular;

            /*Se não validar o login, retorna mensagem de erro*/
            if (!retorno)
            {
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente!");
            }
            /*Se validar o login, passa para a próxima tela*/
            else
            {
                MessageBox.Show("Login efetuado com sucesso!");
                //Instancia a próxima tela e passa o nome do usuário logado e se é titular para ela
                var telaPrincipal = new TelaPrincipal(nomeUsuarioLogado, usuarioEhTitular);
                telaPrincipal.Show();
                this.Hide();

            }
        }
    }
}