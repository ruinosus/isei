using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class Habilitador
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int valor;

        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        private Especializacao especializacao1;

        internal Especializacao Especializacao1
        {
            get { return especializacao1; }
            set { especializacao1 = value; }
        }
        private Especializacao especializacao2;

        internal Especializacao Especializacao2
        {
            get { return especializacao2; }
            set { especializacao2 = value; }
        }
        private Especializacao especializacao3;

        internal Especializacao Especializacao3
        {
            get { return especializacao3; }
            set { especializacao3 = value; }
        }
        private Especializacao especializacao4;

        internal Especializacao Especializacao4
        {
            get { return especializacao4; }
            set { especializacao4 = value; }
        }
        private Especializacao especializacao5;

        internal Especializacao Especializacao5
        {
            get { return especializacao5; }
            set { especializacao5 = value; }
        }

    }
}
