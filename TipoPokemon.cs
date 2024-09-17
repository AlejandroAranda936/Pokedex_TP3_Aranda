using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entregable3
{
     class TipoPokemon
    {
       public string nombretipo;
       public string[] debilidadesx2 { get; set; }
       public string[] resistencias { get; set; }
       public string[] inmunidades { get; set; }
       public string[] efectivosx2 { get; set; }
       

        public TipoPokemon(string nombretipo,
        string[] debilidadesx2,
        string[] resistencias,
        string[] inmunidades,
        string[] efectivosx2
        ) { this.nombretipo = nombretipo;
            this.debilidadesx2 = debilidadesx2;
            this.resistencias = resistencias;
            this.inmunidades = inmunidades;
            this.efectivosx2 = efectivosx2;
        }
    }
}
