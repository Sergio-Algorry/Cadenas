using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadenas
{
    public partial class Form1 : Form
    {
        public string[] Dia = { "lunes", "martes", "miércoles" , "jueves" , "viernes" , "sábado" , "domingo"};

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string pepe = textBox1.Text;

            //label1.Text= pepe.Substring(pepe.Length-3, 2);
            //label2.Text= pepe.Length.ToString();

            string pepe = "Los días son: \r\n";

            for (int i = 0; i < Dia.Length; i++)
            {
                pepe = pepe + Dia[i] + "\r\n";
            }
            label1.Text = pepe;
        }
    }
}
