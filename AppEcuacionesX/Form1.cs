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
            double a, b, c, x1,x2 ;
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            string msg1 = "", msg2 = "";
            //LLAMA LA FUNCION QUE CALCULA X1
            x1 = AppEcuaciones.ecuacion1.x1(a, b, c, out msg1);
            //LLAMA LA FUNCION QUE CALCULA X2
            x2 = AppEcuaciones.ecuacion1.x2(a, b, c, out msg2);
            if(msg1.Length == 0)
            {
                this.txtX1.Text = x1.ToString("0.00");
            }
            else
            {
                this.txtX1.Text = msg1;
            }

            if(msg2.Length == 0)
            {
                this.txtX2.Text = x2.ToString("0.00");
            }
            else
            {
                this.txtX2.Text = msg2;
            }
            this.txtX1.Text= x1.ToString();
            this.txtX2.Text = x2.ToString();


        }

        private void btnSALIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            this.txtX1.Text = "";
            this.txtX2.Text = "";
            this.txtA.Focus();
        }
    }
}
