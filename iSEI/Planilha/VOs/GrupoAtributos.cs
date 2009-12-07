using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Documents;

namespace iSEI.Planilha.VOs
{
    public class GrupoAtributos
    {
        public string nome { get; set; }
        public int valor { get; set; }
        public string descricao { get; set; }

        public Atributo primeiroAtributo { get; set; }
        public Atributo segundoAtributo { get; set; }
        public Atributo terceiroAtributo { get; set; }

        public GrupoAtributos()
        {         
        }
    }
}
