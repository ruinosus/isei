using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    public class Habilitador
    {
        public string nome { get; set; }
        public int valor { get; set; }
        public string descricao { get; set; }

        public Especializacao primeiraEspecializacao { get; set; }
        public Especializacao segundaEspecializacao { get; set; }
        public Especializacao terceiraEspecializacao { get; set; }
        public Especializacao quartaEspecializacao { get; set; }
        public Especializacao quintaEspecializacao { get; set; }
    }
}
