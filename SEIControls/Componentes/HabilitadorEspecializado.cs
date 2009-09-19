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
    public partial class HabilitadorEspecializado : UserControl
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set
            {
                lblPrimeiroHab.Text = value;
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

        public void CarregarNivel(int valor)
        {
            switch (valor)
            {
                case 1:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
                case 2:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    break;

                case 3:
                    nivel1.Image = SEIControls.Properties.Resources.marcado;
                    nivel2.Image = SEIControls.Properties.Resources.marcado;
                    nivel3.Image = SEIControls.Properties.Resources.marcado;
                    break;

                default:
                    nivel1.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel2.Image = SEIControls.Properties.Resources.desmarcado;
                    nivel3.Image = SEIControls.Properties.Resources.desmarcado;
                    break;
            }
        }

        public HabilitadorEspecializado()
        {
            InitializeComponent();
            nome = "Habilitador Espec.";
        }

        private void HabilitadorEspecializado_Load(object sender, EventArgs e)
        {

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

        private void panel1_Click(object sender, EventArgs e)
        {
            CarregarNivel(0);
            valor = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            CarregarNivel(0);
            valor = 0;
        }

        private void lblPrimeiroHab_Click(object sender, EventArgs e)
        {
            CarregarNivel(0);
            valor = 0;
        }
    }
}
