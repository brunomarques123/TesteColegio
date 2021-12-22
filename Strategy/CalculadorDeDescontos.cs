using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class CalculadorDeDescontos
    {   
        public double CalcularDesconto(Matricula matricula, IDesconto desconto)
        {

            return desconto.Calcular(matricula);
        }
    }
}
