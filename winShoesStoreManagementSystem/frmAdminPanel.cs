﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShoesStoreManagementSystem
{
    public partial class frmAdminPanel : Form
    {
        public frmAdminPanel()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblUsername.Text = frmLogin.username;
            lblSubject.Text = "Dashboard";
            frmAnalytics analytics = new frmAnalytics
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(analytics);
            analytics.Show();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
           lblSubject.Text = "Dashboard";
           pnlDashboard.Controls.Clear();
           frmAnalytics analytics = new frmAnalytics
           {
               TopLevel = false,
               TopMost = true,
               Dock = DockStyle.Fill
           };
           pnlDashboard.Controls.Add(analytics);
           analytics.Show();
        }

        private void btnShoesSizes_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Sizes";
            pnlDashboard.Controls.Clear();
            frmShoesSizes sizes = new frmShoesSizes
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(sizes);
            sizes.Show();
        }

        private void btnShoesColor_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Colors";
            pnlDashboard.Controls.Clear();
            frmShoesColors colors = new frmShoesColors
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(colors);
            colors.Show();
        }

        private void btnShoesStyles_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Styles";
            pnlDashboard.Controls.Clear();
            frmShoesStyles styles = new frmShoesStyles
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(styles);
            styles.Show();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Purchases";
            pnlDashboard.Controls.Clear();
            frmPurchases purchase = new frmPurchases
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(purchase);
            purchase.Show();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Sales";
            pnlDashboard.Controls.Clear();
            frmSales sales = new frmSales
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(sales);
            sales.Show();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Add Items";
            pnlDashboard.Controls.Clear();
            frmAddItems items = new frmAddItems
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(items);
            items.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Brands";
            pnlDashboard.Controls.Clear();
            frmBrands brands = new frmBrands
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(brands);
            brands.Show();
        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Bar Code";
            pnlDashboard.Controls.Clear();
            frmBarCodeGeneration barCode = new frmBarCodeGeneration
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(barCode);
            barCode.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Users";
            pnlDashboard.Controls.Clear();
            frmUsers users = new frmUsers
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(users);
            users.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}
