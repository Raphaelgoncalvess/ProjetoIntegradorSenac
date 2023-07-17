﻿namespace ProjetoIntegradorSenac
{
    public class Usuario
    {
        /*Dados Usuário*/
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Genero { get; set; }
        public string DataNascimento { get; set; }
        public bool EhTitular { get; set; }
        public int IdUsuario { get; set; }

        /*Dados tabela titular*/
        public int IdTitular { get; set; }

        /*Dados tabela Dependente*/
        public int IdDependente { get; set; }
    }
}
