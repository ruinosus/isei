using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class HabilitadorEspecializado
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
            set
            {
                if ((value > 0) && (value <= 3))
                {
                    valor = value;
                }
                else { valor = 0; }
            }
        }

        public HabilitadorEspecializado(string nome, int valor)
        {
            this.nome = nome;
            this.Valor = valor;
        }
    }
}
