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
    public partial class CreateClient : Form
    {
        private List<ClientModel> listOfClients = GlobalStuff.Connector.GetAllClients();
        private List<ClientModel> selectedClients = new List<ClientModel>();

        public CreateClient()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists() 
        {
            clientsDataGridView.DataSource = null;
            clientsDataGridView.DataSource = listOfClients.GetRange(0, listOfClients.Count);
            clientsDataGridView.Columns[0].Visible = false;
            clientsDataGridView.Columns[5].Visible = false;
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
    }
}
