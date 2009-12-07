using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class GrupoAtributosMentais
    {
        public string nome { get; set; }

        public int valor { get; set; }

        public Atributo intelecto { get; set; }
        public Atributo influencia { get; set; }
        public Atributo percepcao { get; set; }

    }
}
