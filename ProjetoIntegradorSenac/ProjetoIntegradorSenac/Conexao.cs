﻿using System.Data.SqlClient;

namespace ProjetoIntegradorSenac
{
    public class Conexao
    {
        public SqlConnection conn = new SqlConnection("Persist Security Info=False;User ID=bernardo;Password=bernardo30!;Initial Catalog=db_bernardo;Data Source=dbaulabanco.ce9eq7mml3ie.sa-east-1.rds.amazonaws.com");
        public void Conectar()
        {
            conn.Open();
        }
        public void Desconectar()
        {
            conn.Close();
        }
        public bool BuscarUsuario(string Email, string Senha, bool EhTitular)
        {
            string sql = $"SELECT * FROM UsuarioPI WHERE email = '{Email}' and senha = '{Senha}' and ehTitular = '{EhTitular}'";
            SqlCommand comando = new SqlCommand(sql, conn);

            var retorno = comando.ExecuteReader();

            if (retorno.Read())
                return true;

            return false;
        }
        public void CadastrarUsuario(Usuario usuario)
        {
            string sql = $"INSERT INTO UsuarioPI (nome, senha, email, cpf, genero, dataNascimento, ehTitular) VALUES ('{usuario.Nome}', '{usuario.Senha}', '{usuario.Email}', '{usuario.Cpf}', '{usuario.Genero}', '{usuario.DataNascimento}', '{usuario.EhTitular}')";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.ExecuteNonQuery();
        }
        public int BuscarIdTitular(Usuario usuario)
        {
            string sql = $"SELECT id FROM UsuarioPI WHERE cpf = '{usuario.Cpf}'";
            SqlCommand comando = new SqlCommand(sql, conn);
            usuario.IdUsuario = Convert.ToInt32(comando.ExecuteScalar());
            return usuario.IdUsuario;

        }
        public void CadastrarEnderecoUsuario(Endereco endereco,Usuario usuario) {
            string sql = $"INSERT INTO EnderecoPI ( cep, bairro, rua, numero, complemento, idUsuario) " +
                $"VALUES ('{endereco.Cep}', '{endereco.Bairro}', '{endereco.Rua}', '{endereco.Numero}', '{endereco.Complemento}', '{usuario.IdUsuario}')";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.ExecuteNonQuery();
        }

    }
}
