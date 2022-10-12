using JewelryWorkshopLibrary;
using JewelryWorkshopLibrary.Models;
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

namespace JewelryWorkshopWinFormsUI
{
    public partial class CreateMaterial : Form
    {
        private List<MaterialModel> listOfMaterials  = GlobalStuff.Connector.GetAllMaterials();
        private List<MaterialModel> selectedMaterials = new List<MaterialModel>();

        private PropertyInfo[] propertiesInfo;//this is for sorting
        private bool sortOrderIsDescending;

        public CreateMaterial()
        {
            InitializeComponent();
            WireUpLists();
            this.MinimumSize = this.Size;

            propertiesInfo = typeof(MaterialModel).GetProperties();

        }

        private void WireUpLists()
        {
            bool temp = columnsRadioButton.Checked;
            rowsRadioButton.Checked = true;
            materialsDataGridView.DataSource = null;
            materialsDataGridView.DataSource = listOfMaterials.GetRange(0,listOfMaterials.Count);
            materialsDataGridView.Columns[0].Visible = false;
            materialsDataGridView.Columns[4].Visible = false;
            foreach (DataGridViewColumn column in materialsDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            columnsRadioButton.Checked = temp;
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

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (materialsDataGridView.SelectedColumns.Count == 1)
            {
                List<MaterialModel> searchedMaterials = new List<MaterialModel>();
                int columnId = materialsDataGridView.SelectedColumns[0].Index;
                foreach (DataGridViewRow row in materialsDataGridView.Rows)
                {
                    if (row.Cells[columnId].Value.ToString().Contains(searchBox.Text))
                    {
                        searchedMaterials.Add(listOfMaterials.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault());
                    }
                }

                rowsRadioButton.Checked = true;
                materialsDataGridView.DataSource = null;
                materialsDataGridView.DataSource = searchedMaterials.GetRange(0, searchedMaterials.Count);
                materialsDataGridView.Columns[0].Visible = false;
                materialsDataGridView.Columns[4].Visible = false;
                foreach (DataGridViewColumn column in materialsDataGridView.Columns)
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
            materialsDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void columnsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            materialsDataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (materialsDataGridView.SelectedColumns.Count == 1)
            {
                string columnName = materialsDataGridView.SelectedColumns[0].HeaderText;
                PropertyInfo property = propertiesInfo.Where(x => x.Name.Trim() == columnName.Trim()).FirstOrDefault();
                if (sortOrderIsDescending)
                {
                    listOfMaterials = listOfMaterials.OrderBy(x => property.GetValue(x)).ToList();
                    sortOrderIsDescending = false;
                }
                else
                {
                    listOfMaterials = listOfMaterials.OrderByDescending(x => property.GetValue(x)).ToList();
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
