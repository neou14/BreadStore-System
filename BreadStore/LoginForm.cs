using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BreadStore.Classes;
using System.Diagnostics.Eventing.Reader;

namespace BreadStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text.Length == 0)
            {
                MessageBox.Show("Please input username");
            }
            
             else if ( txt_password.Text.Length == 0)
            {
                MessageBox.Show("Please input Password");
            }
            else
            {
                if (Mainclass.InvalidUser(txt_username.Text, txt_password.Text) == false)
                {
                    guna2MessageDialog1.Show("Invalid username or password");
                    return;
                }
                else
                {
                    this.Hide();
                    BreadStoreDashboard form = new BreadStoreDashboard();
                    form.Show();
                }
                
            }
            //BreadStoreDashboard breadStoreDashboard = new BreadStoreDashboard();
            //this.Hide();
            //breadStoreDashboard.ShowDialog();
            //this.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
