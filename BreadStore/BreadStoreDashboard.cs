using BreadStore.Classes;
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
        //Method to add Controls in Dashboard

        private void CallUserConstrolFm(Form Con)
        {
            // PanelShowMenu.Controls.Clear();
            //// PanelShowMenu.Controls.Add(Con);
            // Con.Dock = DockStyle.Fill;
            // // Con.TopLevelControl = false;
            //// PanelShowMenu.Controls.Add(Con);
            // Con.BringToFront();
            PanelShowMenu.Controls.Clear();
            Con.Dock = DockStyle.Fill;
            Con.TopLevel = false;
            PanelShowMenu.Controls.Add(Con);
            //Con.Controls.Add(Con);
            Con.Show();
        }
        private void BreadStoreDashboard_Load(object sender, EventArgs e)
        {
            user_label.Text=Mainclass.USER;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           // CallUserConstrolFm(new CustomerForm());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           // CallUserConstrolFm(new ProductsConstrolFMcs());
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //CallUserConstrolFm(new ProductDateControl());
        }

        private void btMenudash_Click(object sender, EventArgs e)
        {
            //sdsadsd
           
            CallUserConstrolFm(new frmDashboard());
        }
    }
}
