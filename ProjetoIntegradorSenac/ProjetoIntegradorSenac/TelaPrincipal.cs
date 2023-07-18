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
            usuario.Cpf = db.BuscarCpf(idUsuario);
            usuario.DataNascimento = db.BuscarDataNascimento(idUsuario);
            usuario.Genero = db.BuscarGenero(idUsuario);

            LabelId.Text = usuario.Nome;
            LabelDataNascimento.Text = usuario.Cpf;
            LabelGenero.Text = usuario.DataNascimento;

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
    }
}
