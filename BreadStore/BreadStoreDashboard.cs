using BreadStore.ControlForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreadStore
{
    public partial class BreadStoreDashboard : Form
    {
        public BreadStoreDashboard()
        {
            InitializeComponent();
        }
        private void CallUserConstrolFm(Control Con)
        {
            PanelShowMenu.Controls.Clear();
            PanelShowMenu.Controls.Add(Con);
            Con.Dock = DockStyle.Fill;
            Con.BringToFront();
        }
        private void BreadStoreDashboard_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CallUserConstrolFm(new CustomerForm());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CallUserConstrolFm(new ProductsConstrolFMcs());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            CallUserConstrolFm(new ProductDateControl());
        }

        private void btMenudash_Click(object sender, EventArgs e)
        {
            //sdsadsd
            MessageBox.Show("hello");
        }
    }
}
