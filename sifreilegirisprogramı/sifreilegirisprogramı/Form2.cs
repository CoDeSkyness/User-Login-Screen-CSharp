using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreilegirisprogramı
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double not1, not2, not3, ort;

            not1 = Convert.ToDouble (textBox1.Text);
            not2 = Convert.ToDouble(textBox2.Text);
            not3 = Convert.ToDouble(textBox3.Text);

            ort = (not1 + not2 + not3) / 3;

            label4.Text = ort.ToString();

            if (ort == 0 & ort == 50)
            {
                label4.Text = "1";
                label6.Text = ort.ToString();
            }   
            else if (ort >= 50 & ort == 55)
            {
                label4.Text = "2";
                label6.Text = ort.ToString();
            }
            else if (ort >= 55 & ort == 70)
            {
                label4.Text = "3";
                label6.Text = ort.ToString();
            }
            else if (ort >= 70 & ort == 85)
            {
                label4.Text = "4";
                label6.Text = ort.ToString();
            }
            else if (ort >= 85 & ort <= 100)
            {
                label4.Text = "5";
                label6.Text = ort.ToString();
            }






        }
    }
}
