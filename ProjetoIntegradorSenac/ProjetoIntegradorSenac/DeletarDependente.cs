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
    public partial class DeletarDependente : Form
    {
        public DeletarDependente()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Text = "Insira o CPF do dependente \n "
                 + "a ser deletado!";
        }

        private void iconButtonDeletar_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();

            db.Conectar();

            Usuario usuario = new Usuario();

            usuario.Cpf = textBoxCpf.Text;

            db.DeletarDependente(usuario);

            MessageBox.Show("Dependente deletado com sucesso!");

            this.Close();
        }

        private void iconButtonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
