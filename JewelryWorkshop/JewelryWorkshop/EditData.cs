using JewelryWorkshop;
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
    public partial class EditData : Form
    {
        public EditData()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(null);
            viewProducts.Show();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            CreateClient createClient = new CreateClient();
            createClient.Show();
        }

        private void materialsButton_Click(object sender, EventArgs e)
        {
            CreateMaterial createMaterial = new CreateMaterial();
            createMaterial.Show();
        }

        private void techniquesButton_Click(object sender, EventArgs e)
        {
            CreateTechnique createTechnique = new CreateTechnique();
            createTechnique.Show();
        }

        private void productTypesButton_Click(object sender, EventArgs e)
        {
            CreateType createType = new CreateType();
            createType.Show();
        }
    }
}
