using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    public class Estado
    {
        public string nome { get; set; }
        public Atributo atributoAfetado { get; set; }
        public string valor { get; set; }
        public string descricao { get; set; }
    }
}
