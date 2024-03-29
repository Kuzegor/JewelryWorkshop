﻿using JewelryWorkshopLibrary;
using JewelryWorkshopLibrary.Models;
using JewelryWorkshopWinFormsUI;
using JewelryWorkshopWinFormsUI.Rquesters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private PropertyInfo[] propertiesInfo;//this is for sorting
        private bool sortOrderIsDescending;

        public ViewOrders()
        {
            InitializeComponent();
            LoadOrders();

            this.MinimumSize = this.Size;
            this.Height = 700;

            GlobalStuff.Connector.OnOrderCompletionStatusChanged += Connector_OnOrderCompletionStatusChanged;
            GlobalStuff.Connector.OnOrderCreated += Connector_OnOrderCreated;

            propertiesInfo = typeof(OrderModel).GetProperties();
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
            bool temp = columnsRadioButton.Checked;
            rowsRadioButton.Checked = true;
            ordersDataGridView.DataSource = null;
            ordersDataGridView.DataSource = ordersToShow.GetRange(0, ordersToShow.Count);
            ordersDataGridView.Columns[1].Visible = false;
            foreach (DataGridViewColumn column in ordersDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            columnsRadioButton.Checked = temp;
        }
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedColumns.Count == 1)
            {
                List<OrderModel> searchedOrders = new List<OrderModel>();
                int columnId = ordersDataGridView.SelectedColumns[0].Index;
                foreach (DataGridViewRow row in ordersDataGridView.Rows)
                {
                    if (row.Cells[columnId].Value.ToString().Contains(searchBox.Text))
                    {
                        searchedOrders.Add(listOfOrders.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault());
                    }
                }

                rowsRadioButton.Checked = true;
                ordersDataGridView.DataSource = null;
                ordersDataGridView.DataSource = searchedOrders.GetRange(0, searchedOrders.Count);
                ordersDataGridView.Columns[1].Visible = false;
                foreach (DataGridViewColumn column in ordersDataGridView.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
                columnsRadioButton.Checked = true;
            }
            else
            {
                MessageBox.Show("You need to select one column to search", "Column selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            WireUpLists();
        }

        private void rowsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void columnsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ordersDataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (ordersDataGridView.SelectedColumns.Count == 1)
            {
                string columnName = ordersDataGridView.SelectedColumns[0].HeaderText;
                PropertyInfo property = propertiesInfo.Where(x => x.Name == columnName).FirstOrDefault();
                if (sortOrderIsDescending)
                {
                    ordersToShow = ordersToShow.OrderBy(x => property.GetValue(x)).ToList();
                    sortOrderIsDescending = false;
                }
                else
                {
                    ordersToShow = ordersToShow.OrderByDescending(x => property.GetValue(x)).ToList();
                    sortOrderIsDescending = true;
                }
                WireUpLists();
            }
            else
            {
                MessageBox.Show("You need to select one column to sort", "Column selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
