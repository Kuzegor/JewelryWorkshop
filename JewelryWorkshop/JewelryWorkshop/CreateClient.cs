using JewelryWorkshopLibrary;
using JewelryWorkshopLibrary.Models;
using JewelryWorkshopWinFormsUI.Rquesters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryWorkshopWinFormsUI
{
    public partial class CreateClient : Form
    {
        private List<ClientModel> listOfClients = GlobalStuff.Connector.GetAllClients();
        private List<ClientModel> selectedClients = new List<ClientModel>();

        private PropertyInfo[] propertiesInfo;//this is for sorting
        private bool sortOrderIsDescending;

        public CreateClient()
        {
            InitializeComponent();
            WireUpLists();
            this.MinimumSize = this.Size;

            propertiesInfo = typeof(ClientModel).GetProperties();
        }

        private void WireUpLists() 
        {
            bool temp = columnsRadioButton.Checked;
            rowsRadioButton.Checked = true;
            clientsDataGridView.DataSource = null;
            clientsDataGridView.DataSource = listOfClients.GetRange(0, listOfClients.Count);
            clientsDataGridView.Columns[0].Visible = false;
            clientsDataGridView.Columns[5].Visible = false;
            foreach (DataGridViewColumn column in clientsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            columnsRadioButton.Checked = temp;
        }

        private void createClientButton_Click(object sender, EventArgs e)
        {
            ClientModel clientModel = new ClientModel();
            if (firstNameTextBox.Text.Length > 0 || lastNameTextBox.Text.Length > 0 || middleNameTextBox.Text.Length > 0)
            {
                clientModel.FirstName = firstNameTextBox.Text;
                clientModel.LastName = lastNameTextBox.Text;
                clientModel.MiddleName = middleNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Client must have a name","Client's name",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            if (phoneTextBox.Text.Length > 0)
            {
                clientModel.Phone = phoneTextBox.Text;
            }
            else
            {
                MessageBox.Show("Client must have a phone number","Client's phone",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            GlobalStuff.Connector.CreateClient(clientModel);

            listOfClients.Add(clientModel);
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            middleNameTextBox.Clear();
            phoneTextBox.Clear();
            WireUpLists();
        }

        private void deleteSelectedClientButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientsDataGridView.SelectedRows)
            {
                ClientModel clientToDelete = listOfClients.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedClients.Add(clientToDelete);
                listOfClients.Remove(clientToDelete);
            }
            GlobalStuff.Connector.DeleteClients(selectedClients);
            WireUpLists();            
        }

        private void saveSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientsDataGridView.SelectedRows)
            {
                ClientModel clientToDelete = listOfClients.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedClients.Add(clientToDelete);
            }
            GlobalStuff.Connector.UpdateClients(selectedClients);
            WireUpLists();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedColumns.Count == 1)
            {
                List<ClientModel> searchedClients = new List<ClientModel>();
                int columnId = clientsDataGridView.SelectedColumns[0].Index;
                foreach (DataGridViewRow row in clientsDataGridView.Rows)
                {
                    if (row.Cells[columnId].Value.ToString().Contains(searchBox.Text))
                    {
                        searchedClients.Add(listOfClients.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault());
                    }
                }

                rowsRadioButton.Checked = true;
                clientsDataGridView.DataSource = null;
                clientsDataGridView.DataSource = searchedClients.GetRange(0, searchedClients.Count);
                clientsDataGridView.Columns[0].Visible = false;
                clientsDataGridView.Columns[5].Visible = false;
                foreach (DataGridViewColumn column in clientsDataGridView.Columns)
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
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void columnsRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clientsDataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedColumns.Count == 1)
            {
                string columnName = clientsDataGridView.SelectedColumns[0].HeaderText;
                PropertyInfo property = propertiesInfo.Where(x => x.Name == columnName).FirstOrDefault();
                if (sortOrderIsDescending)
                {
                    listOfClients = listOfClients.OrderBy(x => property.GetValue(x)).ToList();
                    sortOrderIsDescending = false;
                }
                else
                {
                    listOfClients = listOfClients.OrderByDescending(x => property.GetValue(x)).ToList();
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
