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
    public partial class CreateProduct : Form
    {
        private List<ProductTypeModel> listOfTypes = GlobalStuff.Connector.GetAllTypes();
        private List<MaterialModel> listOfMaterials = GlobalStuff.Connector.GetAllMaterials();
        private List<JewelryTechniqueModel> listOfTechniques = GlobalStuff.Connector.GetAllTechniques();
        private List<MaterialModel> addedMaterials = new List<MaterialModel>();
        private List<JewelryTechniqueModel> addedTechniques = new List<JewelryTechniqueModel>();

        private ProductModel productModel = new ProductModel();

        public CreateProduct()
        {
            InitializeComponent();
            WireUpLists();
            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";

            SubscribeToEvents();
        }

        public CreateProduct(ProductModel productToEdit)
        {
            InitializeComponent();

            productModel = productToEdit;
            productNameTextBox.Text = productModel.ProductName;
            addedMaterials = productModel.ProductComposition;
            addedTechniques = productModel.ProductProcessing;
            foreach (MaterialModel material in productModel.ProductComposition)
            {
                MaterialModel materialToRemove = listOfMaterials.Where(x => x.Id == material.Id).FirstOrDefault();
                listOfMaterials.Remove(materialToRemove);
            }
            foreach (JewelryTechniqueModel technique in productModel.ProductProcessing)
            {
                JewelryTechniqueModel techniqueToRemove = listOfTechniques.Where(x => x.Id == technique.Id).FirstOrDefault();
                listOfTechniques.Remove(techniqueToRemove);
            }

            WireUpLists();
            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";

            createProductButton.Text = "Submit Changes";
            headerLabel.Text = "Product Editor";

            if (productModel.ProductType != null)
            {
                productTypeComboBox.SelectedValue = productModel.ProductType.Id;
            }
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            GlobalStuff.Connector.OnTypeCreated += Connector_OnTypeCreated;
            GlobalStuff.Connector.OnTypesDeleted += Connector_OnTypesDeleted;
            GlobalStuff.Connector.OnTypesUpdated += Connector_OnTypesUpdated;
            GlobalStuff.Connector.OnMaterialCreated += Connector_OnMaterialCreated;
            GlobalStuff.Connector.OnMaterialsDeleted += Connector_OnMaterialsDeleted;
            GlobalStuff.Connector.OnMaterialsUpdated += Connector_OnMaterialsUpdated;
            GlobalStuff.Connector.OnTechniqueCreated += Connector_OnTechniqueCreated;
            GlobalStuff.Connector.OnTechniquesDeleted += Connector_OnTechniquesDeleted;
            GlobalStuff.Connector.OnTechniquesUpdated += Connector_OnTechniquesUpdated;
        }
        private void Connector_OnTechniquesUpdated(object? sender, List<JewelryTechniqueModel> techniqueModels)
        {
            foreach (JewelryTechniqueModel techniqueModel in techniqueModels)
            {
                JewelryTechniqueModel techniqueToUpdatete = listOfTechniques.Where(x => x.Id == techniqueModel.Id).FirstOrDefault();
                if (techniqueToUpdatete != null)
                {
                    listOfTechniques.Remove(techniqueToUpdatete);
                    listOfTechniques.Add(techniqueModel);
                    WireUpTechniquesList();
                }
                else
                {
                    JewelryTechniqueModel techniqueToUpdateSecondCase = addedTechniques.Where(x => x.Id == techniqueModel.Id).FirstOrDefault();
                    addedTechniques.Remove(techniqueToUpdateSecondCase);
                    listOfTechniques.Add(techniqueModel);
                    WireUpdAddedTechniquesList();
                    WireUpTechniquesList();

                    productModel.ProductPrice -= Decimal.Multiply(techniqueToUpdateSecondCase.Price, Convert.ToDecimal(techniqueToUpdateSecondCase.Amount));
                    productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
                }
            }
        }
        private void Connector_OnMaterialsUpdated(object? sender, List<MaterialModel> materialModels)
        {
            foreach (MaterialModel materialModel in materialModels)
            {
                MaterialModel materialToUpdatete = listOfMaterials.Where(x => x.Id == materialModel.Id).FirstOrDefault();
                if (materialToUpdatete != null)
                {
                    listOfMaterials.Remove(materialToUpdatete);
                    listOfMaterials.Add(materialModel);
                    WireUpMaterialsList();
                }
                else
                {
                    MaterialModel materialToUpdateSecondCase = addedMaterials.Where(x => x.Id == materialModel.Id).FirstOrDefault();
                    addedMaterials.Remove(materialToUpdateSecondCase);
                    listOfMaterials.Add(materialModel);
                    WireUpdAddedMaterialsList();
                    WireUpMaterialsList();

                    productModel.ProductPrice -= Decimal.Multiply(materialToUpdateSecondCase.Price, Convert.ToDecimal(materialToUpdateSecondCase.Amount));
                    productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
                }
            }
        }
        private void Connector_OnTypesUpdated(object? sender, List<ProductTypeModel> typeModels)
        {
            foreach (ProductTypeModel typeModel in typeModels)
            {
                listOfTypes.Remove(listOfTypes.Where(x => x.Id == typeModel.Id).FirstOrDefault());
                listOfTypes.Add(typeModel);
            }
            WireUpTypesList();
        }
        private void Connector_OnTechniquesDeleted(object? sender, List<JewelryTechniqueModel> techniqueModels)
        {
            foreach (JewelryTechniqueModel techniqueModel in techniqueModels)
            {
                JewelryTechniqueModel techniqueToDelete = listOfTechniques.Where(x => x.Id == techniqueModel.Id).FirstOrDefault();
                if (techniqueToDelete != null)
                {
                    listOfTechniques.Remove(techniqueToDelete);
                    WireUpTechniquesList();
                }
                else
                {
                    JewelryTechniqueModel techniqueToDeleteSecondCase = addedTechniques.Where(x => x.Id == techniqueModel.Id).FirstOrDefault();
                    addedTechniques.Remove(techniqueToDeleteSecondCase);
                    WireUpdAddedTechniquesList();

                    productModel.ProductPrice -= Decimal.Multiply(techniqueToDeleteSecondCase.Price, Convert.ToDecimal(techniqueToDeleteSecondCase.Amount));
                    productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
                } 
            }
        }
        private void Connector_OnTechniqueCreated(object? sender, JewelryTechniqueModel techniqueModel)
        {
            listOfTechniques.Add(techniqueModel);
            WireUpTechniquesList();
        }
        private void Connector_OnMaterialsDeleted(object? sender, List<MaterialModel> materialModels)
        {
            foreach (MaterialModel materialModel in materialModels)
            {
                MaterialModel materialToDelete = listOfMaterials.Where(x => x.Id == materialModel.Id).FirstOrDefault();
                if (materialToDelete != null)
                {
                    listOfMaterials.Remove(materialToDelete);
                    WireUpMaterialsList();
                }
                else
                {
                    MaterialModel materialToDeleteSecondCase = addedMaterials.Where(x => x.Id == materialModel.Id).FirstOrDefault();
                    addedMaterials.Remove(materialToDeleteSecondCase);
                    WireUpdAddedMaterialsList();

                    productModel.ProductPrice -= Decimal.Multiply(materialToDeleteSecondCase.Price, Convert.ToDecimal(materialToDeleteSecondCase.Amount));
                    productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
                } 
            }
        }
        private void Connector_OnMaterialCreated(object? sender, MaterialModel materialModel)
        {
            listOfMaterials.Add(materialModel);
            WireUpMaterialsList();
        }
        private void Connector_OnTypesDeleted(object? sender, List<ProductTypeModel> typeModels)
        {
            foreach (ProductTypeModel typeModel in typeModels)
            {
                listOfTypes.Remove(typeModel);
            }     
            WireUpTypesList();
        }
        private void Connector_OnTypeCreated(object? sender, ProductTypeModel typeModel)
        {
            listOfTypes.Add(typeModel);
            WireUpTypesList();
        }

        private void WireUpLists()
        {
            WireUpTypesList();
            WireUpMaterialsList();
            WireUpTechniquesList();
            WireUpdAddedMaterialsList();
            WireUpdAddedTechniquesList();
        }
        private void WireUpTypesList()
        {
            productTypeComboBox.DataSource = null;
            productTypeComboBox.DataSource = listOfTypes;
            productTypeComboBox.DisplayMember = "TypeName";
            productTypeComboBox.ValueMember = "Id";
        }
        private void WireUpMaterialsList()
        {
            materialComboBox.DataSource = null;
            materialComboBox.DataSource = listOfMaterials;
            materialComboBox.DisplayMember = "MaterialName";
        }
        private void WireUpTechniquesList()
        {
            techniqueComboBox.DataSource = null;
            techniqueComboBox.DataSource = listOfTechniques;
            techniqueComboBox.DisplayMember = "TechniqueName";
        }
        private void WireUpdAddedMaterialsList()
        {
            addedMaterialsDataGridView.DataSource = null;
            addedMaterialsDataGridView.DataSource = addedMaterials.GetRange(0,addedMaterials.Count);
            if (addedMaterialsDataGridView.Columns.Count > 0)
            {
                addedMaterialsDataGridView.Columns[0].Visible = false;
                addedMaterialsDataGridView.Columns[2].Visible = false; 
            }
        }
        private void WireUpdAddedTechniquesList()
        {
            addedTechniquesDataGridView.DataSource = null;
            addedTechniquesDataGridView.DataSource = addedTechniques.GetRange(0,addedTechniques.Count);
            if (addedTechniquesDataGridView.Columns.Count > 0)
            {
                addedTechniquesDataGridView.Columns[0].Visible = false;
                addedTechniquesDataGridView.Columns[2].Visible = false; 
            }
        }

        private void newProductTypeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateType createType = new CreateType();
            createType.Show();
        }
        private void newMaterialLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateMaterial createMaterial = new CreateMaterial();
            createMaterial.Show();
        }
        private void newTechniqueLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTechnique createTechnique = new CreateTechnique();
            createTechnique.Show();
        }

        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MaterialModel display = (MaterialModel)materialComboBox.SelectedItem;
            if (display!=null)
            {
                materialUnitLabel.Text = $"Unit: {display.Unit}";
            }
        }
        private void techniqueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            JewelryTechniqueModel display = (JewelryTechniqueModel)techniqueComboBox.SelectedItem;
            if (display!=null)
            {
                techniqueUnitLabel.Text = $"Unit: {display.Unit}";
            }
        }

        private void addMaterialButton_Click(object sender, EventArgs e)
        {
            MaterialModel material = (MaterialModel)materialComboBox.SelectedItem;
            if (double.TryParse(materialAmountTextBox.Text, out double amount))
            {
                material.Amount = amount;
            }
            else
            {
                MessageBox.Show("Please enter valid amount of material", "Material Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            addedMaterials.Add(material);
            listOfMaterials.Remove(material);
            materialAmountTextBox.Clear();
            WireUpdAddedMaterialsList();
            WireUpMaterialsList();

            productModel.ProductPrice += Decimal.Multiply(Convert.ToDecimal(amount),material.Price);
            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
        }
        private void addTechniqueButton_Click(object sender, EventArgs e)
        {
            JewelryTechniqueModel technique = (JewelryTechniqueModel)techniqueComboBox.SelectedItem;
            if (double.TryParse(techniqueAmountTextBox.Text, out double amount))
            {
                technique.Amount = amount;
            }
            else
            {
                MessageBox.Show("Please enter valid amount for technique application", "Technique Application Amount", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            addedTechniques.Add(technique);
            listOfTechniques.Remove(technique);
            techniqueAmountTextBox.Clear();
            WireUpdAddedTechniquesList();
            WireUpTechniquesList();

            productModel.ProductPrice += Decimal.Multiply(Convert.ToDecimal(amount), technique.Price);
            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
        }

        private void removeMaterialsButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addedMaterialsDataGridView.SelectedRows)
            {
                MaterialModel materialToRemove = addedMaterials.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).First();
                addedMaterials.Remove(materialToRemove);
                listOfMaterials.Add(materialToRemove);

                productModel.ProductPrice -= Decimal.Multiply(Convert.ToDecimal(materialToRemove.Amount), materialToRemove.Price);
            }
            WireUpdAddedMaterialsList();
            WireUpMaterialsList();

            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
        }
        private void removeTechniquesButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in addedTechniquesDataGridView.SelectedRows)
            {
                JewelryTechniqueModel techniqueToRemove = addedTechniques.Where(x => x.Id == int.Parse(row.Cells[0].Value.ToString())).First();
                addedTechniques.Remove(techniqueToRemove);
                listOfTechniques.Add(techniqueToRemove);

                productModel.ProductPrice -= Decimal.Multiply(Convert.ToDecimal(techniqueToRemove.Amount), techniqueToRemove.Price);
            }
            WireUpdAddedTechniquesList();
            WireUpTechniquesList();

            productPriceLabel.Text = $"Product Price: {productModel.ProductPrice:C2}";
        }

        private void createProductButton_Click(object sender, EventArgs e)
        {
            if (productNameTextBox.Text.Length > 0)
            {
                productModel.ProductName = productNameTextBox.Text;
            }
            else
            {
                MessageBox.Show("Product must have a name", "Product Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            productModel.ProductType = (ProductTypeModel)productTypeComboBox.SelectedItem;
            productModel.ProductComposition = addedMaterials;
            productModel.ProductProcessing = addedTechniques;


            if (createProductButton.Text == "Submit Changes" || headerLabel.Text == "Product Editor")
            {
                GlobalStuff.Connector.UpdateProduct(productModel);
                this.Close();
                MessageBox.Show("The Product has been updated, check the catalogue", "Updated Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                GlobalStuff.Connector.CreateProduct(productModel);
                this.Close();
                MessageBox.Show("The Product has been created, check the catalogue", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
