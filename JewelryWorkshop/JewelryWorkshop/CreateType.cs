using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JewelryWorkshopLibrary;
using JewelryWorkshopLibrary.Models;
using JewelryWorkshopWinFormsUI.Rquesters;

namespace JewelryWorkshopWinFormsUI
{
    public partial class CreateType : Form
    {
        private List<ProductTypeModel> listOfTypes = GlobalStuff.Connector.GetAllTypes();
        private List<ProductTypeModel> selectedTypes = new List<ProductTypeModel>();

        public CreateType()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            productTypesListBox.DataSource = null;
            productTypesListBox.DataSource = listOfTypes;
            productTypesListBox.DisplayMember = "TypeName";
        }

        private void createTypeButton_Click(object sender, EventArgs e)
        {
            ProductTypeModel typeModel = new ProductTypeModel();
            if (productTypeNameTextBox.Text.Length > 0)
            {
                typeModel.TypeName = productTypeNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter the name of the type you want to create to proceed", 
                    "Product Type Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GlobalStuff.Connector.CreateType(typeModel);
            productTypeNameTextBox.Clear();
            listOfTypes.Add(typeModel);
            WireUpLists();
        }

        private void deleteSelectedTypeButton_Click(object sender, EventArgs e)
        {
            foreach (ProductTypeModel type in productTypesListBox.SelectedItems)
            {
                selectedTypes.Add(type);
                listOfTypes.Remove(type);
            }
            GlobalStuff.Connector.DeleteTypes(selectedTypes);
            WireUpLists();
        }
    }
}
