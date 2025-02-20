using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InventoryTask
{
    public partial class EditProductForm : Form
    {
        private readonly SqlConnection connection;
        private readonly int productId;
        public EditProductForm(int productId)
        {
            InitializeComponent();
            this.productId = productId;
            Settings settings = new Settings();
            connection = settings.GetConnection;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            string query = "SELECT * FROM Products WHERE ProductID = @ProductID";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ProductID", productId);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ProductName.Text = reader["ProductName"].ToString();
                Description.Text = reader["Description"].ToString();
                Quantity.Text = reader["StockQuantity"].ToString();
                Price.Text = reader["Price"].ToString();
                Supplier.Text = reader["SupplierName"].ToString();
            }
            connection.Close();
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlCommand command = new SqlCommand("UpdateProduct", connection);
                command.CommandType = CommandType.StoredProcedure;
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

                SqlParameter id = new()
                {
                    ParameterName = "@ProductId",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Input,
                    Value = productId
                };
                command.Parameters.Add(name);
                command.Parameters.Add(description);
                command.Parameters.Add(quantity);
                command.Parameters.Add(price);
                command.Parameters.Add(supplier);
                command.Parameters.Add(id);

                connection.Open();
                var affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                {
                    MessageBox.Show("Product Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error Update product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if(connection.State== ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
