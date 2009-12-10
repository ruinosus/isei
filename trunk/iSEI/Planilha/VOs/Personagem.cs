using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using iSEI.Planilha.VOs;
using System.Windows.Controls;

namespace iSEI.Planilha
{
    [Serializable()]public class Personagem
    {

        public string nome { get; set; }
        public string  campanha { get; set; }
        public string jogador{ get; set; }
        public string ser { get; set; }
        public int elevacao { get; set; }
        public string estilo { get; set; }
        public string ocupacao { get; set; }
        public int vitalidade { get; set; }
        public int energiaVital { get; set; }
        public string preludio { get; set; }
        public Image foto { get; set; }
        private Saude saude { get; set; }
        private OutrasCaracteristicas outrasCaracteristicas { get; set; }

        public GrupoAtributos grupoAtributosFisicos { get; set; }
        public GrupoAtributos grupoAtributosMentais { get; set; }
        public GrupoAtributos grupoAtributosSobrenaturais { get; set; }

        public GrupoHabilitadores grupoHabilitadoresFisicos { get; set; }
        public GrupoHabilitadores grupoHabilitadoresMentais { get; set; }
        public GrupoHabilitadores grupoHabilitadoresSobrenaturais { get; set; }


        public Personagem()
        {

        }
    }
}
