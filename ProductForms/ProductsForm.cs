using InventoryTask.Helpers;
using Microsoft.Data.SqlClient;
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
            ProductsDataGridView.CellClick += ProductsDataGridView_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!CurrentUser.Roles.Contains("Admin"))
            {
                newProduct.Visible = false;
                
            }
            Load_Products();
        }

        private void Load_Products()
        {
            string query = "SELECT ProductID, ProductName, Description, StockQuantity, Price, SupplierName " +
                "FROM Products where IsDeleted = 0";
            try
            {
                using var adapter = new SqlDataAdapter(query, settings.GetConnection);
                using var products = new DataTable();
                adapter.Fill(products);
                ProductsDataGridView.DataSource = products;

                if (!ProductsDataGridView.Columns.Contains("Edit") && CurrentUser.Roles.Contains("Admin"))
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn();
                    editColumn.Name = "Edit";
                    editColumn.Text = "Edit";
                    editColumn.HeaderText = "Edit";
                    editColumn.UseColumnTextForButtonValue = true;
                    ProductsDataGridView.Columns.Add(editColumn);
                }

                if (!ProductsDataGridView.Columns.Contains("Delete") && CurrentUser.Roles.Contains("Admin"))
                {
                    DataGridViewButtonColumn deletetColumn = new DataGridViewButtonColumn();
                    deletetColumn.Name = "Delete";
                    deletetColumn.Text = "Delete";
                    deletetColumn.HeaderText = "Delete";
                    deletetColumn.UseColumnTextForButtonValue = true;
                    ProductsDataGridView.Columns.Add(deletetColumn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! ${ex.Message}");
            }
        }

        private void ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductsDataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                int productId = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells["ProductID"].Value);

                EditProductForm editProductForm = new EditProductForm(productId);
                editProductForm.ShowDialog();
                Load_Products();
            }

            if (e.RowIndex >= 0 && ProductsDataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                int productId = Convert.ToInt32(ProductsDataGridView.Rows[e.RowIndex].Cells["ProductID"].Value);

                try
                {
                    using SqlCommand deleteCommand = new SqlCommand("DeleteProduct", settings.GetConnection);
                    deleteCommand.CommandType = CommandType.StoredProcedure;
                    SqlParameter id = new()
                    {
                        ParameterName = "@ProductId",
                        SqlDbType = SqlDbType.Int,
                        Direction = ParameterDirection.Input,
                        Value = productId
                    };
                    deleteCommand.Parameters.Add(id);

                    settings.GetConnection.Open();
                    var rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error deleting product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if(settings.GetConnection.State == ConnectionState.Open) 
                        settings.GetConnection.Close();
                }

                Load_Products();
            }

        }


        private void newProduct_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
            Load_Products();
        }
    }
}
