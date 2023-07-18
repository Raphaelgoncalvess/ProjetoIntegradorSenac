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
    public partial class TelaResetarSenha : Form
    {
        public TelaResetarSenha()
        {
            InitializeComponent();
        }

        private void TextBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxNovaSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void IconButtonTrocarSenha_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            Usuario usuario = new Usuario();
            usuario.Cpf = TextBoxCPF.Text;
            usuario.Senha = TextBoxNovaSenha.Text;
            db.ResetarSenha(usuario);
            MessageBox.Show("Senha alterada com sucesso!");
            db.Desconectar();
            Application.Restart();
        }
    }
}
