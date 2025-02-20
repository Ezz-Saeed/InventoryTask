namespace InventoryTask.UserForms
{
    partial class RegisterForm
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
            label2 = new Label();
            label1 = new Label();
            Register = new Button();
            Password = new TextBox();
            UserName = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 155);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(225, 103);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 10;
            label1.Text = "Username";
            // 
            // Register
            // 
            Register.Location = new Point(356, 210);
            Register.Name = "Register";
            Register.Size = new Size(94, 29);
            Register.TabIndex = 8;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += Register_Click;
            // 
            // Password
            // 
            Password.Location = new Point(324, 148);
            Password.Name = "Password";
            Password.Size = new Size(177, 27);
            Password.TabIndex = 7;
            // 
            // UserName
            // 
            UserName.Location = new Point(324, 96);
            UserName.Name = "UserName";
            UserName.Size = new Size(177, 27);
            UserName.TabIndex = 6;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Register);
            Controls.Add(Password);
            Controls.Add(UserName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button Register;
        private TextBox Password;
        private TextBox UserName;
    }
}