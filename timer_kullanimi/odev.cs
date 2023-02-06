using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_kullanimi
{
    public partial class odev : Form
    {
        public odev()
        {
            InitializeComponent();
        }
        int sureSay, devir;

        private void süre_Tick(object sender, EventArgs e)
        {
            if (devir==0)
            {
                if (sureSay==2)
                {
                    btn_S.BackColor = Color.Yellow;
                }
                if (sureSay==0)
                {
                    btn_K.BackColor = Color.Black;
                    btn_S.BackColor = Color.Black;
                    btn_Y.BackColor = Color.Green;
                    sureSay = 30;
                    devir = 1;
                }
            }
            if (devir==1)
            {
                if (sureSay==2)
                {
                    btn_S.BackColor = Color.Yellow;
                }
                if (sureSay==0)
                {
                    btn_K.BackColor = Color.Red;
                    btn_S.BackColor = Color.Black;
                    btn_Y.BackColor = Color.Black;
                    sureSay=30;
                    devir = 0;
                }
            }

            btn_sayac.Text = sureSay.ToString();
            sureSay = sureSay - 1;
        }

        private void odev_Load(object sender, EventArgs e)
        {
            sureSay = 30;
            süre.Enabled = true;
            süre.Interval = 400;
            btn_K.Text = "";
            btn_S.Text = "";
            btn_Y.Text = "";
            btn_sayac.Text = sureSay.ToString();
            btn_K.BackColor = Color.Red;
            btn_S.BackColor = Color.Black;
            btn_Y.BackColor = Color.Black;
            btn_sayac.BackColor = Color.LightBlue;
        }
    }
}
