using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPatter
{
    public class CalculadoDeMensalidade
    {
        public void Calcular(Matricula matricula)
        {
            var acrescimoRegular = new MensalidadeRegular();

            var acrescimoEnriquecimento = new MensalidadeEnriquecimento();

            var acrescimoDependencia = new MensalidadeDependencia();

            var semAcrescimo = new MensalidadeSemAcrescimo();

            acrescimoRegular.RegistrarProximo(acrescimoEnriquecimento);

            acrescimoEnriquecimento.RegistrarProximo(acrescimoDependencia);

            acrescimoDependencia.RegistrarProximo(semAcrescimo);

            acrescimoRegular.Calcular(matricula);
        }
    }
}
