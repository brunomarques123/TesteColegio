using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatter
{
    class MensalidadeSemAcrescimo : IMensalidade
    {
        public void Calcular(Matricula matricula)
        {

        }
        public void RegistrarProximo(IMensalidade proximo)
        {
        }

    }
}
