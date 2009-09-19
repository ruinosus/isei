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
    public partial class AtributoSecundario : UserControl
    {
        private string nomeAtrSecundario;

        public string NomeAtributo
        {
            get { return nomeAtrSecundario; }
            set
            {
                lblAtributo.Text = value;
                nomeAtrSecundario = value;
            }
        }

        private int valor = 1;

        public int Valor
        {
            get { return valor; }
            set
            {
                valor = value;
                //CarregarNivel(value);
            }
        }

        private Atributo atrProveniente1;

        public Atributo AtrProveniente1
        {
            get { return atrProveniente1; }
            set
            {
                atrProveniente1 = value;

                CarregarNivel(atrProveniente1, atrProveniente2);
            }
        }

        private Atributo atrProveniente2;

        public Atributo AtrProveniente2
        {
            get { return atrProveniente2; }
            set
            {
                atrProveniente2 = value;
                CarregarNivel(atrProveniente1, atrProveniente2);
            }
        }

        public void CarregarNivel(Atributo atr1, Atributo atr2)
        {
            Valor = (atr1.Valor + atr2.Valor) / 2;

            switch (Valor)
            {
                case 1:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 2:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;

                case 3:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 4:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 5:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 6:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.marcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 7:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.marcado;
                    nivel7.Image = SEIControls.Properties.Resources.marcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 8:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.marcado;
                    nivel7.Image = SEIControls.Properties.Resources.marcado;
                    nivel8.Image = SEIControls.Properties.Resources.marcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 9:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.marcado;
                    nivel7.Image = SEIControls.Properties.Resources.marcado;
                    nivel8.Image = SEIControls.Properties.Resources.marcado;
                    nivel9.Image = SEIControls.Properties.Resources.marcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 10:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    nivel6.Image = SEIControls.Properties.Resources.marcado;
                    nivel7.Image = SEIControls.Properties.Resources.marcado;
                    nivel8.Image = SEIControls.Properties.Resources.marcado;
                    nivel9.Image = SEIControls.Properties.Resources.marcado;
                    nivel10.Image = SEIControls.Properties.Resources.marcado;
                    break;
                default:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel6.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel7.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel8.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel9.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel10.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
            }


        }

        public AtributoSecundario()
        {
            InitializeComponent();

            Atributo a = new Atributo(1);
            this.atrProveniente1 = a;
            this.atrProveniente2 = a;
            CarregarNivel(AtrProveniente1, AtrProveniente2);
            NomeAtributo = "lblAtributo";

        }

        private void AtributosProvenientes_Change(object sender, EventArgs e)
        {
                    
        }

        private void AtributoSecundario_Load(object sender, EventArgs e)
        {

        }

        private void lblAtributo_Click(object sender, EventArgs e)
        {

        }
    }
}
