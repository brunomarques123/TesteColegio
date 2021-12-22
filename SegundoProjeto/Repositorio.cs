﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    public interface IRepositorio<T>
    {
        T ObterPorId(string id);
        IEnumerable<T> ObterTodos();
        void Gravar(T objeto);
        void Remover(T objeto);
    }
}
