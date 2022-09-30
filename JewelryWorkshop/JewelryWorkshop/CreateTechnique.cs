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
    public partial class CreateTechnique : Form
    {
        private List<JewelryTechniqueModel> listOfTechniques = GlobalStuff.Connector.GetAllTechniques();
        private List<JewelryTechniqueModel> selectedTechniques = new List<JewelryTechniqueModel>();

        public CreateTechnique()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            techniquesDataGridView.DataSource = null;
            techniquesDataGridView.DataSource = listOfTechniques.GetRange(0,listOfTechniques.Count);
            techniquesDataGridView.Columns[0].Visible = false;
            techniquesDataGridView.Columns[4].Visible = false;
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
    }
}
