namespace C__Coderhouse_MAIN
{
    partial class ProductFormView
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
            textName = new TextBox();
            textStock = new TextBox();
            textSellPrice = new TextBox();
            textBuyPrice = new TextBox();
            textDescription = new TextBox();
            textCategory = new TextBox();
            textTotalProducts = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textName
            // 
            textName.Location = new Point(12, 12);
            textName.Name = "textName";
            textName.PlaceholderText = "Name";
            textName.Size = new Size(100, 23);
            textName.TabIndex = 2;
            // 
            // textStock
            // 
            textStock.Location = new Point(12, 157);
            textStock.Name = "textStock";
            textStock.PlaceholderText = "Stock";
            textStock.Size = new Size(100, 23);
            textStock.TabIndex = 3;
            // 
            // textSellPrice
            // 
            textSellPrice.Location = new Point(12, 99);
            textSellPrice.Name = "textSellPrice";
            textSellPrice.PlaceholderText = "Sell price";
            textSellPrice.Size = new Size(100, 23);
            textSellPrice.TabIndex = 4;
            // 
            // textBuyPrice
            // 
            textBuyPrice.Location = new Point(12, 70);
            textBuyPrice.Name = "textBuyPrice";
            textBuyPrice.PlaceholderText = "Buy price";
            textBuyPrice.Size = new Size(100, 23);
            textBuyPrice.TabIndex = 5;
            // 
            // textDescription
            // 
            textDescription.Location = new Point(12, 41);
            textDescription.Name = "textDescription";
            textDescription.PlaceholderText = "Description";
            textDescription.Size = new Size(100, 23);
            textDescription.TabIndex = 6;
            // 
            // textCategory
            // 
            textCategory.Location = new Point(12, 186);
            textCategory.Name = "textCategory";
            textCategory.PlaceholderText = "Category";
            textCategory.Size = new Size(100, 23);
            textCategory.TabIndex = 7;
            // 
            // textTotalProducts
            // 
            textTotalProducts.Location = new Point(12, 128);
            textTotalProducts.Name = "textTotalProducts";
            textTotalProducts.PlaceholderText = "Total Products";
            textTotalProducts.Size = new Size(100, 23);
            textTotalProducts.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(126, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConfirmProduct_click;
            // 
            // ProductFormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 282);
            Controls.Add(button1);
            Controls.Add(textTotalProducts);
            Controls.Add(textCategory);
            Controls.Add(textDescription);
            Controls.Add(textBuyPrice);
            Controls.Add(textSellPrice);
            Controls.Add(textStock);
            Controls.Add(textName);
            Name = "ProductFormView";
            Text = "ProductFormView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textName;
        private TextBox textStock;
        private TextBox textSellPrice;
        private TextBox textBuyPrice;
        private TextBox textDescription;
        private TextBox textCategory;
        private TextBox textTotalProducts;
        private Button button1;
    }
}