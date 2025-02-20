namespace InventoryTask
{
    partial class ProductsForm
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
            ProductsDataGridView = new DataGridView();
            newProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(1, 90);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 51;
            ProductsDataGridView.Size = new Size(799, 261);
            ProductsDataGridView.TabIndex = 0;
            ProductsDataGridView.CellContentClick += ProductsDataGridView_CellContentClick;
            // 
            // newProduct
            // 
            newProduct.Location = new Point(1, 30);
            newProduct.Name = "newProduct";
            newProduct.Size = new Size(125, 36);
            newProduct.TabIndex = 1;
            newProduct.Text = "New Product";
            newProduct.UseVisualStyleBackColor = true;
            newProduct.Click += newProduct_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(newProduct);
            Controls.Add(ProductsDataGridView);
            Name = "ProductsForm";
            Text = "Products";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private Button newProduct;
    }
}