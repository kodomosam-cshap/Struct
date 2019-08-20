using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Struct
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string Nome;
            public string Apelido;

        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //outro modo de definir
            //estrutura_pessoa p1 = new estrutura_pessoa() { Nome = "Rodrigo", Apelido = "Sampaio" };

            estrutura_pessoa p1 = new estrutura_pessoa();
            p1.Apelido = "Sampaio";
            p1.Nome = "Rodrigo";
            Console.WriteLine("Nome: " + p1.Nome + " " + "Apelido: " + p1.Apelido);
        }
    }
}
