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

        //Ao carregar a tela, instanciar as variáveis com os dados recebidos do login
        public TelaPrincipal(string nomeLogin, bool ehTitular)
        {
            InitializeComponent();
            nomeLoginLogado = nomeLogin;
            ehTitularLogado = ehTitular;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Valida se é titular ou não e abre a tela de cadastro de usuário conforme sua permissão
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = nomeLoginLogado;
            if (ehTitularLogado == true)
            {
                iconButton1.Visible = true;
                iconButton2.Visible = true;
            }
            else
            {
                iconButton1.Visible = true;
                iconButton2.Visible = false;
            }
        }
    }
}
