namespace InventoryTask
{
    partial class EditProductForm
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
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Price = new TextBox();
            Quantity = new TextBox();
            Supplier = new TextBox();
            Description = new TextBox();
            ProductName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(335, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(284, 284);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 20;
            label5.Text = "Supplier";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(284, 226);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 19;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(284, 173);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 18;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 116);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 17;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 56);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 16;
            label1.Text = "Name";
            // 
            // Price
            // 
            Price.Location = new Point(391, 166);
            Price.Name = "Price";
            Price.Size = new Size(125, 27);
            Price.TabIndex = 15;
            // 
            // Quantity
            // 
            Quantity.Location = new Point(391, 219);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(125, 27);
            Quantity.TabIndex = 14;
            // 
            // Supplier
            // 
            Supplier.Location = new Point(391, 277);
            Supplier.Name = "Supplier";
            Supplier.Size = new Size(125, 27);
            Supplier.TabIndex = 13;
            // 
            // Description
            // 
            Description.Location = new Point(391, 109);
            Description.Name = "Description";
            Description.Size = new Size(125, 27);
            Description.TabIndex = 12;
            // 
            // ProductName
            // 
            ProductName.Location = new Point(391, 49);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(125, 27);
            ProductName.TabIndex = 11;
            // 
            // EditProductForm
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
            Name = "EditProductForm";
            Text = "EditProductForm";
            Load += EditProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Price;
        private TextBox Quantity;
        private TextBox Supplier;
        private TextBox Description;
        private TextBox ProductName;
    }
}