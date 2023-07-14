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
    public partial class FormFilhoCadastro : Form
    {
        public Form formFilho; //Formulário filho

        public FormFilhoCadastro()
        {
            InitializeComponent();
            PainelCadastroEndereco.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LabelEmail_Click(object sender, EventArgs e)
        {

        }

        private void FormFilhoCadastro_Load(object sender, EventArgs e)
        {

        }
        public void AbrirFormFilho(Form formFilho)
        {
            this.formFilho = formFilho;
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;
            PainelCadastroEndereco.Controls.Add(formFilho);
            PainelCadastroEndereco.Tag = formFilho;
            formFilho.BringToFront();
            formFilho.Show();

        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            PainelCadastroEndereco.Visible = true;
        }

        private void PainelFormFilho_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();

            db.Conectar();

            usuario.Nome = textBoxNome.Text;
            usuario.Cpf = textBoxCpf.Text;
            usuario.Genero = comboBoxGenero.SelectedItem.ToString();
            DateTime data = dateTimePicker1.Value;
            usuario.DataNascimento = data.ToString("yyyy-MM-dd");
            usuario.Email = textBoxEmail.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.EhTitular = true;

            db.CadastrarUsuario(usuario);
            usuario.IdUsuario = db.BuscarIdTitular(usuario);
        }
    }
}
