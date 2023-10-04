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
    public partial class FRMCheckbox : Form
    {


        public FRMCheckbox()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void CHCoffee_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            int a = 1;


            if (CHCoffee.Checked == true)
                msg = CHCoffee.Text;
                a = 1;
            if  (CHDonut.Checked == true)
                msg = msg + " " + CHDonut.Text;
                a = 1;
            if (CHBrownie.Checked == true)
                msg = msg + " " + CHBrownie.Text;
                a = 1;
            if (CHCoffee.Checked != true && CHDonut.Checked != true && CHBrownie.Checked == false)
                a = 0;
            if  (a == 1)
            MessageBox.Show ( msg + " selected");
            if (a == 0)
                MessageBox.Show("Nothing Selected");

                

                

        }
    }
}
