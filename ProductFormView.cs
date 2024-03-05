using C__Coderhouse_MAIN.models;
using C__Coderhouse_MAIN.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Coderhouse_MAIN
{
    public partial class ProductFormView : Form
    {
        public ProductFormView()
        {
            InitializeComponent();
        }
        public ProductFormView(Products product) : this()
        {
            this.textName.Text = product.Name;
            this.textDescription.Text = product.Description;
            this.textBuyPrice.Text = product.BuyPrice.ToString();
            this.textSellPrice.Text = product.SellPrice.ToString();
            this.textTotalProducts.Text = product.TotalProduct.ToString();
            this.textStock.Text = product.Stock.ToString();
            this.textCategory.Text = product.Category;
        }
        public Products CreatedProduct { get; private set; }

        private void ConfirmProduct_click(object sender, EventArgs e)
        {
            double buyPrice;
            double.TryParse(textBuyPrice.Text, out buyPrice);

            double sellPrice;
            double.TryParse(textSellPrice.Text, out sellPrice);

            decimal stock;
            decimal.TryParse(textStock.Text, out stock);

            decimal totalProduct;
            decimal.TryParse(textTotalProducts.Text, out totalProduct);

            Random random = new Random();
            int randomUserId = random.Next(1, 5);
            Products product = new Products()
            {
                Name = textName.Text,
                Description = textDescription.Text,
                BuyPrice = buyPrice,
                SellPrice = sellPrice,
                Stock = stock,
                TotalProduct = totalProduct,
                Category = textCategory.Text,
                UsersID = randomUserId
            };
            
            if (ProductService.AddProduct(product))
            {
                MessageBox.Show("Product added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.CreatedProduct = product;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
