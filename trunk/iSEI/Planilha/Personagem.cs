using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using iSEI.Planilha.VOs;

namespace iSEI.Planilha
{
    class Personagem
    {
      
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string campanha;

        public string Campanha
        {
            get { return campanha; }
            set { campanha = value; }
        }
        private string jogador;

        public string Jogador
        {
            get { return jogador; }
            set { jogador = value; }
        }

        private string ser;

        public string Ser
        {
            get { return ser; }
            set { ser = value; }
        }

        private int elevacao;

        public int Elevacao
        {
            get { return elevacao; }
            set
            {
                if ((value > 0) && (value <= 10))
                {
                    elevacao = value;
                }
                else { elevacao = 1; }
            }
        }

        private string estilo;

        public string Estilo
        {
            get { return estilo; }
            set { estilo = value; }
        }

        private string ocupacao;

        public string Ocupacao
        {
            get { return ocupacao; }
            set { ocupacao = value; }
        }

        private int vitalidade;

        public int Vitalidade
        {
            get { return vitalidade; }
            set { vitalidade = value; }
        }
        private int energiaVital;

        public int EnergiaVital
        {
            get { return energiaVital; }
            set { energiaVital = value; }
        }

        private GrupoAtributos atributosFisicos;

        internal GrupoAtributos AtributosFisicos
        {
            get { return atributosFisicos; }
            set { atributosFisicos = value; }
        }
        private GrupoAtributos atributosMentais;

        internal GrupoAtributos AtributosMentais
        {
            get { return atributosMentais; }
            set { atributosMentais = value; }
        }
        private GrupoAtributos atributosSobrenaturais;

        internal GrupoAtributos AtributosSobrenaturais
        {
            get { return atributosSobrenaturais; }
            set { atributosSobrenaturais = value; }
        }

        private Habilitador habilitadoresFisicos;

        internal Habilitador HabilitadoresFisicos
        {
            get { return habilitadoresFisicos; }
            set { habilitadoresFisicos = value; }
        }
        private Habilitador habilitadoresMentais;

        internal Habilitador HabilitadoresMentais
        {
            get { return habilitadoresMentais; }
            set { habilitadoresMentais = value; }
        }
        private Habilitador habilitadoresSobrenaturais;

        internal Habilitador HabilitadoresSobrenaturais
        {
            get { return habilitadoresSobrenaturais; }
            set { habilitadoresSobrenaturais = value; }
        }

        private Saude saude;

        internal Saude Saude
        {
            get { return saude; }
            set { saude = value; }
        }

        private OutrasCaracteristicas outrasCaracteristicas;

        internal OutrasCaracteristicas OutrasCaracteristicas
        {
            get { return outrasCaracteristicas; }
            set { outrasCaracteristicas = value; }
        }

        public Personagem()
        {

        }
    }
}
