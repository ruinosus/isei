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
    public partial class Atributo : UserControl
    {
        private string nomeAtributo;

        public string NomeAtributo
        {
            get { return nomeAtributo; }
            set
            {
                lblAtributo.Text = value;
                nomeAtributo = value;
            }
        }

        private int valor = 1;

        public int Valor
        {
            get { return valor; }
            set
            {
                valor = value;
                CarregarNivel(value);
            }
        }

        public void CarregarNivel(int valor)
        {
            switch (valor)
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

        public Atributo()
        {
            InitializeComponent();   
            CarregarNivel(valor);
            NomeAtributo = "Atributo";                     
        }

        public Atributo(int i)
        {
            InitializeComponent();
            this.valor = i;
            CarregarNivel(valor);
            NomeAtributo = "Atributo";            
        }

        private void Atributo_Load(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            CarregarNivel(1);
            Valor = 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            CarregarNivel(2);
            Valor = 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            CarregarNivel(3);
            Valor = 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            CarregarNivel(4);
            Valor = 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            CarregarNivel(5);
            Valor = 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            CarregarNivel(6);
            Valor = 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            CarregarNivel(7);
            Valor = 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            CarregarNivel(8);
            Valor = 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            CarregarNivel(9);
            Valor = 9;
        }

        private void b10_Click(object sender, EventArgs e)
        {
            CarregarNivel(10);
            Valor = 10;
        }

        private void lblAtributo_Click(object sender, EventArgs e)
        {

        }
    }
}
