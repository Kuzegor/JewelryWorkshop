using JewelryWorkshop;
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
    public partial class ViewProducts : Form
    {
        private List<ProductTypeModel> typesForFiltering = GlobalStuff.Connector.GetAllTypes();
        private List<ProductModel> allProducts = GlobalStuff.Connector.GetAllProducts();
        private List<ProductModel> productsToShow;
        private List<ProductModel> selectedProducts;

        IViewProductsCaller callingForm;
        public ViewProducts(IViewProductsCaller callingForm)
        {
            InitializeComponent();
            LoadNullType();
            WireUpListOfTypes();
            WireUpListsOfProducts();
            this.callingForm = callingForm;

            if (callingForm == null)
            {
                addSelectedToOrderListButton.Visible = false;
            }

            this.MinimumSize = this.Size;

            cheapFirstRadioButton.Checked = true;

            GlobalStuff.Connector.OnTypeCreated += Connector_OnTypeCreated;
            GlobalStuff.Connector.OnTypesDeleted += Connector_OnTypesDeleted;
            GlobalStuff.Connector.OnTypesUpdated += Connector_OnTypesUpdated;
            GlobalStuff.Connector.OnMaterialsUpdated += Connector_OnMaterialsUpdated;
            GlobalStuff.Connector.OnTechniquesUpdated += Connector_OnTechniquesUpdated;
            GlobalStuff.Connector.OnProductCreated += Connector_OnProductCreated;
            GlobalStuff.Connector.OnProductUpdated += Connector_OnProductUpdated;
        }

        private void Connector_OnProductUpdated(object? sender, EventArgs e)
        {
            WireUpListOfTypes();
            WireUpListsOfProducts();
        }
        private void Connector_OnTechniquesUpdated(object? sender, List<JewelryTechniqueModel> techniqueModels)
        {
            List<ProductModel> productsToUpdate = new List<ProductModel>();
            foreach (JewelryTechniqueModel techniqueModel in techniqueModels)
            {
                foreach (ProductModel product in allProducts)
                {
                    foreach (JewelryTechniqueModel technique in product.ProductProcessing)
                    {
                        if (technique.Id == techniqueModel.Id)
                        {
                            product.ProductPrice -= Decimal.Multiply(technique.Price, Convert.ToDecimal(technique.Amount));
                            technique.Price = techniqueModel.Price;
                            product.ProductPrice += Decimal.Multiply(technique.Price, Convert.ToDecimal(technique.Amount));
                            productsToUpdate.Add(product);
                        }
                    }
                }
            }
            GlobalStuff.Connector.UpdateProductPrices(productsToUpdate);
            WireUpListsOfProducts();
        }
        private void Connector_OnMaterialsUpdated(object? sender, List<MaterialModel> materialModels)
        {
            List<ProductModel> productsToUpdate = new List<ProductModel>();
            foreach (MaterialModel materialModel in materialModels)
            {
                foreach (ProductModel product in allProducts)
                {
                    foreach (MaterialModel material in product.ProductComposition)
                    {
                        if (material.Id == materialModel.Id)
                        {
                            product.ProductPrice -= Decimal.Multiply(material.Price,Convert.ToDecimal(material.Amount));
                            material.Price = materialModel.Price;
                            product.ProductPrice += Decimal.Multiply(material.Price, Convert.ToDecimal(material.Amount));
                            productsToUpdate.Add(product);
                        }
                    }
                }
            }
            GlobalStuff.Connector.UpdateProductPrices(productsToUpdate);
            WireUpListsOfProducts();
        }
        private void Connector_OnTypesUpdated(object? sender, List<ProductTypeModel> updatedTypes)
        {
            foreach (ProductTypeModel type in updatedTypes)
            {
                ProductTypeModel typeToUpdate = typesForFiltering.Where(x => x.Id == type.Id).FirstOrDefault();
                if (typeToUpdate != null)
                {
                    typeToUpdate.TypeName = type.TypeName;
                }      
            }
            WireUpListOfTypes();
        }
        private void Connector_OnProductCreated(object? sender, ProductModel productModel)
        {
            allProducts.Add(productModel);
            WireUpListsOfProducts();
        }
        private void Connector_OnTypesDeleted(object? sender, List<ProductTypeModel> deletedTypes)
        {
            foreach (ProductTypeModel type in deletedTypes)
            {
                typesForFiltering.Remove(typesForFiltering.Where(x => x.Id == type.Id).FirstOrDefault());
                foreach (ProductModel product in allProducts)
                {
                    if (product.ProductType != null && product.ProductType.Id == type.Id)
                    {
                        product.ProductType = null;
                    }
                }
            }
            WireUpListOfTypes();
            WireUpListsOfProducts();
        }
        private void Connector_OnTypeCreated(object? sender, ProductTypeModel createdType)
        {
            typesForFiltering.Add(createdType);
            WireUpListOfTypes();
        }

        private void LoadNullType()
        {
            ProductTypeModel nullType = new ProductTypeModel();
            nullType.Id = 0;
            nullType.TypeName = "<type not defined>";
            typesForFiltering.Add(nullType);
        }
        private void WireUpListOfTypes() 
        {
            typeComboBox.DataSource = null;
            typeComboBox.DataSource = typesForFiltering;
            typeComboBox.DisplayMember = "TypeName";
        }
        private void WireUpListsOfProducts()
        {
            productsToShow = new List<ProductModel>();
            ProductTypeModel selectedType = typeComboBox.SelectedItem as ProductTypeModel;
            if (selectedType != null)
            {
                foreach (ProductModel product in allProducts)
                {                   
                    if (product.ProductType != null && product.ProductType.Id == selectedType.Id)
                    {
                        productsToShow.Add(product);
                    }
                    else if (product.ProductType == null && selectedType.Id == 0)
                    {
                        productsToShow.Add(product);
                    }
                }
            }
            productsListBox.DataSource = null;
            productsListBox.DataSource = productsToShow;
            productsListBox.DisplayMember = "ProductNameAndProductPrice";
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            WireUpListsOfProducts();
        }

        private void createNewProductButton_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.Show();
        }

        private void deleteSelectedButton_Click(object sender, EventArgs e)
        {
            selectedProducts = new List<ProductModel>();
            foreach (ProductModel product in productsListBox.SelectedItems)
            {
                selectedProducts.Add(product);
                allProducts.Remove(product);
            }
            GlobalStuff.Connector.DeleteProducts(selectedProducts);
            WireUpListsOfProducts();
        }

        private void viewSelectedButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItems.Count == 1)
            {
                ViewProduct viewProduct = new ViewProduct((ProductModel)productsListBox.SelectedItem);
                viewProduct.Show(); 
            }
            else
            {
                MessageBox.Show("You should select one product to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void addSelectedToOrderListButton_Click(object sender, EventArgs e)
        {
            if (productsListBox.SelectedItems.Count == 1)
            {
                ProductModel selectedProduct = (ProductModel)productsListBox.SelectedItem;
                SetQuantity setQuantity = new SetQuantity(callingForm, selectedProduct);
                setQuantity.Show();                
            }
            else
            {
                MessageBox.Show("You should select one product to proceed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<ProductModel> searchedProducts = new List<ProductModel>();
            foreach (ProductModel product in productsToShow)
            {
                if (product.ProductName.Contains(searchBox.Text))
                {
                    searchedProducts.Add(productsToShow.Where(x => x.Id == product.Id).FirstOrDefault());
                }
            }

            productsListBox.DataSource = null;
            productsListBox.DataSource = searchedProducts;
            productsListBox.DisplayMember = "ProductNameAndProductPrice";
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            WireUpListsOfProducts();
        }

        private void cheapFirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productsToShow = productsToShow.OrderBy(x => x.ProductPrice).ToList();
            productsListBox.DataSource = null;
            productsListBox.DataSource = productsToShow;
            productsListBox.DisplayMember = "ProductNameAndProductPrice";
        }

        private void expensiveFirstRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            productsToShow = productsToShow.OrderByDescending(x => x.ProductPrice).ToList();
            productsListBox.DataSource = null;
            productsListBox.DataSource = productsToShow;
            productsListBox.DisplayMember = "ProductNameAndProductPrice";
        }
    }
}
