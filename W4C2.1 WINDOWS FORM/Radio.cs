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
    public partial class FRMRADIO : Form
    {
        public FRMRADIO()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RDORed1.Checked = false; RDORed2.Checked = false;
            RDOYellow1.Checked = false ; RDOYellow2.Checked = false;
            RDOGreen1.Checked = false ; RDOGreen2.Checked = false;
            RDOBlue1.Checked = false ; RDOBlue2.Checked = false;
            
                
            RDORed1.ForeColor = Color.Black;
            RDORed2.ForeColor = Color.Black;
            RDOBlue1.ForeColor = Color.Black;
            RDOBlue2.ForeColor = Color.Black;
            RDOGreen1.ForeColor = Color.Black;
            RDOGreen2.ForeColor = Color.Black;
            RDOYellow1.ForeColor = Color.Black;
            RDOYellow2.ForeColor = Color.Black;
        }

        private void RDOBlue1_CheckedChanged(object sender, EventArgs e)
        {
            RDOBlue1.ForeColor = Color.FromName("blue");
        }

        private void RDORed1_CheckedChanged(object sender, EventArgs e)
        {
            RDORed1.ForeColor = Color.FromName("red");
        }

        private void RDOGRreen1_CheckedChanged(object sender, EventArgs e)
        {
            RDOGreen1.ForeColor = Color.FromName("green");
        }

        private void RDOYellow1_CheckedChanged(object sender, EventArgs e)
        {
            RDOYellow1.ForeColor = Color.FromName("yellow");
        }

        private void RDORed2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDORed2.Checked == true)

            RDORed2.ForeColor = Color.FromName("red");


            RDOBlue2.ForeColor = Color.Black;

            RDOGreen2.ForeColor = Color.Black;

            RDOYellow2.ForeColor = Color.Black;

        }

        private void RDOGreen2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOGreen2.Checked == true)
                RDOGreen2.ForeColor = Color.FromName("green");
            RDORed2.ForeColor = Color.Black;
            RDOBlue2.ForeColor = Color.Black;
            RDOYellow2.ForeColor = Color.Black;

        }

        private void RDOBlue2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOBlue2.Checked == true)
                RDOBlue2.ForeColor = Color.FromName("blue");
            RDORed2.ForeColor = Color.Black;
            RDOGreen2.ForeColor = Color.Black;

            RDOYellow2.ForeColor = Color.Black;

        }

        private void RDOYellow2_CheckedChanged(object sender, EventArgs e)
        {
            if (RDOYellow2.Checked == true)
            RDOYellow2.ForeColor = Color.FromName("yellow");
            RDORed2.ForeColor = Color.Black;
            RDOBlue2.ForeColor = Color.Black;
            RDOGreen2.ForeColor = Color.Black;


        }
    }
}
