using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorSenac
{
    public class Mensalidade
    {
        public int IdMensalidade { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string DataEmissao { get; set; }
        public string DataVencimento { get; set; }
        public bool taPaga { get; set; }
    }
}
