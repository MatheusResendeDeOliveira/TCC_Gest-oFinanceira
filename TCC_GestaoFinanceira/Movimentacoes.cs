using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC_GestaoFinanceira
{
    public class Movimentacoes
    {
        //public Movimentacoes() =>
        //    new Movimentacoes()
        //    {
        //        Salario,

        //    };

        public float Salario { get; set; }

        public float SalarioBruto { get; set; }

        public DateTime DataLancamento { get; set; }

        public TiposDeMovimentacao tiposDeMovimentacao { get; set; }

        public float Valores { get; set; }
    }
}
