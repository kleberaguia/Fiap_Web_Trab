using ApiReceita.Model;
using ApiReceita.Repository;
using ReceitaCore.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Receita_Core.Repository
{
    public class PapelRepository : RepositoryBase<Papel>
    {
        private readonly ReceitaContext _Context;
        public PapelRepository(ReceitaContext Context):base(Context)
        {
            _Context = Context;
        }
    }
}
