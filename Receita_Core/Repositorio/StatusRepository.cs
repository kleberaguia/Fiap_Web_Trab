using ApiReceita.Model;
using ApiReceita.Repository;
using ReceitaCore.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receita_Core.Repository
{
    public class StatusRepository : RepositoryBase<Status>
    {
        private readonly ReceitaContext _Context;

        public StatusRepository(ReceitaContext Context):base(Context)
        {
            _Context = Context;
        }
    }
}
