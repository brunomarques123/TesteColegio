using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    class Turma
    {
        private Curso _curso;

        public string CodigoTurma { get; set; }
        public PeriodoCursoEnum PeriodoCurso { get; set; }
        public TurnoTurmaEnum turnoTurma { get; set; }
        public Curso curso { get { return _curso; } }
        public HashSet<Matricula> Matriculas { get; } = new HashSet<Matricula>();



        public void RegistrarMatricula(Matricula m)
        {
            if (this.Matriculas.Count > 2)
                throw new Exception("Turma ja nao dispoe de vagas");
            this.Matriculas.Add(m);
            m.Turma = this;
        }


        public void RegistrarCurso(Curso curso)
        {
            this._curso = curso;
        }


        public override bool Equals(object obj)
        {
            if (obj is Turma)
            {
                Turma t = obj as Turma;
                return this.CodigoTurma.Equals(t.CodigoTurma);

            }
            return false;
        }

        public override int GetHashCode()
        {
            return (11 + this.CodigoTurma == null ? 0 : this.CodigoTurma.GetHashCode());        }


    }
}
