using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class GrupoAtributo
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private Atributo atributo1;

        internal Atributo Atributo1
        {
            get { return atributo1; }
            set { atributo1 = value; }
        }
        private Atributo atributo2;

        internal Atributo Atributo2
        {
            get { return atributo2; }
            set { atributo2 = value; }
        }
        private Atributo atributo3;

        internal Atributo Atributo3
        {
            get { return atributo3; }
            set { atributo3 = value; }
        }

        public int valorTotalAtributos(Atributo atr1, Atributo atr2, Atributo atr3)
        { 
            return atr1.Valor + atr2.Valor + atr3.Valor;
        }

        public GrupoAtributo()
        { 
        
        }

        public GrupoAtributo(string nome, Atributo atr1, Atributo atr2, Atributo atr3)
        {
            this.nome = nome;
            this.atributo1 = atr1;
            this.atributo2 = atr2;
            this.atributo3 = atr3;
        }
    }
}
