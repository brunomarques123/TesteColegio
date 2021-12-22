using System;

namespace ChainOfResponsibilityPatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var matricula = new Matricula()
            {
                TemRegulares = true,
                TemEnriquecimento = true,
                TemDependencia = true
            };
            new CalculadoDeMensalidade().Calcular(matricula);

            Console.WriteLine($"Valor toral da mensalidade {matricula.ValorMensalidade}");
        }
    }
}
