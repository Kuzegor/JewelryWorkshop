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
    public partial class CreateTechnique : Form
    {
        private List<JewelryTechniqueModel> listOfTechniques = GlobalStuff.Connector.GetAllTechniques();
        private List<JewelryTechniqueModel> selectedTechniques = new List<JewelryTechniqueModel>();

        private PropertyInfo[] propertiesInfo;//this is for sorting
        private bool sortOrderIsDescending;

        public CreateTechnique()
        {
            InitializeComponent();
            WireUpLists();

            this.MinimumSize = this.Size;

            propertiesInfo = typeof(JewelryTechniqueModel).GetProperties();
        }

        private void WireUpLists()
        {
            bool temp = columnsRadioButton.Checked;
            rowsRadioButton.Checked = true;
            techniquesDataGridView.DataSource = null;
            techniquesDataGridView.DataSource = listOfTechniques.GetRange(0,listOfTechniques.Count);
            techniquesDataGridView.Columns[0].Visible = false;
            techniquesDataGridView.Columns[4].Visible = false;
            foreach (DataGridViewColumn column in techniquesDataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            columnsRadioButton.Checked = temp;
        }

        private void createTechniqueButton_Click(object sender, EventArgs e)
        {
            JewelryTechniqueModel techniqueModel = new JewelryTechniqueModel();
            if (techniqueNameTextBox.Text.Length > 0)
            {
                techniqueModel.TechniqueName = techniqueNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter the name of the technique", "Technique Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (decimal.TryParse(techniquePriceTextBox.Text,out decimal price))
            {
                techniqueModel.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter valid price", "Technique Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (techniqueUnitTextBox.Text.Length > 0)
            {
                techniqueModel.Unit = techniqueUnitTextBox.Text;
            }
            else
            {
                MessageBox.Show("Please enter the unit in which the amount of technique application is measured",
                    "Technique Measurement Unit", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            GlobalStuff.Connector.CreateTechnique(techniqueModel);
            listOfTechniques.Add(techniqueModel);

            techniqueNameTextBox.Clear();
            techniquePriceTextBox.Clear();
            techniqueUnitTextBox.Clear();
            WireUpLists();
        }

        private void deleteSelectedTechniqueButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in techniquesDataGridView.SelectedRows)
            {
                JewelryTechniqueModel techniqueToDelete = listOfTechniques.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedTechniques.Add(techniqueToDelete);
                listOfTechniques.Remove(techniqueToDelete);
            }
            GlobalStuff.Connector.DeleteTechniques(selectedTechniques);
            WireUpLists();
        }

        private void saveSelectedButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in techniquesDataGridView.SelectedRows)
            {
                JewelryTechniqueModel techniqueToDelete = listOfTechniques.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault();
                selectedTechniques.Add(techniqueToDelete);
            }
            GlobalStuff.Connector.UpdateTechniques(selectedTechniques);
            WireUpLists();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (techniquesDataGridView.SelectedColumns.Count == 1)
            {
                List<JewelryTechniqueModel> searchedTechniques = new List<JewelryTechniqueModel>();
                int columnId = techniquesDataGridView.SelectedColumns[0].Index;
                foreach (DataGridViewRow row in techniquesDataGridView.Rows)
                {
                    if (row.Cells[columnId].Value.ToString().Contains(searchBox.Text))
                    {
                        searchedTechniques.Add(listOfTechniques.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).FirstOrDefault());
                    }
                }

                rowsRadioButton.Checked = true;
                techniquesDataGridView.DataSource = null;
                techniquesDataGridView.DataSource = searchedTechniques.GetRange(0, searchedTechniques.Count);
                techniquesDataGridView.Columns[0].Visible = false;
                techniquesDataGridView.Columns[4].Visible = false;
                foreach (DataGridViewColumn column in techniquesDataGridView.Columns)
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
            techniquesDataGridView.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
        }

        private void columnsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            techniquesDataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (techniquesDataGridView.SelectedColumns.Count == 1)
            {
                string columnName = techniquesDataGridView.SelectedColumns[0].HeaderText;
                PropertyInfo property = propertiesInfo.Where(x => x.Name == columnName).FirstOrDefault();
                if (sortOrderIsDescending)
                {
                    listOfTechniques = listOfTechniques.OrderBy(x => property.GetValue(x)).ToList();
                    sortOrderIsDescending = false;
                }
                else
                {
                    listOfTechniques = listOfTechniques.OrderByDescending(x => property.GetValue(x)).ToList();
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
