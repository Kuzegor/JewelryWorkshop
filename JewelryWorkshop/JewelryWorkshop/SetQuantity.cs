using JewelryWorkshopLibrary.Models;
using JewelryWorkshopWinFormsUI.Rquesters;
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
    public partial class SetQuantity : Form
    {
        private IViewProductsCaller callingForm;
        private ProductModel selectedProduct;
        public SetQuantity(IViewProductsCaller callingForm, ProductModel selectedProduct)
        {
            InitializeComponent();
            this.callingForm = callingForm;
            this.selectedProduct = selectedProduct;
            headerLabel.Text = $"Adding {selectedProduct.ProductName}";
        }
        
        private void confirmButton_Click(object sender, EventArgs e)
        {
            selectedProduct.Quantity = Convert.ToInt32(quantityNumericUpDown.Value);
            callingForm?.ProductAdded(selectedProduct);
            this.Close();
            MessageBox.Show($"{selectedProduct.Quantity}x '{selectedProduct.ProductName}' have been added to the Order List ",
                "Order List",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
