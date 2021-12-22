using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    class Graduacao : Curso
    {
        public int Semestres { get; set; }


        public override void RegistrarDisciplina(Disciplina d)
        {
            if (Disciplinas.Count < 24)
                Disciplinas.Add(d);
        }

    }

    
}
