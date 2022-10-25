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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k_adi, sifre;

            k_adi = textBox1.Text;
            sifre = textBox2.Text;

            if (k_adi == "CsharpLove" & sifre == "12345") 
            {
                MessageBox.Show ("Giriş Başarılı");
                Form frm = new Form2();
                frm.Show();

            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
                textBox1.Clear();
                textBox2.Clear();

            }





        }
    }
}
