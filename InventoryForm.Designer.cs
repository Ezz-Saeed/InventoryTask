namespace InventoryTask
{
    partial class InventoryForm
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
            UserName = new TextBox();
            Password = new TextBox();
            Login = new Button();
            Register = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Location = new Point(320, 82);
            UserName.Name = "UserName";
            UserName.Size = new Size(177, 27);
            UserName.TabIndex = 0;
            // 
            // Password
            // 
            Password.Location = new Point(320, 134);
            Password.Name = "Password";
            Password.Size = new Size(177, 27);
            Password.TabIndex = 1;
            // 
            // Login
            // 
            Login.Location = new Point(352, 196);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 2;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // Register
            // 
            Register.Location = new Point(352, 261);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 3;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 89);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 141);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Register);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(UserName);
            Name = "InventoryForm";
            Text = "InventoryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private Button Login;
        private Button Register;
        private Label label1;
        private Label label2;
    }
}