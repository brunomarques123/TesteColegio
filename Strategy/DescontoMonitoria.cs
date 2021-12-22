using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DescontoMonitoria : IDesconto
    {
        public double Calcular(Matricula matricula)
        {
            return matricula.ValorMensalidade*0.08;
        }
    }
}
