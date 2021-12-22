using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DescontoAntecipado : IDesconto
    {
        public double Calcular (Matricula matricula)
        {
            return matricula.ValorMensalidade * 0.05;
        }
    }
}
