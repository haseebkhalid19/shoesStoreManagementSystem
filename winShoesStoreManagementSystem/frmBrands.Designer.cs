﻿namespace winShoesStoreManagementSystem
{
    partial class frmBrands
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
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnAddBulk = new Guna.UI.WinForms.GunaButton();
            this.gvBrands = new Guna.UI.WinForms.GunaDataGridView();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.brandId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvBrands)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddItems
            // 
            this.btnAddItems.AnimationHoverSpeed = 0.07F;
            this.btnAddItems.AnimationSpeed = 0.03F;
            this.btnAddItems.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItems.BaseColor = System.Drawing.Color.Gray;
            this.btnAddItems.BorderColor = System.Drawing.Color.Black;
            this.btnAddItems.BorderSize = 1;
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = null;
            this.btnAddItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItems.Location = new System.Drawing.Point(105, 137);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItems.Radius = 10;
            this.btnAddItems.Size = new System.Drawing.Size(125, 42);
            this.btnAddItems.TabIndex = 40;
            this.btnAddItems.Text = "+Add Items";
            this.btnAddItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddBulk
            // 
            this.btnAddBulk.AnimationHoverSpeed = 0.07F;
            this.btnAddBulk.AnimationSpeed = 0.03F;
            this.btnAddBulk.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBulk.BaseColor = System.Drawing.Color.Gray;
            this.btnAddBulk.BorderColor = System.Drawing.Color.Black;
            this.btnAddBulk.BorderSize = 1;
            this.btnAddBulk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBulk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBulk.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBulk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBulk.ForeColor = System.Drawing.Color.White;
            this.btnAddBulk.Image = null;
            this.btnAddBulk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddBulk.Location = new System.Drawing.Point(246, 137);
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddBulk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBulk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBulk.OnHoverImage = null;
            this.btnAddBulk.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBulk.Radius = 10;
            this.btnAddBulk.Size = new System.Drawing.Size(127, 42);
            this.btnAddBulk.TabIndex = 41;
            this.btnAddBulk.Text = "+Add Bulk";
            this.btnAddBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gvBrands
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvBrands.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBrands.BackgroundColor = System.Drawing.Color.White;
            this.gvBrands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBrands.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvBrands.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBrands.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvBrands.ColumnHeadersHeight = 27;
            this.gvBrands.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.brandId,
            this.brandName,
            this.sellingPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBrands.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvBrands.EnableHeadersVisualStyles = false;
            this.gvBrands.GridColor = System.Drawing.Color.White;
            this.gvBrands.Location = new System.Drawing.Point(101, 199);
            this.gvBrands.Name = "gvBrands";
            this.gvBrands.ReadOnly = true;
            this.gvBrands.RowHeadersVisible = false;
            this.gvBrands.RowHeadersWidth = 51;
            this.gvBrands.RowTemplate.Height = 24;
            this.gvBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBrands.Size = new System.Drawing.Size(1317, 475);
            this.gvBrands.TabIndex = 39;
            this.gvBrands.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gvBrands.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvBrands.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvBrands.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvBrands.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvBrands.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvBrands.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvBrands.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gvBrands.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.gvBrands.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvBrands.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvBrands.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvBrands.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvBrands.ThemeStyle.HeaderStyle.Height = 27;
            this.gvBrands.ThemeStyle.ReadOnly = true;
            this.gvBrands.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvBrands.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvBrands.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvBrands.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvBrands.ThemeStyle.RowsStyle.Height = 24;
            this.gvBrands.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvBrands.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.txtSearch.Location = new System.Drawing.Point(1195, 146);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(223, 33);
            this.txtSearch.TabIndex = 38;
            this.txtSearch.Text = "Search...";
            // 
            // brandId
            // 
            this.brandId.HeaderText = "Brand Id";
            this.brandId.MinimumWidth = 6;
            this.brandId.Name = "brandId";
            this.brandId.ReadOnly = true;
            // 
            // brandName
            // 
            this.brandName.HeaderText = "Brand Name";
            this.brandName.MinimumWidth = 6;
            this.brandName.Name = "brandName";
            this.brandName.ReadOnly = true;
            // 
            // sellingPrice
            // 
            this.sellingPrice.HeaderText = "Selling Price";
            this.sellingPrice.MinimumWidth = 6;
            this.sellingPrice.Name = "sellingPrice";
            this.sellingPrice.ReadOnly = true;
            // 
            // frmBrands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 723);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnAddBulk);
            this.Controls.Add(this.gvBrands);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrands";
            this.Text = "frmBrands";
            ((System.ComponentModel.ISupportInitialize)(this.gvBrands)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaButton btnAddBulk;
        private Guna.UI.WinForms.GunaDataGridView gvBrands;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandId;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellingPrice;
    }
}