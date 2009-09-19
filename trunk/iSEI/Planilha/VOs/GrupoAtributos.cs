using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class GrupoAtributos
    {
        private string nome;
        private Atributo atr1;

        internal Atributo Atr1
        {
            get { return atr1; }
            set { atr1 = value; }
        }
        private Atributo atr2;

        internal Atributo Atr2
        {
            get { return atr2; }
            set { atr2 = value; }
        }
        private Atributo atr3;

        internal Atributo Atr3
        {
            get { return atr3; }
            set { atr3 = value; }
        }

    }
}
