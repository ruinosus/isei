using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SEIControls.Componentes
{
    public partial class GrupoHabEditavel : UserControl
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                //lblPrimeiroHab.Text = value;
                nome = value;
            }
        }
        private int valor;

        public int Valor
        {
            get { return valor; }
            set
            {
                valor = value;
                CarregarNivel(value);
            }
        }
        
        public GrupoHabEditavel()
        {
            InitializeComponent();
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
                    break;
                case 2:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    break;

                case 3:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 4:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 5:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    nivel4.Image = SEIControls.Properties.Resources.marcado;
                    nivel5.Image = SEIControls.Properties.Resources.marcado;
                    break;

                default:
                    nivel1.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel2.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel4.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel5.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
            }
        }

        private void nivel1_Click(object sender, EventArgs e)
        {
            CarregarNivel(1);
            valor = 1;
        }

        private void nivel2_Click(object sender, EventArgs e)
        {
            CarregarNivel(2);
            valor = 2;
        }

        private void nivel3_Click(object sender, EventArgs e)
        {
            CarregarNivel(3);
            valor = 3;
        }

        private void nivel4_Click(object sender, EventArgs e)
        {
            CarregarNivel(4);
            valor = 4;
        }

        private void nivel5_Click(object sender, EventArgs e)
        {
            CarregarNivel(5);
            valor = 5;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CarregarNivel(0);
            valor = 0;
        }
    }
}
