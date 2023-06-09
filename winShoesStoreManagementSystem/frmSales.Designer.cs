﻿namespace winShoesStoreManagementSystem
{
    partial class frmSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gvSales = new Guna.UI.WinForms.GunaDataGridView();
            this.shoeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(1271, 105);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(223, 33);
            this.txtSearch.TabIndex = 35;
            this.txtSearch.Text = "Search...";
            // 
            // gvSales
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvSales.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSales.BackgroundColor = System.Drawing.Color.White;
            this.gvSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSales.ColumnHeadersHeight = 27;
            this.gvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoeId,
            this.shoeBrand,
            this.shoeCategory,
            this.shoeColor,
            this.shoeStyle,
            this.shoeSize,
            this.salePrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSales.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSales.EnableHeadersVisualStyles = false;
            this.gvSales.GridColor = System.Drawing.Color.White;
            this.gvSales.Location = new System.Drawing.Point(63, 155);
            this.gvSales.Name = "gvSales";
            this.gvSales.ReadOnly = true;
            this.gvSales.RowHeadersVisible = false;
            this.gvSales.RowHeadersWidth = 51;
            this.gvSales.RowTemplate.Height = 24;
            this.gvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSales.Size = new System.Drawing.Size(1431, 508);
            this.gvSales.TabIndex = 36;
            this.gvSales.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gvSales.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvSales.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvSales.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvSales.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvSales.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvSales.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvSales.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gvSales.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.gvSales.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvSales.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvSales.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvSales.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvSales.ThemeStyle.HeaderStyle.Height = 27;
            this.gvSales.ThemeStyle.ReadOnly = true;
            this.gvSales.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvSales.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvSales.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvSales.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvSales.ThemeStyle.RowsStyle.Height = 24;
            this.gvSales.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvSales.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // shoeId
            // 
            this.shoeId.HeaderText = "Shoe ID";
            this.shoeId.MinimumWidth = 6;
            this.shoeId.Name = "shoeId";
            this.shoeId.ReadOnly = true;
            // 
            // shoeBrand
            // 
            this.shoeBrand.HeaderText = "Shoe Brand";
            this.shoeBrand.MinimumWidth = 6;
            this.shoeBrand.Name = "shoeBrand";
            this.shoeBrand.ReadOnly = true;
            // 
            // shoeCategory
            // 
            this.shoeCategory.HeaderText = "Shoe Category";
            this.shoeCategory.MinimumWidth = 6;
            this.shoeCategory.Name = "shoeCategory";
            this.shoeCategory.ReadOnly = true;
            // 
            // shoeColor
            // 
            this.shoeColor.HeaderText = "Shoe Color";
            this.shoeColor.MinimumWidth = 6;
            this.shoeColor.Name = "shoeColor";
            this.shoeColor.ReadOnly = true;
            // 
            // shoeStyle
            // 
            this.shoeStyle.HeaderText = "Shoe Style";
            this.shoeStyle.MinimumWidth = 6;
            this.shoeStyle.Name = "shoeStyle";
            this.shoeStyle.ReadOnly = true;
            // 
            // shoeSize
            // 
            this.shoeSize.HeaderText = "Shoe Size";
            this.shoeSize.MinimumWidth = 6;
            this.shoeSize.Name = "shoeSize";
            this.shoeSize.ReadOnly = true;
            // 
            // salePrice
            // 
            this.salePrice.HeaderText = "Sale Price";
            this.salePrice.MinimumWidth = 6;
            this.salePrice.Name = "salePrice";
            this.salePrice.ReadOnly = true;
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 732);
            this.Controls.Add(this.gvSales);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSales";
            this.Text = "Sales";
            ((System.ComponentModel.ISupportInitialize)(this.gvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView gvSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePrice;
    }
}