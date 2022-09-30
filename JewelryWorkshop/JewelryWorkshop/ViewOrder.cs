using JewelryWorkshopLibrary;
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
    public partial class ViewOrder : Form
    {
        private OrderModel orderModel;
        public ViewOrder(OrderModel orderModel)
        {
            InitializeComponent();
            this.orderModel = orderModel;

            idLabel.Text = $"ID: {orderModel.Id}";
            if (orderModel.Client != null)
            {
                clientLabel.Text = $"Client: {orderModel.Client.FullName}";
            }
            else
            {
                clientLabel.Text = $"Client: <this client was deleted from the database>";
            }
            startDateLabel.Text = $"Start Date: {orderModel.StartDate}";
            totalPriceLabel.Text = $"Total Price: {orderModel.TotalPrice:C2}";
            WireUpLists();
            markAsCompleteCheckBox.Checked = orderModel.OrderIsComplete;
        }

        private void WireUpLists()
        {
            productsListBox.DataSource = null;
            productsListBox.DataSource = orderModel.OrderedProducts;
            productsListBox.DisplayMember = "ProductNameAndQuantity";
        }

        private void viewSelectedButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItems.Count == 1)
            {
                ViewProduct viewProduct = new ViewProduct((ProductModel)productsListBox.SelectedItem);
                viewProduct.Show();
            }
            else
            {
                MessageBox.Show("You should select one product to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void markAsCompleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            orderModel.OrderIsComplete = markAsCompleteCheckBox.Checked;
            GlobalStuff.Connector.UpdateOrderCompletionStatus(orderModel, markAsCompleteCheckBox.Checked);
        }
    }
}
