using ApiReceita.Model;
using ApiReceita.Repository;
using ReceitaCore.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receita_Core.Repository
{
    public class CategoriaRepository : RepositoryBase<Categoria>
    {
        private readonly ReceitaContext _Context;
        public CategoriaRepository(ReceitaContext Context): base(Context)
        {
            _Context = Context;
        }
    }
}
