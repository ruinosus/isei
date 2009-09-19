using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace iSEI
{
    public partial class frmPlanilha : Form
    {
        private string estadoMenu;

        public frmPlanilha()
        {

            InitializeComponent();
            estadoMenu = "minimizado";
            this.Width = 1018;
            btnMenu.Text = "<";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            if (estadoMenu.Equals("minimizado"))
            {
                this.Width = 1118;
                btnMenu.Text = ">";
                estadoMenu = "maximizado";
                this.CenterToScreen();
            }
            else
            {
                this.Width = 1018;
                btnMenu.Text = "<";
                estadoMenu = "minimizado";
                this.CenterToScreen();
            }        
        
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XmlDocument docXML = new XmlDocument();
            docXML.Load("..\\..\\Planilha.xml");

            string data;
            XmlNode elementoData;

            elementoData = docXML.SelectSingleNode("/Planilha/DadosPessoais/Jogador");
            data = elementoData.InnerText;
            elementoData.InnerText = "Elbert";

            saveFileDialog1.AddExtension = true;
            saveFileDialog1.Filter = "Arquivos iSEI (*.iSEI)|*.iSEI| Arquivos XML (*.xml)|*.xml|Todos os Arquivos (*.*)|*.*";
            saveFileDialog1.DefaultExt = ".iSEI";
            saveFileDialog1.ShowDialog();
            string path = saveFileDialog1.FileName;
            docXML.Save(path);

        }

        private void button1_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;           
           
            XmlDocument docXML = new XmlDocument();
            docXML.Load("C:\\Elbert.xml");
            
            XmlNode elementoData;

            elementoData = docXML.SelectSingleNode("/Planilha/DadosPessoais/Jogador");
            txbJogador.Text = elementoData.InnerText;
        }
    }
}
