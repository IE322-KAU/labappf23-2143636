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
    public partial class FRMCombo : Form
    {
        public FRMCombo()
        {
            InitializeComponent();

            CmbDays.Items.Add("Sunday");
            CmbDays.Items.Add("Monday");
            CmbDays.Items.Add("Tuesday");
            CmbDays.Items.Add("Wedensday");
            CmbDays.Items.Add("Thursday");
            CmbDays.Items.Add("Friday");
            CmbDays.Items.Add("Saturday");
            CmbDays.Items.Add("Funday");
            CmbDays.Items.Add("Examday");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var Myitem = CmbDays.SelectedItem;
            if (Myitem != null)
                MessageBox.Show(Myitem.ToString());
        }

        private void CmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CmbDays.Text);
        }

        private void BtnShowSelected2_Click(object sender, EventArgs e)
        {
            string itemtext = CmbDays.GetItemText(CmbDays.SelectedItem);
            MessageBox.Show(itemtext);
        }

        private void BtnRemoveByBane_Click(object sender, EventArgs e)
        {
            CmbDays.Items.Remove(CmbDays.SelectedItem);
        }

        private void BtnRemoveByIndex_Click(object sender, EventArgs e)
        {
            CmbDays.Items.RemoveAt(1);
        }

        private void BtnRemoveLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 1)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 1);
            }
            else
            {
                MessageBox.Show("Can't remove last item");

            }
            MessageBox.Show("current number of items" + CmbDays.Items.Count);
        }

        private void BtnRemove2ndLast_Click(object sender, EventArgs e)
        {
            if (CmbDays.Items.Count >= 2)
            {
                CmbDays.Items.RemoveAt(CmbDays.Items.Count - 2);
            }
            else
            {
                MessageBox.Show("Can't remove last item");

            }
            MessageBox.Show("current number of items" + CmbDays.Items.Count);
        }
    }
}
