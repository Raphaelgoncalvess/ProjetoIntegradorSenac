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
    public partial class TelaPrincipal : Form
    {
        //Criando variáveis para receber os dados do nome e se é titular ou não
        private string nomeLoginLogado;
        private bool ehTitularLogado;
        private int idUsuarioLogado;

        //Ao carregar a tela, instanciar as variáveis com os dados recebidos do login
        public TelaPrincipal(string nomeLogin, bool ehTitular, int idUsuario)
        {
            InitializeComponent();
            nomeLoginLogado = nomeLogin;
            ehTitularLogado = ehTitular;
            idUsuarioLogado = idUsuario;

            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            db.Conectar();

            usuario.Nome = db.BuscarUsuario(idUsuario);
            usuario.Email = db.BuscarEmail(idUsuario);
            usuario.Cpf = db.BuscarCpf(idUsuario);
            usuario.DataNascimento = db.BuscarDataNascimento(idUsuario);
            usuario.Genero = db.BuscarGenero(idUsuario);

            LabelNomeUsuario.Text = usuario.Nome;
            LabelEmail.Text = usuario.Email;
            LabelCpf.Text = usuario.Cpf;
            LabelDataNascimento.Text = usuario.DataNascimento;
            LabelGenero.Text = usuario.Genero;
            LabelIdUsuario.Text = idUsuario.ToString();

            db.Desconectar();
            db.Conectar();

            var listaDependentes = db.BuscarDependentes(idUsuario);
            dataGridView1.DataSource = listaDependentes;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Valida se é titular ou não e abre a tela de cadastro de usuário conforme sua permissão
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuUsuario_Click(object sender, EventArgs e)
        {
            PainelUsuario.Visible = true;
            PainelUsuario.BringToFront();
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {

        }

        private void BtnExame_Click(object sender, EventArgs e)
        {

        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {

        }

        private void LabelIdUsuario_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnRedefinirSenha_Click(object sender, EventArgs e)
        {
            TelaResetarSenha telaResetarSenha = new TelaResetarSenha();
            telaResetarSenha.ShowDialog();
        }

        private void BtnCadastrarDependente_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            CadastrarDependente telaCadastrarDependente = new CadastrarDependente(idUsuarioLogado);
            telaCadastrarDependente.ShowDialog();

        }

        private void BtnExcluirDependente_Click(object sender, EventArgs e)
        {
            DeletarDependente telaDeletarDependente = new DeletarDependente();
            telaDeletarDependente.ShowDialog();
        }
    }
}
