using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadStore.ControlForm
{
    public partial class CustomerForm : UserControl
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String RadioGender()
        {
            string Gender;
            if (radFemale.Checked)
            {
                radmale.Checked = false;
                RadOther.Checked = false;
                Gender= "Female";
            }
            else if (radmale.Checked)
            {
                radFemale.Checked = false;
                RadOther.Checked = false;
                Gender= "Male";
            }
            else
            {
                radFemale.Checked = false;
                radmale.Checked = false;
                Gender= "Other";
            }
            return Gender;
        }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            
        }

        private void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            RadioGender();
        }

        private void radmale_CheckedChanged(object sender, EventArgs e)
        {
            RadioGender();
        }

        private void RadOther_CheckedChanged(object sender, EventArgs e)
        {
            RadioGender();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
