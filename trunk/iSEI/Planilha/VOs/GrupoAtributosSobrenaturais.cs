using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class GrupoAtributosSobrenaturais
    {
        public string nome { get; set; }

        public int valor { get; set; }

        public Atributo elo { get; set; }
        public Atributo amago { get; set; }
        public Atributo imunidade { get; set; }

    }
}
