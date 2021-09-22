using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Triangulos.PolimorfismoMVC;

namespace Triangulos
{
    public partial class Form1 : Form
    {
        private Controle Meucontrole;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meucontrole = new Controle(textBoxlado1.Text,textBoxlado2.Text,textBoxlado3.Text);
            result.Text = Meucontrole.Resposta;
        }
    }
}
