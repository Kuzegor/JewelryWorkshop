using JewelryWorkshopLibrary;
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
    public partial class CreateOrder : Form, IViewProductsCaller
    {
        private List<ClientModel> listOfClients = GlobalStuff.Connector.GetAllClients();
        private List<ProductModel> addedProducts = new List<ProductModel>();

        OrderModel orderModel = new OrderModel();

        public CreateOrder()
        {
            InitializeComponent();
            WireUpListOfClients();
            WireUpListOfProducts();

            orderModel.GetTotalPriceOfProducts(addedProducts);
            totalPriceLabel.Text = $"Total Price: {orderModel.TotalPrice:C2}";

            GlobalStuff.Connector.OnClientCreated += Connector_OnClientCreated;
            GlobalStuff.Connector.OnClientsDeleted += Connector_OnClientsDeleted;
            GlobalStuff.Connector.OnClientsUpdated += Connector_OnClientsUpdated;
        }

        private void Connector_OnClientsUpdated(object? sender, List<ClientModel> clientModels)
        {
            foreach (ClientModel clientModel in clientModels)
            {
                listOfClients.Remove(listOfClients.Where(x => x.Id == clientModel.Id).FirstOrDefault());
                listOfClients.Add(clientModel);
            }
            WireUpListOfClients();
        }

        private void Connector_OnClientsDeleted(object? sender, List<ClientModel> clientModels)
        {
            foreach (ClientModel clientModel in clientModels)
            {
                listOfClients.Remove(listOfClients.Where(x => x.Id == clientModel.Id).FirstOrDefault());
            }
            WireUpListOfClients();
        }
        private void Connector_OnClientCreated(object? sender, ClientModel clientModel)
        {
            listOfClients.Add(clientModel);
            WireUpListOfClients();
        }

        private void WireUpListOfClients()
        {
            clientComboBox.DataSource = null;
            clientComboBox.DataSource = listOfClients;
            clientComboBox.DisplayMember = "FullName";
        }
        private void WireUpListOfProducts()
        {
            productsListBox.DataSource = null;
            productsListBox.DataSource = addedProducts;
            productsListBox.DisplayMember = "ProductNameAndQuantity";
        }

        public void ProductAdded(ProductModel productModel)
        {
            ProductModel matchingProduct = addedProducts.Where(x => x.Id == productModel.Id).FirstOrDefault();
            if (matchingProduct == null)
            {
                addedProducts.Add(productModel);
            }
            else
            {
                matchingProduct.Quantity += productModel.Quantity;
            }

            WireUpListOfProducts();
            orderModel.GetTotalPriceOfProducts(addedProducts);
            totalPriceLabel.Text = $"Total Price: {orderModel.TotalPrice:C2}";
        }

        private void createNewClientLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.Show();
        }

        private void viewProductsButton_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(this);
            viewProducts.Show();
        }

        private void removeSelectedOrdersButton_Click(object sender, EventArgs e)
        {           
            foreach (ProductModel product in productsListBox.SelectedItems)
            {
                addedProducts.Remove(product);
            }
            WireUpListOfProducts();

            orderModel.GetTotalPriceOfProducts(addedProducts);
            totalPriceLabel.Text = $"Total Price: {orderModel.TotalPrice:C2}";
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            orderModel.Client = (ClientModel)clientComboBox.SelectedItem;
            if (addedProducts.Count > 0)
            {
                orderModel.OrderedProducts = addedProducts;
            }
            else
            {
                MessageBox.Show("What are you trying to order? Air?", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            orderModel.GetTotalPriceOfProducts(addedProducts);// calculating the total price of all the added products
             
            GlobalStuff.Connector.CreateOrder(orderModel);

            this.Close();
            MessageBox.Show("The Order has been created","New Order",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void viewSelectedProductButton_Click(object sender, EventArgs e)
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
    }
}
