using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSenac
{
    public class Exame
    {
        public int IdExame { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DataEfetuado { get; set; }
        public string DataVencimento { get; set; }
        public bool EstaApto { get; set; }
        public string Situacao { get; set; }
    }
}
