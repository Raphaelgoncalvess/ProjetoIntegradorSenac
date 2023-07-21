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
    public partial class CadastrarDependente : Form
    {
        private int IdUsuarioLogado;
        public CadastrarDependente(int IdUsuario)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Conexao db = new Conexao();
            db.Conectar();
            Usuario usuario = new Usuario();
            IdUsuarioLogado = IdUsuario;

            labelReceberCpf.Text = IdUsuario.ToString();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonCadastrar_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();

            db.Conectar();
            usuario.IdUsuario = int.Parse(labelReceberCpf.Text);
            usuario.IdTitular = db.BuscarIdTitular(usuario);

            usuario.Nome = textBoxNome.Text;
            usuario.Cpf = textBoxCpf.Text;
            usuario.Descricao = comboBoxParentesco.SelectedItem.ToString();
            usuario.Email = textBoxEmail.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.Genero = comboBoxGenero.SelectedItem.ToString();
            DateTime DataNascimento = dateTimePickerDataNascimento.Value;
            usuario.DataNascimento = DataNascimento.ToString("yyyy-MM-dd");
            usuario.EhTitular = false;

            if (textBoxNome.Text == "" || textBoxNome.Text == null || textBoxCpf.Text == "" || textBoxCpf.Text == null ||
               comboBoxGenero.SelectedItem == "" || comboBoxGenero.SelectedItem == null || textBoxEmail.Text == "" || textBoxEmail.Text == null ||
               textBoxSenha.Text == "" || textBoxSenha.Text == null)
            {
                MessageBox.Show("Confira os dados inseridos!\n Lembre-se de preencher os campos obrigatórios '*'.");
            }
            else
            {
                db.CadastroDependente(usuario);

                MessageBox.Show("Usuario Cadastrado com sucesso!");
                this.Close();
            }
        }

        private void CadastrarDependente_Load(object sender, EventArgs e)
        {

        }

        private void labelReceberCpf_Click(object sender, EventArgs e)
        {

        }
    }
}
