﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShoesStoreManagementSystem
{
    public partial class frmAddItems : Form
    {
        public frmAddItems()
        {
            InitializeComponent();
        }

        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (txtBrand.Text == "Brand")
            {
                txtBrand.Text = string.Empty;
                txtBrand.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                txtBrand.Text = "Brand";
                txtBrand.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Text == "Category")
            {
                txtCategory.Text = string.Empty;
                txtCategory.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                txtCategory.Text = "Category";
                txtCategory.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Text = string.Empty;
                txtColor.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                txtColor.Text = "Color";
                txtColor.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSize_Enter(object sender, EventArgs e)
        {
            if (txtSize.Text == "Size")
            {
                txtSize.Text = string.Empty;
                txtSize.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSize_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSize.Text))
            {
                txtSize.Text = "Size";
                txtSize.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtStyle_Enter(object sender, EventArgs e)
        {
            if (txtStyle.Text == "Style")
            {
                txtStyle.Text = string.Empty;
                txtStyle.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtStyle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStyle.Text))
            {
                txtStyle.Text = "Style";
                txtStyle.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtPrice.Text == "Price")
            {
                txtPrice.Text = string.Empty;
                txtPrice.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                txtPrice.Text = "Price";
                txtPrice.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Quantity")
            {
                txtQuantity.Text = string.Empty;
                txtQuantity.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtQuantity.Text = "Quantity";
                txtQuantity.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Start the transaction
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    // Execute your SQL code within the transaction
                    using (SqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.Transaction = transaction;
                        cmd.CommandText = @"
                         BEGIN TRANSACTION;
                         
                         DECLARE @brandId INT, @categoryId INT, @styleId INT, @colorId INT, @sizeId INT;
                         
                         INSERT INTO tblBrands (brand)
                         VALUES (@brand);
                         SET @brandId = SCOPE_IDENTITY();
                         
                         INSERT INTO tblCategories (category)
                         VALUES (@category);
                         SET @categoryId = SCOPE_IDENTITY();
                         
                         INSERT INTO tblStyles (style)
                         VALUES (@style);
                         SET @styleId = SCOPE_IDENTITY();
                         
                         INSERT INTO tblColors (color)
                         VALUES (@color);
                         SET @colorId = SCOPE_IDENTITY();
                         
                         INSERT INTO tblSizes (size)
                         VALUES (@size);
                         SET @sizeId = SCOPE_IDENTITY();
                    
                         INSERT INTO tblPrices (pirce)
                         VALUES (@price);
                         SET @priceId = SCOPE_IDENTITY();
                         
                         INSERT INTO tblStock (brand, category, style, color, size, price, quantity)
                         VALUES (@brandId, @categoryId, @styleId, @colorId, @sizeId, @priceId, @quantity);

                         COMMIT;
                         ";

                        cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                        cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                        cmd.Parameters.AddWithValue("@style", txtStyle.Text);
                        cmd.Parameters.AddWithValue("@color", txtColor.Text);
                        cmd.Parameters.AddWithValue("@size", txtSize.Text);
                        cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                        cmd.Parameters.AddWithValue("@quantity", txtQuantity.Text);

                        cmd.ExecuteNonQuery();
                    }


                    // Commit the transaction if all statements executed successfully
                    transaction.Commit();
                    MessageBox.Show("Transaction completed successfully.");
                }
                catch (Exception ex)
                {
                    // Handle any exceptions and rollback the transaction if necessary
                    transaction.Rollback();

                    // Display or log the error message
                    MessageBox.Show("Transaction failed: " + ex.Message);
                }
            }
        }

    }
}
