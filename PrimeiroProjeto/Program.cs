using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Instituicao instituicao = new Instituicao();

            Console.Write("Informe o nome da instituição: ");
            instituicao.Nome = Console.ReadLine();

            Console.Write("Informe o endereço da instituição: ");
            instituicao.Endereco = Console.ReadLine();

            Console.WriteLine("===============================");

            Console.WriteLine(($"Obrigado por informar os dados para a {instituicao.Nome}"));

            Console.Write("Pressione qualquer tecla para encerrar");
            Console.ReadKey();

        }
    }
}
