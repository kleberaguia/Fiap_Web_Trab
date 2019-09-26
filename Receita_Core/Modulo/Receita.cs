using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiReceita.Model
{
    public class Receita
    {
        public int idReceita { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public string Ingredientes { get; set; }

        public string ModoDePreparo { get; set; }

        public string Foto { get; set; }

        public string Tag { get; set; }

        public bool Status { get; set; }

        public int IdUsuario { get; set; }




    }
}
