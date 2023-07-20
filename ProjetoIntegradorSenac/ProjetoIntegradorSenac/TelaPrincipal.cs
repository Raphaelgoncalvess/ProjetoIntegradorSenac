﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Printing;

namespace ProjetoIntegradorSenac
{
    public partial class TelaPrincipal : Form
    {

        //Campos
        private IconButton BtnAtual;
        private Panel PainelEsquerdo;


        //Criando variáveis para receber os dados do nome e se é titular ou não
        private string nomeLoginLogado;
        private bool ehTitularLogado;
        private int idUsuarioLogado;

        //Ao carregar a tela, instanciar as variáveis com os dados recebidos do login
        public TelaPrincipal(string nomeLogin, bool ehTitular, int idUsuario)
        {
            InitializeComponent();
            PainelEsquerdo = new Panel();
            PainelEsquerdo.Size = new Size(7, 60);
            PainelMenuLateral.Controls.Add(PainelEsquerdo);


            nomeLoginLogado = nomeLogin;
            ehTitularLogado = ehTitular;
            idUsuarioLogado = idUsuario;

            FormBorderStyle = FormBorderStyle.None;
            PainelUsuario.Visible = false;
            PainelEventos.Visible = false;
            PainelExame.Visible = false;
            PainelFatura.Visible = false;

            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            db.Conectar();


            //VALIDAÇÃO SE É TITULAR OU DEPENDENTE

            if (ehTitular == true)
            {
                BtnCadastrarDependente.Visible = true;
                BtnExcluirDependente.Visible = true;
                BtnEventos.Visible = true;
                BtnExame.Visible = true;
                BtnFatura.Visible = true;
                BtnMenuUsuario.Visible = true;
                dataGridView1.Visible = true;
                BtnRedefinirSenha.Visible = true;

                //PAINEL EXAMES
                Exame exame = new Exame();
                exame.Nome = db.BuscarNomeExame(idUsuario);
                exame.DataEfetuado = db.BuscarDataEfetuadoExame(idUsuario);
                exame.DataVencimento = db.BuscarDataVencimentoExame(idUsuario);
                exame.Situacao = db.BuscarSituacaoExame(idUsuario);

                LabelNome.Text = exame.Nome;
                LabelDataEfetuado.Text = exame.DataEfetuado;
                LabelDataVencimento.Text = exame.DataVencimento;
                LabelSituacao.Text = exame.Situacao;


                /*PAINEL FATURAS*/
                usuario.IdTitular = db.BuscarIdTitularFatura(idUsuario);
                descFatura1.Text = db.BuscarNomePrimeiraFatura(usuario);
                valorFatura1.Text = db.BuscarValorPrimeiraFatura(usuario);
                dataVencFatura1.Text = db.BuscarDataVencimentoPrimeiraFatura(usuario);
                situacaoFatura1.Text = db.BuscarSituacaoPrimeiraFatura(usuario);

                descFatura2.Text = db.BuscarNomeSegundaFatura(usuario);
                valorFatura2.Text = db.BuscarValorSegundaFatura(usuario);
                dataVencFatura2.Text = db.BuscarDataVencimentoSegundaFatura(usuario);
                situacaoFatura2.Text = db.BuscarSituacaoSegundaFatura(usuario);

                descFatura3.Text = db.BuscarNomeTerceiraFatura(usuario);
                valorFatura3.Text = db.BuscarValorTerceiraFatura(usuario);
                dataVencFatura3.Text = db.BuscarDataVencimentoTerceiraFatura(usuario);
                situacaoFatura3.Text = db.BuscarSituacaoTerceiraFatura(usuario);

            }
            else
            {
                BtnCadastrarDependente.Visible = false;
                BtnExcluirDependente.Visible = false;
                BtnEventos.Visible = true;
                BtnExame.Visible = false;
                BtnFatura.Visible = false;
                BtnMenuUsuario.Visible = true;
                dataGridView1.Visible = false;
                BtnRedefinirSenha.Visible = true;
                LblDependentes.Visible = false;
            }


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
            dataGridView1.Update();

            //PAINEL Eventos
            Evento1.Visible = false;
            Evento2.Visible = false;
            Evento3.Visible = false;
            Evento1.Text = "3";

            DataInicio1.Text = db.BuscarEventoInicio(Evento1.Text);
            DataFim1.Text = db.BuscarEventoFim(Evento1.Text);
            DataInicio2.Text = db.BuscarEventoInicio(Evento1.Text);
            DataFim2.Text = db.BuscarEventoFim(Evento1.Text);
            DataInicio3.Text = db.BuscarEventoInicio(Evento1.Text);
            DataFim3.Text = db.BuscarEventoFim(Evento1.Text);

            
        }

        //Structs botoões
        private struct CoresRgb
        {
            public static Color cor1 = Color.FromArgb(241, 120, 193);
            public static Color cor2 = Color.FromArgb(247, 83, 83);
            public static Color cor3 = Color.FromArgb(255, 255, 77);
            public static Color cor4 = Color.FromArgb(153, 255, 153);
        }

        //Métodos pra ativar e desativar botões
        private void AtivarBotao(object senderBtn, Color cor)
        {
            if (senderBtn != null)
            {
                DesativarBotao();
                BtnAtual = (IconButton)senderBtn;
                BtnAtual.BackColor = Color.FromArgb(6, 7, 55);
                BtnAtual.ForeColor = cor;
                BtnAtual.TextAlign = ContentAlignment.MiddleCenter;
                BtnAtual.IconColor = cor;
                BtnAtual.TextImageRelation = TextImageRelation.TextBeforeImage;
                BtnAtual.ImageAlign = ContentAlignment.MiddleRight;

                PainelEsquerdo.BackColor = cor;
                PainelEsquerdo.Location = new Point(0, BtnAtual.Location.Y);
                PainelEsquerdo.Visible = true;
                PainelEsquerdo.BringToFront();
                //Icone BtnAtual
                BtnHome.IconChar = BtnAtual.IconChar;
                BtnHome.IconColor = cor;
                LabelHome.Text = BtnAtual.Text;
            }
        }

        private void DesativarBotao()
        {
            if (BtnAtual != null)
            {
                BtnAtual.BackColor = Color.FromArgb(6, 7, 33);
                BtnAtual.ForeColor = Color.FromArgb(242, 242, 242);
                BtnAtual.TextAlign = ContentAlignment.MiddleRight;
                BtnAtual.IconColor = Color.FromArgb(242, 242, 242);
                BtnAtual.TextImageRelation = TextImageRelation.ImageBeforeText;
                BtnAtual.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        //Valida se é titular ou não e abre a tela de cadastro de usuário conforme sua permissão
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuUsuario_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRgb.cor1);
            PainelUsuario.Dock = DockStyle.Fill;
            PainelUsuario.Visible = true;
            PainelUsuario.BringToFront();
            PainelEventos.Visible = false;
            PainelExame.Visible = false;
            PainelFatura.Visible = false;
        }

        private void BtnEventos_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRgb.cor3);
            PainelEventos.Dock = DockStyle.Fill;
            PainelEventos.Visible = true;
            PainelEventos.BringToFront();
            PainelUsuario.Visible = false;
            PainelExame.Visible = false;
            PainelFatura.Visible = false;
        }

        private void BtnExame_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRgb.cor2);
            PainelExame.Dock = DockStyle.Fill;
            PainelExame.Visible = true;
            PainelExame.BringToFront();
            PainelUsuario.Visible = false;
            PainelEventos.Visible = false;
            PainelFatura.Visible = false;
        }

        private void BtnFatura_Click(object sender, EventArgs e)
        {
            AtivarBotao(sender, CoresRgb.cor4);
            PainelFatura.Dock = DockStyle.Fill;
            PainelFatura.Visible = true;
            PainelFatura.BringToFront();
            PainelUsuario.Visible = false;
            PainelEventos.Visible = false;
            PainelExame.Visible = false;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
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

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ResetarBtns();
            PainelUsuario.Visible = false;
            PainelExame.Visible = false;
            PainelEventos.Visible = false;
            PainelFatura.Visible = false;
 
        }
        private void ResetarBtns()
        {
            DesativarBotao();
            PainelEsquerdo.Visible = false;
            BtnHome.IconChar = IconChar.Home;
            BtnHome.IconColor = Color.FromArgb(242, 242, 242);
            LabelHome.Text = "Home";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtnConfirmarPresenca1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "3";

            db.Conectar();
            db.InserirPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença confirmada com sucesso!");
        }

        private void BtnRetirarPresenca1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "3";

            db.Conectar();
            db.RetirarPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença retirada com sucesso!");
        }

        private void BtnConfirmarPresenca2_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "4";

            db.Conectar();
            db.InserirPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença confirmada com sucesso!");
        }

        private void BtnRetirarPresenca2_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "4";

            db.Conectar();
            db.RetirarPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença retirada com sucesso!");
        }

        private void BtnConfirmarPresenca3_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "5";

            db.Conectar();
            db.RetirarPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença retirada com sucesso!");
        }

        private void BtnRetirarPresenca3_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            Usuario usuario = new Usuario();
            usuario.IdUsuario = idUsuarioLogado;
            Evento1.Text = "5";

            db.Conectar();
            db.RetirarPresencaEvento(usuario, Evento1.Text);
            MessageBox.Show("Presença retirada com sucesso!");
        }


        private void BtnCadastrarExame_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();

            db.Conectar();
            db.AtualizarDadosExame(idUsuarioLogado);
            MessageBox.Show("Exame realizado com sucesso!");
        }


        private void BtnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Mover a tela
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void PainelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void imprimirFatura1_Click(object sender, EventArgs e)
        {
            // Cria o diálogo de impressão
            PrintDialog printDialog = new PrintDialog();

            // Define o objeto PrintDocument para o diálogo
            printDialog.Document = printDocument1;

            // Exibe o diálogo de impressão e verifica se o usuário pressionou "OK"
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Define o conteúdo a ser impresso
            string texto = "Exemplo de impressão no WinForms.";

            // Define a fonte e a posição do texto
            Font fonte = new Font("Arial", 12);
            PointF ponto = new PointF(100, 100);

            // Desenha o texto na página
            e.Graphics.DrawString(texto, fonte, Brushes.Black, ponto);
        }

        private void imprimirFatura2_Click(object sender, EventArgs e)
        {
            // Cria o diálogo de impressão
            PrintDialog printDialog = new PrintDialog();

            // Define o objeto PrintDocument para o diálogo
            printDialog.Document = printDocument1;

            // Exibe o diálogo de impressão e verifica se o usuário pressionou "OK"
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                printDocument1.Print();
            }
        }

        private void imprimirFatura3_Click(object sender, EventArgs e)
        {
            // Cria o diálogo de impressão
            PrintDialog printDialog = new PrintDialog();

            // Define o objeto PrintDocument para o diálogo
            printDialog.Document = printDocument1;

            // Exibe o diálogo de impressão e verifica se o usuário pressionou "OK"
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Inicia o processo de impressão
                printDocument1.Print();
            }
        }

        private void confirmarPgto1_Click(object sender, EventArgs e)
        {
            Conexao db = new Conexao();
            db.Conectar();
            Usuario usuario = new Usuario();

            usuario.IdTitular = db.BuscarIdTitularFatura(idUsuarioLogado);

            db.PagarPrimeiraFatura(usuario.IdTitular);
            MessageBox.Show("Pagamento realizado com sucesso!");
            this.Refresh();
        }

        private void confirmarPgto2_Click(object sender, EventArgs e)
        {
            if (situacaoFatura1.Text == "Pendente")
            {
                MessageBox.Show("A fatura anterior ainda não foi paga!");
            }
            else
            {
                Conexao db = new Conexao();
                db.Conectar();
                Usuario usuario = new Usuario();

                usuario.IdTitular = db.BuscarIdTitularFatura(idUsuarioLogado);

                db.PagarSegundaFatura(usuario.IdTitular);
                MessageBox.Show("Pagamento realizado com sucesso!");

            }
            this.Refresh();
        }

        private void confirmarPgto3_Click(object sender, EventArgs e)
        {
            if (situacaoFatura2.Text == "Pendente")
            {
                MessageBox.Show("A fatura anterior ainda não foi paga!");
            }
            else
            {
                Conexao db = new Conexao();
                db.Conectar();
                Usuario usuario = new Usuario();

                usuario.IdTitular = db.BuscarIdTitularFatura(idUsuarioLogado);

                db.PagarSegundaFatura(usuario.IdTitular);
                MessageBox.Show("Pagamento realizado com sucesso!");

            }
            this.Refresh();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ResetarBtns();
            PainelUsuario.Visible = false;
            PainelExame.Visible = false;
            PainelEventos.Visible = false;
            PainelFatura.Visible = false;
        }
    }
}
