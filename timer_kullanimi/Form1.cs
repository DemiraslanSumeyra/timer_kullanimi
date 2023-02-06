using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void btn_baslat_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac < 28)
                this.BackColor = Color.Red;
            else if (sayac > 27 && sayac < 30)
                this.BackColor = Color.Yellow;
            else
                this.BackColor = Color.Green;
            if (sayac >60) sayac = 0;

            //if (sayac == 2)
            //{
            //    this.BackColor = Color.Red;
            //}
            //if (sayac==4)
            //{
            //    this.BackColor = Color.Blue;
            //    sayac = 0;
            //}

        }

        // 3 lambalı trafik lambası animasyonu 
        // 0-30sn arası kırmızı, 30-40sn arası sarı, 40-70 arası yeşil 
    }
}
