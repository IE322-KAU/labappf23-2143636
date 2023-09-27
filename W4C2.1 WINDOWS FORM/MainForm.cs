using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4C2._1_WINDOWS_FORM
{
    public partial class FRM : Form
    {
        int loginAttempts = 0;
         int maxLoginAttempts = 3;
        public FRM()
        {
 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (loginAttempts < maxLoginAttempts)
            {
                if (TxtUser.Text == "Abdullah" && TxtPW.Text == "1234")
                {
                    MessageBox.Show("Welcome to IE322\n" + TxtUser.Text);
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show("Invalid login. You have " + (maxLoginAttempts - loginAttempts) + " attempts left.");
                }
            }
            else
            {
                MessageBox.Show("You have exceeded the maximum login attempts.");
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
         


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TxtPW_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            FRMPICTURE frm = new FRMPICTURE();
            frm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FRMRADIO frm = new FRMRADIO();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRMCheckbox frm = new FRMCheckbox();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRMCombo frm = new FRMCombo();
            frm.ShowDialog();
        }
    }
}
