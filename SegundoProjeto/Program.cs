using System;

namespace SegundoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            var iesUTFPR = new Instituicao()
            {
                Nome = "UTFPR",
                Endereco = new Endereco()
                {
                    Rua = "Brasil",
                    Numero = "1000"
                }
            };

            var iesCC = new Instituicao()
            {
                Nome = "Casa do Codigo",
                Endereco = new Endereco()
                {
                    Bairro = "Liberdade"
                }
            };

            var dptoEnsino = new Departamento()
            {
                Nome = "Computação"
            };

            var dptoAlimentos = new Departamento()
            {
                Nome = "Alimentos"
            };

            var dptoRevisao = new Departamento()
            {
                Nome = "Revisao Escrita",
            };

            iesUTFPR.RegistarDepartamento(dptoEnsino);
            iesUTFPR.RegistarDepartamento(dptoAlimentos);

            iesCC.RegistarDepartamento(dptoRevisao);

            Console.WriteLine("UTFPR");
            for (int i = 0; i < iesUTFPR.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==> {iesUTFPR.Departamentos[i].Nome}");
            }

            Console.WriteLine("Casa do Codigo");
            for (int i = 0; i < iesCC.ObterQuantidadeDepartamentos(); i++)
            {
                Console.WriteLine($"==>{iesCC.Departamentos[i].Nome}");
            }
            Console.WriteLine("Pressione qualquer tecla para continuar");

            Console.ReadKey();

            dptoAlimentos.RegistarCurso(new Graduacao { Nome = "Tecnologia de Alimentos", CargaHoraria = 2000 });
            dptoAlimentos.RegistarCurso(new Graduacao { Nome = "Tecnologia de Alimentos", CargaHoraria = 3000 });

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Cursos no Departamento de {dptoAlimentos.Nome}");

            foreach (var curso in dptoAlimentos.Cursos)
            {
                Console.WriteLine($"==> {curso.Nome}({curso.CargaHoraria}h)");
            }
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();

            dptoAlimentos.FecharDepartamento();
            dptoAlimentos = null;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O departamento de alimentos foi fechado");
            Console.ReadKey();


            //var ctAlimentos = new Curso()
            //{ Nome = "Tecnologia em Alimentos", CargaHoraria = 2000 };

            //if (!dptoAlimentos.Cursos.Contains(ctAlimentos))
            //   dptoAlimentos.RegistarCurso(ctAlimentos);

            Console.WriteLine();
            Console.WriteLine();

            var cursoCC = new Graduacao()
            {
                Nome = "Ciencia da Computação",
                CargaHoraria = 3000
            };
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Algoritimos", CargaHoraria = 2000 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Orientação ao objeto", CargaHoraria = 1000 });
            cursoCC.RegistrarDisciplina(new Disciplina() { Nome = "Estrutura de Dados", CargaHoraria = 1000 });



            Console.WriteLine($"O Curso{cursoCC.Nome} possui {cursoCC.Disciplinas.Count} disciplinas: ");
            foreach (var d in cursoCC.Disciplinas)
            {
                Console.WriteLine($"==> {d.Nome} ({d.CargaHoraria})");
            }
            Console.ReadKey();

            var graduacao = new Graduacao() { Nome = "Curso de Graduação" };
            var latoSensu = new LatoSensu() { Nome = "Curso de latoSensu" };
            var strictoSenso = new StrictoSenso() { Nome = "Curso de strictoSenso" };


            var repositorioCursos = new RepositorioCurso();
            repositorioCursos.Gravar(graduacao);
            repositorioCursos.Gravar(latoSensu);
            repositorioCursos.Gravar(strictoSenso);


            Console.WriteLine();
            Console.WriteLine("Cursos gravados");
            foreach (var curso in repositorioCursos.ObterTodos())
            {
                Console.WriteLine($"==> {curso.Nome},{curso.CargaHoraria}({curso.GetType()})");
            }
            Console.Write("Pressione qualquer tecla para continuar");
            Console.ReadKey();


            var turma = new Turma()
            {
                CodigoTurma = "1",
                PeriodoCurso = PeriodoCursoEnum.Primeiro,
                turnoTurma = TurnoTurmaEnum.Matutino
            };


            var aluno = new Aluno()
            {
                RegistroAcademico = "1",
                Nome = "Asdrubal"
            };

           cursoCC = new Graduacao()
            {
                Nome = "Ciência da Computação",
                CargaHoraria = 3000
            };

            cursoCC.RegistrarAluno(aluno);
            cursoCC.RegistraTurma(turma);

            foreach (var d in cursoCC.Disciplinas)
            {
                try
                {
                    turma.RegistrarMatricula(new Matricula()
                    {
                        Aluno = aluno,
                        Disciplina = d
                    });
                }
                catch (Exception ex)
                {

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}