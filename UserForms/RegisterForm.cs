using InventoryTask.Helpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTask.UserForms
{
    public partial class RegisterForm : Form
    {
        private readonly SqlConnection connection;
        public RegisterForm()
        {
            InitializeComponent();
            var settings = new Settings();
            connection = settings.GetConnection;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                using var hmac = new HMACSHA512();
                var hashedPassword = hmac.ComputeHash(Encoding.UTF8.GetBytes(Password.Text));
                using var command = new SqlCommand("RegisterUser", connection);
                command.CommandType = CommandType.StoredProcedure;
               
                SqlParameter userName = new()
                {
                    ParameterName = "@UserName",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = UserName.Text
                };

                SqlParameter passwordHash = new()
                {
                    ParameterName = "@PasswordHash",
                    SqlDbType = SqlDbType.VarBinary,
                    Direction = ParameterDirection.Input,
                    Value = hashedPassword
                };

                SqlParameter passwordSalt = new()
                {
                    ParameterName = "@PasswordSalt",
                    SqlDbType = SqlDbType.VarBinary,
                    Direction = ParameterDirection.Input,
                    Value = hmac.Key
                };

                SqlParameter roleId = new()
                {
                    ParameterName = "@RoleId",
                    SqlDbType = SqlDbType.VarChar,
                    Direction = ParameterDirection.Input,
                    Value = 1
                };

                command.Parameters.Add(userName);
                command.Parameters.Add(passwordHash);
                command.Parameters.Add(passwordSalt);
                command.Parameters.Add(roleId);

                connection.Open();
                var affectedRows = command.ExecuteNonQuery();
                if (affectedRows > 0)
                    MessageBox.Show("User successfully registered!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Error invalid user credetials.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //File.AppendAllText("ErrorLog.txt", $"{DateTime.Now}: {ex.Message} | {ex.StackTrace}{Environment.NewLine}");
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }
    }
}
