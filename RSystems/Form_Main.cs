using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;

namespace RSystems
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton_Exit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Proqramdan çıxmağa razısınızmı ?", "Diqqət", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Etdiyiniz dəyişikliklər yadda qalmayacaq , davam etməyə razısınızmı?", "Diqqət !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
                (arg.Page as XtraTabPage).PageVisible = false;
            }          
        }

        private void navBarItem_Sale_Display_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {           
            Form_Sale_display Frm_Sale_display = new Form_Sale_display();
            Frm_Sale_display.ShowDialog();
        }

        private void navBarItem_Sale_Reports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Sale_Reports.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Sale_Reports;
            label_Module_Name.Text = xtraTabPage_Sale_Reports.Text;
        }

        private void navBarItem_Customer_Card_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Customer_Card.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Customer_Card;           
            label_Module_Name.Text = xtraTabPage_Customer_Card.Text;
        }

        private void navBarItem_Customer_Reports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Customer_Reports.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Customer_Reports;
            label_Module_Name.Text = xtraTabPage_Customer_Reports.Text;
        }

        private void navBarItem_Stock_Card_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Stock_Card.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Stock_Card;
            label_Module_Name.Text = xtraTabPage_Stock_Card.Text;
        }

        private void navBarItem_Stock_Reports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Stock_Reports.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Stock_Reports;
            label_Module_Name.Text = xtraTabPage_Stock_Reports.Text;
        }

        private void navBarItem_Document_Type_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Document_Type.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Document_Type;
            label_Module_Name.Text = xtraTabPage_Document_Type.Text;
        }

        private void navBarItem_Document_Reports_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Document_Reports.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Document_Reports;
            label_Module_Name.Text = xtraTabPage_Document_Reports.Text;
        }

        private void navBarItem_Extra_report_1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Extra_report_1.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Extra_report_1;
            label_Module_Name.Text = xtraTabPage_Extra_report_1.Text;
        }

        private void navBarItem_Extra_report_2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Extra_report_2.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Extra_report_2;
            label_Module_Name.Text = xtraTabPage_Extra_report_2.Text;
        }

        private void navBarItem_Extra_report_3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Extra_report_3.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Extra_report_3;
            label_Module_Name.Text = xtraTabPage_Extra_report_3.Text;
        }

        private void navBarItem_Setting_Main_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xtraTabPage_Setting_Main.PageVisible = true;
            xtraTabControl_Main.SelectedTabPage = xtraTabPage_Setting_Main;
            label_Module_Name.Text = xtraTabPage_Setting_Main.Text;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelControl_bottom.Text = labelControl_bottom.Text.Substring(1) + labelControl_bottom.Text.Substring(0, 1);
        }
    }
}
