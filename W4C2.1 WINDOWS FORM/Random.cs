using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4C2._1_WINDOWS_FORM
{
    public partial class FrmRandom : Form
    {
        Random x = new Random();
        public FrmRandom()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblDisplay_Load(object sender, EventArgs e)
        {

        }

        private void BtnRandomNum_Click(object sender, EventArgs e)
        {
            BtnRandomNum.Text = Convert.ToString(x.Next(1,20));
            
        }

        private void BtnGenerateRandom_Click(object sender, EventArgs e)
        {
            int r = x.Next(0 , 255);
            int g = x.Next(0, 255);
            int b = x.Next(0, 255);
            LblDisplay.ForeColor = Color.FromArgb(r, g, b);

            BtnGenerateRandom.ForeColor = Color.FromArgb(255 - r, 255 - g, 255 - b);
            BtnGenerateRandom.BackColor = Color.FromArgb(r,g,b);
            this.BackColor = Color.FromArgb(255 - r,255 - g,255 - b );
            LblRGB.Text = Convert.ToString(r) + "-" + Convert.ToString(g) + "-" + Convert.ToString(b);
        }
    }
}
