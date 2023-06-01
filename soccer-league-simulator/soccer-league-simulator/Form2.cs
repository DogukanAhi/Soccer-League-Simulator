using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fff
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
            Random random= new Random();
        int pgs = 0;
        int pfb = 0;
        int pbjk = 0;
        int pant = 0;
        int pmlt = 0;
        int ptrz = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,c,d,x,f,g;
            a=random.Next(1,5);
            b=random.Next(1,5);
            c = random.Next(1, 5);
            d= random.Next(1, 5);
            x= random.Next(1, 5);
            f=random.Next(1, 5);
            g=random.Next(1, 5);

            label7.Text=Convert.ToString(a);
            label10.Text = Convert.ToString(b);
            label8.Text = Convert.ToString(c);
            label9.Text = Convert.ToString(d);
            label11.Text = Convert.ToString(x);
            label12.Text = Convert.ToString(f);
            if (a > b)
                pgs += 3;
            if (a == b)
            {
                pfb++;
                pgs++;
            }
            if (a < b)
                pfb += 3;
            if (c>d)
                pbjk+= 3;
            if (c == d)
            {
                pbjk++;
                pant++;
            }
            if(c<d) {
                pant += 3;
            }
            if(x>f)
                   pmlt+= 3;
            if(x == f) {
                pmlt++;
                ptrz++;
            }
            if(x<f)
                ptrz+= 3;
            label21.Text= Convert.ToString(a);
            label22.Text= Convert.ToString(b);
            label23.Text= Convert.ToString(c);
            label25.Text= Convert.ToString(d);
            label26.Text= Convert.ToString(x);
            int max = 0;
            for (int i = 0; i < 6; i++)
            {
                if(pgs>max)
                       max = pgs;
                if(pfb>max)
                    max= pfb;
                if(ptrz>max)
                      max= ptrz;
                if(pmlt>max)
                    max= pmlt;
                if(pant>max)
                       max= pant;
            }
            if (max == pgs)
                MessageBox.Show("Şampiyon GALATASARAY! ");
        }
    }

}
