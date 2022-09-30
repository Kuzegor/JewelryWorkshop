using JewelryWorkshopLibrary;
using JewelryWorkshopLibrary.Models;
using JewelryWorkshopWinFormsUI;
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

namespace JewelryWorkshop
{
    public partial class ViewOrders : Form
    {
        private List<OrderModel> listOfOrders = GlobalStuff.Connector.GetAllOrders();
        private List<OrderModel> selectedOrders = new List<OrderModel>();
        private List<OrderModel> ordersToShow;

        public ViewOrders()
        {
            InitializeComponent();
            LoadOrders();//includes upwiring of the lists
            GlobalStuff.Connector.OnOrderCompletionStatusChanged += Connector_OnOrderCompletionStatusChanged;
            GlobalStuff.Connector.OnOrderCreated += Connector_OnOrderCreated;
        }

        private void Connector_OnOrderCreated(object? sender, OrderModel orderModel)
        {
            DateTime date = DateTime.Today;
            orderModel.StartDate = date.ToString();
            listOfOrders.Add(orderModel);
            LoadOrders();
        }
        private void Connector_OnOrderCompletionStatusChanged(object? sender, EventArgs e)
        {
            LoadOrders();
        }

        private void WireUpLists()
        {
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = ordersToShow.GetRange(0, ordersToShow.Count);
            ordersDataGridView.Columns[1].Visible = false;
        }//called only by LoadOrders so far
        private void LoadOrders()
        {
            ordersToShow = new List<OrderModel>();
            foreach (OrderModel order in listOfOrders)
            {
                if (order.OrderIsComplete == false || !incompleteOnlyCheckBox.Checked)
                {
                    ordersToShow.Add(order);
                }            
            }
            WireUpLists();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in ordersDataGridView.SelectedRows)
            {
                OrderModel orderToDelete = listOfOrders.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedOrders.Add(orderToDelete);
                listOfOrders.Remove(orderToDelete);
            }
            GlobalStuff.Connector.DeleteOrders(selectedOrders);
            LoadOrders();
        }

        private void createNewOrderButton_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void ViewSelectedButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow row in ordersDataGridView.SelectedRows)
                {
                    OrderModel orderToView = listOfOrders.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                    ViewOrder viewOrder = new ViewOrder(orderToView);
                    viewOrder.Show();  
                }
            }
            else
            {
                MessageBox.Show("You need to select one order to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void incompleteOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void editDataButton_Click(object sender, EventArgs e)
        {
            EditData editData = new EditData();
            editData.Show();
        }
    }
}
