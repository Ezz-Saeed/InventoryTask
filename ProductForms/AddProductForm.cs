using InventoryTask.Helpers;
using Microsoft.Data.SqlClient;
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
    public partial class AddProductForm : Form
    {
        private readonly Settings settings;
        public AddProductForm()
        {
            InitializeComponent();
            settings = new Settings();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlCommand addCommand = new SqlCommand("InsertProduct", settings.GetConnection);
                addCommand.CommandType = CommandType.StoredProcedure;

                SqlParameter name = new()
                {
                    ParameterName = "@ProductName",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = ProductName.Text
                };

                SqlParameter description = new()
                {
                    ParameterName = "@Description",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = Description.Text
                };

                SqlParameter quantity = new()
                {
                    ParameterName = "@StockQuantity",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = int.Parse(Quantity.Text)
                };

                SqlParameter price = new()
                {
                    ParameterName = "@Price",
                    SqlDbType = SqlDbType.Decimal,
                    Direction = ParameterDirection.Input,
                    Value = decimal.Parse(Price.Text)
                };

                SqlParameter supplier = new()
                {
                    ParameterName = "@SupplierName",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = Supplier.Text
                };
                addCommand.Parameters.Add(name);
                addCommand.Parameters.Add(description);
                addCommand.Parameters.Add(quantity);
                addCommand.Parameters.Add(price);
                addCommand.Parameters.Add(supplier);

                settings.GetConnection.Open();
                var affectedRows = addCommand.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error adding product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (settings.GetConnection.State == ConnectionState.Open)
                    settings.GetConnection.Close();
            }

        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
