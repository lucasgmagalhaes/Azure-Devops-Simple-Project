using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CalcularSomar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void btnsomar_Click(object sender, EventArgs e)
        {
            int numero1;
            int numero2;

            if (int.TryParse(txtn1.Text, out numero1) && int.TryParse(txtn2.Text, out numero2))
            {
                txtresultado.Text = CalcularSomar(numero1, numero2).ToString();
            }
            else
            {
                txtresultado.Text = "";
            }
        }
    }
}
