using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iSEI.Planilha.VOs
{
    class OutrasCaracteristicas
    {
        private int defesaFisica;

        public int DefesaFisica
        {
            get { return defesaFisica; }
            set { defesaFisica = value; }
        }
        private int defesaMental;

        public int DefesaMental
        {
            get { return defesaMental; }
            set { defesaMental = value; }
        }
        private int subturno;

        public int Subturno
        {
            get { return subturno; }
            set { subturno = value; }
        }
        private int blindagem;

        public int Blindagem
        {
            get { return blindagem; }
            set { blindagem = value; }
        }
        private int modIniciativa;

        public int ModIniciativa
        {
            get { return modIniciativa; }
            set { modIniciativa = value; }
        }

        private int deslocamento;

        public int Deslocamento
        {
            get { return deslocamento; }
            set { deslocamento = value; }
        }
    }
}
