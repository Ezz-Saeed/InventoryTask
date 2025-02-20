namespace InventoryTask
{
    partial class AddProductForm
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
            ProductName = new TextBox();
            Description = new TextBox();
            Supplier = new TextBox();
            Quantity = new TextBox();
            Price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ProductName
            // 
            ProductName.Location = new Point(408, 42);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(125, 27);
            ProductName.TabIndex = 0;
            // 
            // Description
            // 
            Description.Location = new Point(408, 102);
            Description.Name = "Description";
            Description.Size = new Size(125, 27);
            Description.TabIndex = 1;
            // 
            // Supplier
            // 
            Supplier.Location = new Point(408, 270);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(125, 27);
            Supplier.TabIndex = 2;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(408, 212);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(125, 27);
            Quantity.TabIndex = 3;
            // 
            // Price
            // 
            Price.Location = new Point(408, 159);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 49);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 109);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 6;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 166);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 7;
            label3.Text = "Price";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(301, 219);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 8;
            label4.Text = "Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 277);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 9;
            label5.Text = "Supplier";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(352, 366);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Price);
            Controls.Add(Quantity);
            Controls.Add(Supplier);
            Controls.Add(Description);
            Controls.Add(ProductName);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductName;
        private TextBox Description;
        private TextBox Supplier;
        private TextBox Quantity;
        private TextBox Price;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}