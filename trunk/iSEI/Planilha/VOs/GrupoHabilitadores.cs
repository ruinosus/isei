using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    public class GrupoHabilitadores
    {
        public string nome { get; set; }
        public int valor { get; set; }
        public string descricao { get; set; }

        public Habilitador primeiroHabilitador { get; set; }
        public Habilitador segundoHabilitador { get; set; }
        public Habilitador terceiroHabilitador { get; set; }
    }
}
