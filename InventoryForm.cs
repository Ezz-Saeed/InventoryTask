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
using InventoryTask.Helpers;
using InventoryTask.UserForms;
using System.Security.Cryptography;

namespace InventoryTask
{
    public partial class InventoryForm : Form
    {
        private readonly SqlConnection connection;
        public InventoryForm()
        {
            InitializeComponent();
            var settings = new Settings();
            connection = settings.GetConnection;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                using var command = new SqlCommand("LoginUser", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlParameter userName = new()
                {
                    ParameterName = "@UserName",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = UserName.Text
                };               
                command.Parameters.Add(userName);

                connection.Open();
                using SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    string loggedInUser = string.Empty;
                    List<string> roles = new();
                    byte[] passwordHash = new byte[] { };
                    byte[] passwordSalt = new byte[] { };
                    while (reader.Read())
                    {
                        loggedInUser = reader["UserName"].ToString()!;
                        roles.Add(reader["RoleName"].ToString()!);
                        passwordHash = (byte[])reader["PasswordHash"];
                        passwordSalt = (byte[])reader["PasswordSalt"];
                    }

                    using var hmac = new HMACSHA512(passwordSalt);
                    var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password.Text));
                    if (!computedHash.SequenceEqual(passwordHash)) 
                    {
                        MessageBox.Show("Invalid password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show($"Login successful!\nUser: {loggedInUser}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ProductsForm productsForm = new ProductsForm();
                    productsForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
