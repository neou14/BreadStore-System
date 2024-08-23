using BreadStore.Classes;
using Guna.UI2.WinForms;
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
    public partial class BreadStoreMainForm : Form
    {
        private int click = 0;
        private Boolean ShowpanelCate=false;
        private Boolean Showpanelreport = false;
        public BreadStoreMainForm()
        {
            InitializeComponent();
        }
        private void MenuChange(Boolean showPanel, Guna2Button btnMenuDrop, Guna2Panel subMenuPanel,int StartH,int EndH)
        {
            //MessageBox.Show(click+"");
            click += 1;
            showPanel = !showPanel;
            tooglePanel(showPanel, subMenuPanel, StartH, EndH);
            if (click == 1)
            {
                btnMenuDrop.FillColor = Color.Linen;
                btnMenuDrop.ForeColor = Color.DarkGray;
                btnMenuDrop.CustomImages.Image = Properties.Resources.Collapse_Arrow;
                btn_store.Checked = false;
                btnMenuReport.Checked = false;
                btnMenuAbout.Checked = false;
                btnMenuSetting.Checked = false;
            }
            else
            {
                click = 0;
                CloseSubCategory(ShowpanelCate,btnSubBreadCate,
                  btnsubCakeCate, btnMenuCategory,PanelSubMenuCategory);
                CloseSubReport(Showpanelreport, btnDaySubRepo, btnWeekSubRep, btnMonthSubRep, btnMenuReport, PanelSubMEnuReport);
                btn_store.Checked = true;
            }
        }
        private void CloseSubReport(Boolean showPanel, Guna2Button btnSubMenu1, Guna2Button btnSubMenu2, Guna2Button btnSubMenu3, Guna2Button btnMenuDown, Guna2Panel paneSubMenu)
        {
            click = 0;
            showPanel = false;
            btnSubMenu1.Checked = false;
            btnSubMenu2.Checked = false;
            btnSubMenu3.Checked = false;
            btnMenuDown.FillColor = Color.DarkOrange;
            btnMenuDown.ForeColor = Color.WhiteSmoke;
            btnMenuDown.CustomImages.Image = Properties.Resources.Expand_Arrow1;
            paneSubMenu.Height = 0;
            btnMenuDown.Checked = false;
        }
        private void CloseSubCategory(Boolean showPanel, Guna2Button btnSubMenu1, Guna2Button btnSubMenu2, Guna2Button btnMenuDown, Guna2Panel paneSubMenu)
        {
            click = 0;
            showPanel = false;
            btnSubMenu1.Checked = false;
            btnSubMenu2.Checked = false;
            btnMenuDown.FillColor = Color.DarkOrange;
            btnMenuDown.ForeColor = Color.WhiteSmoke;
            btnMenuDown.CustomImages.Image = Properties.Resources.Expand_Arrow1;
            paneSubMenu.Height = 0;
            btnMenuDown.Checked = false;
        }
        private void tooglePanel(Boolean showpanel, Guna2Panel Subpanelmenu, int startH, int EndH)
        {
            if (showpanel)
            {
                Subpanelmenu.Height= startH;
            }
            else
            {
                Subpanelmenu.Height= EndH;
            }
        }
        private void BreadStoreMainForm_Load(object sender, EventArgs e)
        {
            user_label.Text = Mainclass.USER;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMenuAllProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
        private void btnMenuCategory_Click(object sender, EventArgs e)
        {
            MenuChange(ShowpanelCate,btnMenuCategory,PanelSubMenuCategory,86,0);
            
        }

        private void btnMenuStore_Click(object sender, EventArgs e)
        {
            //CloseSub(ShowpanelCate,btnSubBreadCate,btnsubCakeCate,btnSubIce_creamcate,
              //  btnSubDrinkcate,btnMenuCategory,PanelSubMenuCategory);
            //CloseSub(Showpanelreport, btnDaySubRepo, btnWeekSubRep, btnMonthSubRep,
              //  btnMonthSubRep, btnMenuReport, PanelSubMEnuReport);

        }

        private void btnMenuReport_Click(object sender, EventArgs e)
        {
            
            MenuChange(Showpanelreport, btnMenuReport, PanelSubMEnuReport,129,0);
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            CloseSubCategory(ShowpanelCate, btnSubBreadCate, btnsubCakeCate, btnMenuCategory, PanelSubMenuCategory);
            CloseSubReport(Showpanelreport, btnDaySubRepo, btnWeekSubRep, btnMonthSubRep,btnMenuReport, PanelSubMEnuReport);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            CloseSubCategory(ShowpanelCate, btnSubBreadCate, btnsubCakeCate, btnMenuCategory, PanelSubMenuCategory);
            CloseSubReport(Showpanelreport, btnDaySubRepo, btnWeekSubRep, btnMonthSubRep, btnMenuReport, PanelSubMEnuReport);
        }

        private void btnMenuCategory_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
