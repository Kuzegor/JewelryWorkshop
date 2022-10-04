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
    public partial class CreateMaterial : Form
    {
        private List<MaterialModel> listOfMaterials  = GlobalStuff.Connector.GetAllMaterials();
        private List<MaterialModel> selectedMaterials = new List<MaterialModel>();

        public CreateMaterial()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            materialsDataGridView.DataSource = null;
            materialsDataGridView.DataSource = listOfMaterials.GetRange(0,listOfMaterials.Count);
            materialsDataGridView.Columns[0].Visible = false;
            materialsDataGridView.Columns[4].Visible = false;
        }

        private void createMaterialButton_Click(object sender, EventArgs e)
        {
            MaterialModel materialModel = new MaterialModel();
            if (materialNameTextBox.Text.Length > 0)
            {
                materialModel.MaterialName = materialNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("You must enter the name of the material to proceed","Material Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (decimal.TryParse(materialPriceTextBox.Text, out decimal price))
            {
                materialModel.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter valid price", "Material Price", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (materialUnitTextBox.Text.Length > 0)
            {
                materialModel.Unit = materialUnitTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter the unit in which the amount of material is measured", "Material Measurement Unit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GlobalStuff.Connector.CreateMaterial(materialModel);
            listOfMaterials.Add(materialModel);

            materialNameTextBox.Clear();
            materialPriceTextBox.Clear();
            materialUnitTextBox.Clear();
            WireUpLists();
        }

        private void deleteSelectedMaterialButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in materialsDataGridView.SelectedRows)
            {
                MaterialModel materialToDelete = listOfMaterials.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedMaterials.Add(materialToDelete);
                listOfMaterials.Remove(materialToDelete);
            }
            GlobalStuff.Connector.DeleteMaterials(selectedMaterials);
            WireUpLists();
        }

        private void saveSelectedButton_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in materialsDataGridView.SelectedRows)
            {
                MaterialModel materialToDelete = listOfMaterials.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedMaterials.Add(materialToDelete);
            }
            GlobalStuff.Connector.UpdateMaterials(selectedMaterials);
            WireUpLists();
        }
    }
}
