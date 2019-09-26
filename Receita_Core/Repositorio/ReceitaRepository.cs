using ApiReceita.Model;
using ApiReceita.Repository;
using Microsoft.EntityFrameworkCore;
using ReceitaCore.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receita_Core.Repository
{
    public class ReceitaRepository : RepositoryBase<Receita>
    {
        private ReceitaContext DbContext;

        public ReceitaRepository(ReceitaContext Context):base (Context)
        {
            DbContext = Context;
        }
    }
}
