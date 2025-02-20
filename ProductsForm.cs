﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTask
{
    public partial class ProductsForm : Form
    {
        private readonly Settings settings;
        public ProductsForm()
        {
            settings = new Settings();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Products();
        }

        private void Load_Products()
        {
            string query = "SELECT ProductID, ProductName, Description, StockQuantity, Price, SupplierName FROM Products";
            try
            {
                using var adapter = new SqlDataAdapter(query, settings.GetConnection);
                using var products = new DataTable();
                adapter.Fill(products);
                ProductsDataGridView.DataSource = products;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! ${ex.Message}");
            }
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }
    }
}
