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
    public partial class FRMPICTURE : Form
    {
        public FRMPICTURE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BtnImagefromFile_Click(object sender, EventArgs e)
        {
            picTry1.Image = Image.FromFile("C:\\Users\\bodyg\\OneDrive\\Desktop\\IE 322\\Compute application IE 322\\Projects\\CLASS EXCERSISE\\W4\\programm.jpg");
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (radNormal.Checked) 
            { 


                picTry1.SizeMode = PictureBoxSizeMode.Normal;
                picTry2.SizeMode = PictureBoxSizeMode.Normal;

            }



        }

        private void radStretchImage_CheckedChanged(object sender, EventArgs e)
        {
            if (radStretchImage.Checked)
            {


                picTry1.SizeMode = PictureBoxSizeMode.StretchImage;
                picTry2.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        private void raAutoSize_CheckedChanged(object sender, EventArgs e)
        {
            if (raAutoSize.Checked)
            {


                picTry1.SizeMode = PictureBoxSizeMode.AutoSize;
                picTry2.SizeMode = PictureBoxSizeMode.AutoSize;
            }
                

        }

        private void radCenterImage_CheckedChanged(object sender, EventArgs e)
        {
            if (radCenterImage.Checked)
            {

                picTry1.SizeMode = PictureBoxSizeMode.CenterImage;
                picTry2.SizeMode = PictureBoxSizeMode.CenterImage;
            }

        }

        private void radZoom_CheckedChanged(object sender, EventArgs e)
        {
            if (radZoom.Checked == true)
            {

                picTry1.SizeMode = PictureBoxSizeMode.Zoom;
                picTry2.SizeMode = PictureBoxSizeMode.Zoom;
            }


        }
    }
}
