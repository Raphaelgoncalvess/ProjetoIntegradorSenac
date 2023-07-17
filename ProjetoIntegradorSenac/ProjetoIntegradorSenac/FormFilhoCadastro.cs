﻿using System;
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
        //Método pra chamar o formulário filho dentro do formulário pai
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

        private void PainelFormFilho_Paint(object sender, PaintEventArgs e)
        {

        }

        /*Se clicar no botão continuar o painel fica visível*/
        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            PainelCadastroEndereco.Visible = true;
        }

        /*Se clicar no botão voltar o painel fica invisível*/
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            PainelCadastroEndereco.Visible = false;
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //Abre a conexão com o banco de dados
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();

            db.Conectar();

            //Cadastra o usuário conforme os dados nas entradas do forms
            usuario.Nome = textBoxNome.Text;
            usuario.Cpf = textBoxCpf.Text;
            usuario.Genero = comboBoxGenero.SelectedItem.ToString();
            DateTime data = dateTimePicker1.Value;
            usuario.DataNascimento = data.ToString("yyyy-MM-dd");
            usuario.Email = textBoxEmail.Text;
            usuario.Senha = textBoxSenha.Text;
            usuario.EhTitular = true;

            //Chama o método que realiza o INSERT no banco de dados  na tabela de Usuario
            db.CadastrarUsuario(usuario);
            /*Faz um SELECT no ID do usuário que foi cadastrado*/
            usuario.IdUsuario = db.BuscarIdTitular(usuario);

            Endereco endereco = new Endereco();

            //Cadastra o endereço conforme os dados nas entradas do forms
            endereco.Rua = textBoxRua.Text;
            endereco.Numero = int.Parse(textBoxNumero.Text);
            endereco.Bairro = textBoxBairro.Text;
            endereco.Cep = textBoxCep.Text;
            endereco.Complemento = textBoxComplemento.Text;

            //Chama o método que realiza o INSERT no banco de dados na tabela de Endereço
            db.CadastrarEnderecoUsuario(endereco, usuario);

            MessageBox.Show("Cadastro realizado com sucesso!");
            this.Close();

        }

    }
}
