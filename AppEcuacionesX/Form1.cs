using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEcuacionesX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, r1,r2 ;
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            //LLAMA LA FUNCION QUE CALCULA X1
            r1 = AppEcuaciones.Ecuaciones.Ecupositiva(a, b, c);
            //LLAMA LA FUNCION QUE CALCULA X2
            r2 = AppEcuaciones.Ecuaciones.Ecunegativa(a, b, c);

            this.txtX1.Text= r1.ToString();
            this.txtX2.Text = r2.ToString();


        }
    }
}
