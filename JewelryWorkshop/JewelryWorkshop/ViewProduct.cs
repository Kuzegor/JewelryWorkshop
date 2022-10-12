using JewelryWorkshop;
using JewelryWorkshopLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryWorkshopWinFormsUI
{
    public partial class ViewProduct : Form
    {
        private ProductModel productModel;
        public ViewProduct(ProductModel productModel)
        {
            InitializeComponent();

            this.MinimumSize = this.Size;

            this.productModel = productModel;
            nameLabel.Text = $"Name: {productModel.ProductName}";
            if (productModel.ProductType != null)
            {
                typeLabel.Text = $"Type: {productModel.ProductType.TypeName}";
            }
            else
            {
                typeLabel.Text = $"Type: <this type was deleted from the database>";
            }
            priceLabel.Text = $"Price: {productModel.ProductPrice:C2}";
            WireUpdDataGridViews();
        }

        private void WireUpdDataGridViews()
        {
            processingDataGridView.DataSource = productModel.ProductProcessing.GetRange(0, productModel.ProductProcessing.Count);
            processingDataGridView.Columns[0].Visible = false;
            processingDataGridView.Columns[2].Visible = false;

            compositionDataGridView.DataSource = productModel.ProductComposition.GetRange(0, productModel.ProductComposition.Count);
            compositionDataGridView.Columns[0].Visible = false;
            compositionDataGridView.Columns[2].Visible = false;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct(productModel);
            createProduct.Show();
        }
    }
}
