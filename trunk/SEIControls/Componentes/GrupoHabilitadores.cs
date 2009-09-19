using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEIControls
{
    public partial class GrupoHabilitadores : UserControl
    {
        private string nomeHabGenerico;

        public string NomeHabGenerico
        {
            get { return habilitadorGenerico.Nome; }
            set
            {
                habilitadorGenerico.Nome = value;
            }
        }

        private int valorHabGenerico;

        public int ValorHabGenerico
        {
            get { return habilitadorGenerico.Valor; }
            set { habilitadorGenerico.Valor = value; }
        }

        private string nomeHabilitador1;

        public string NomeHabilitador1
        {
            get { return primeiroHab.Nome; }
            set
            {
                primeiroHab.Nome = value;
            }
        }
        private string nomeHabilitador2;

        public string NomeHabilitador2
        {
            get { return segundoHab.Nome; }
            set
            {
                segundoHab.Nome = value;
            }
        }
        private string nomeHabilitador3;

        public string NomeHabilitador3
        {
            get { return terceiroHab.Nome; }
            set
            {
                terceiroHab.Nome = value;
            }
        }
        private string nomeHabilitador4;

        public string NomeHabilitador4
        {
            get { return quartoHab.Nome; }
            set
            {
                quartoHab.Nome = value;
            }
        }
        private string nomeHabilitador5;

        public string NomeHabilitador5
        {
            get { return quintoHab.Nome; }
            set
            {
                quintoHab.Nome = value;
            }
        }

        private int valorHabilitador1;

        public int ValorHabilitador1
        {
            get { return primeiroHab.Valor; }
            set { primeiroHab.Valor = value; }
        }
        private int valorHabilitador2;

        public int ValorHabilitador2
        {
            get { return segundoHab.Valor; }
            set { segundoHab.Valor = value; }
        }
        private int valorHabilitador3;

        public int ValorHabilitador3
        {
            get { return terceiroHab.Valor; }
            set { terceiroHab.Valor = value; }
        }
        private int valorHabilitador4;

        public int ValorHabilitador4
        {
            get { return quartoHab.Valor; }
            set { quartoHab.Valor = value; }
        }
        private int valorHabilitador5;

        public int ValorHabilitador5
        {
            get { return quintoHab.Valor; }
            set { quintoHab.Valor = value; }
        }

        public GrupoHabilitadores()
        {
            InitializeComponent();
            nomeHabGenerico = "Habilitador Genérico";
        }

        private void GrupoHabilitadores_Load(object sender, EventArgs e)
        {

        }
    }
}
