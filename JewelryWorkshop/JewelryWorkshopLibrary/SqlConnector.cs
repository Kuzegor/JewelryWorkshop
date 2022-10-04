using JewelryWorkshopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace JewelryWorkshopLibrary
{
    public class SqlConnector
    {
        private const string connectionStringName = "JewelryWorkshop";

        public event EventHandler<ProductTypeModel> OnTypeCreated;
        public event EventHandler<List<ProductTypeModel>> OnTypesDeleted;
        public event EventHandler<List<ProductTypeModel>> OnTypesUpdated;
        public event EventHandler<MaterialModel> OnMaterialCreated;
        public event EventHandler<List<MaterialModel>> OnMaterialsDeleted;
        public event EventHandler<List<MaterialModel>> OnMaterialsUpdated;
        public event EventHandler<JewelryTechniqueModel> OnTechniqueCreated;
        public event EventHandler<List<JewelryTechniqueModel>> OnTechniquesDeleted;
        public event EventHandler<List<JewelryTechniqueModel>> OnTechniquesUpdated;
        public event EventHandler<ClientModel> OnClientCreated;
        public event EventHandler<List<ClientModel>> OnClientsDeleted;
        public event EventHandler<List<ClientModel>> OnClientsUpdated;
        public event EventHandler<ProductModel> OnProductCreated;
        public event EventHandler OnProductUpdated;
        public event EventHandler<OrderModel> OnOrderCreated;
        public event EventHandler OnOrderCompletionStatusChanged;

        public void UpdateProduct(ProductModel productModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductName", productModel.ProductName);
                parameters.Add("@ProductTypeId", productModel.ProductType.Id);
                parameters.Add("@ProductPrice", productModel.ProductPrice);
                parameters.Add("@id", productModel.Id);
                connection.Execute("dbo.spProducts_UpdateById", parameters, commandType: CommandType.StoredProcedure);

                InsertIntoCompositionAndProcessing(productModel, connection);
            }
            OnProductUpdated?.Invoke(this, EventArgs.Empty);
        }
        public void UpdateProductPrices(List<ProductModel> productModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();

                foreach (ProductModel productModel in productModels)
                {
                    parameters.Add("@ProductPrice", productModel.ProductPrice);
                    parameters.Add("@id", productModel.Id);
                    connection.Execute("dbo.spProducts_UpdatePriceById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
        }
        public void UpdateOrderCompletionStatus(OrderModel orderModel, bool orderIsComplete)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@OrderId", orderModel.Id);
                parameters.Add("@OrderIsComplete", orderIsComplete);
                connection.Execute("dbo.spOrders_UpdateCompletionStatus", parameters, commandType: CommandType.StoredProcedure);
            }
            OnOrderCompletionStatusChanged?.Invoke(this, EventArgs.Empty);
        }
        public void UpdateClients(List<ClientModel> clientModels)
        {
            using(IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (ClientModel clientModel in clientModels)
                {
                    parameters.Add("@LastName", clientModel.LastName);
                    parameters.Add("@FirstName", clientModel.FirstName);
                    parameters.Add("@MiddleName", clientModel.MiddleName);
                    parameters.Add("@Phone", clientModel.Phone);
                    parameters.Add("@id", clientModel.Id);
                    connection.Execute("dbo.spClients_UpdateById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
                OnClientsUpdated?.Invoke(this, clientModels);
            }
        }
        public void UpdateMaterials(List<MaterialModel> materialModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (MaterialModel materialModel in materialModels)
                {
                    parameters.Add("@MaterialName", materialModel.MaterialName);
                    parameters.Add("@Price", materialModel.Price);
                    parameters.Add("@Unit", materialModel.Unit);
                    parameters.Add("@id", materialModel.Id);
                    connection.Execute("dbo.spMaterials_UpdateById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
                OnMaterialsUpdated?.Invoke(this, materialModels);
            }
        }
        public void UpdateTechniques(List<JewelryTechniqueModel> techniqueModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (JewelryTechniqueModel techniqueModel in techniqueModels)
                {
                    parameters.Add("@TechniqueName", techniqueModel.TechniqueName);
                    parameters.Add("@Price", techniqueModel.Price);
                    parameters.Add("@Unit", techniqueModel.Unit);
                    parameters.Add("@id", techniqueModel.Id);
                    connection.Execute("dbo.spJewelryTechniques_UpdateById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnTechniquesUpdated?.Invoke(this, techniqueModels);
        }
        public void UpdateTypes(List<ProductTypeModel> typeModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (ProductTypeModel typeModel in typeModels)
                {
                    parameters.Add("@TypeName", typeModel.TypeName);
                    parameters.Add("@id", typeModel.Id);
                    connection.Execute("dbo.spProductTypes_UpdateById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnTypesUpdated?.Invoke(this, typeModels);
        }

        public void CreateOrder(OrderModel orderModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ClientId", orderModel.Client.Id);
                parameters.Add("@TotalPrice", orderModel.TotalPrice);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spOrders_Insert", parameters, commandType: CommandType.StoredProcedure);
                orderModel.Id = parameters.Get<int>("@id");

                foreach (ProductModel product in orderModel.OrderedProducts)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@OrderId", orderModel.Id);
                    parameters.Add("@ProductId", product.Id);
                    parameters.Add("@Quantity", product.Quantity);
                    connection.Execute("dbo.spOrderProducts_Insert", parameters, commandType: CommandType.StoredProcedure);
                }
            }
            OnOrderCreated?.Invoke(this,orderModel);
        }
        public void CreateProduct(ProductModel productModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductName", productModel.ProductName);
                parameters.Add("@ProductTypeId", productModel.ProductType.Id);
                parameters.Add("@ProductPrice", productModel.ProductPrice);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spProducts_Insert", parameters, commandType: CommandType.StoredProcedure);
                productModel.Id = parameters.Get<int>("@id");

                InsertIntoCompositionAndProcessing(productModel, connection);
            }
            OnProductCreated?.Invoke(this, productModel);
        }
        public void CreateMaterial(MaterialModel materialModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@MaterialName", materialModel.MaterialName);
                parameters.Add("@Price", materialModel.Price);
                parameters.Add("@Unit", materialModel.Unit);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spMaterials_Insert", parameters, commandType: CommandType.StoredProcedure);
                materialModel.Id = parameters.Get<int>("@id");
            }
            OnMaterialCreated?.Invoke(this, materialModel);
        }
        public void CreateTechnique(JewelryTechniqueModel techniqueModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TechniqueName", techniqueModel.TechniqueName);
                parameters.Add("@Price", techniqueModel.Price);
                parameters.Add("@Unit", techniqueModel.Unit);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spJewelryTechniques_Insert", parameters, commandType: CommandType.StoredProcedure);
                techniqueModel.Id = parameters.Get<int>("@id");
            }
            OnTechniqueCreated?.Invoke(this, techniqueModel);
        }
        public void CreateType(ProductTypeModel typeModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@TypeName", typeModel.TypeName);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spProductTypes_Insert",parameters, commandType: CommandType.StoredProcedure);
                typeModel.Id = parameters.Get<int>("@id");
            }
            OnTypeCreated?.Invoke(this, typeModel);
        }
        public void CreateClient(ClientModel clientModel)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@LastName", clientModel.LastName);
                parameters.Add("@FirstName", clientModel.FirstName);
                parameters.Add("@MiddleName", clientModel.MiddleName);
                parameters.Add("@Phone", clientModel.Phone);
                parameters.Add("@id", dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spClients_Insert", parameters, commandType: CommandType.StoredProcedure);
                clientModel.Id = parameters.Get<int>("@id");
            }
            OnClientCreated?.Invoke(this, clientModel);
        }

        public void DeleteOrders(List<OrderModel> orderModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (OrderModel order in orderModels)
                {
                    parameters.Add("@id", order.Id);
                    connection.Execute("dbo.spOrders_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
        }
        public void DeleteProducts(List<ProductModel> productModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (ProductModel product in productModels)
                {
                    parameters.Add("@id", product.Id);
                    connection.Execute("dbo.spProducts_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
        }
        public void DeleteMaterials(List<MaterialModel> materialModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (MaterialModel material in materialModels)
                {
                    parameters.Add("@id", material.Id);
                    connection.Execute("dbo.spMaterials_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnMaterialsDeleted?.Invoke(this, materialModels);
        }
        public void DeleteTechniques(List<JewelryTechniqueModel> techniqueModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (JewelryTechniqueModel technique in techniqueModels)
                {
                    parameters.Add("@id", technique.Id);
                    connection.Execute("dbo.spJewelryTechniques_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnTechniquesDeleted?.Invoke(this, techniqueModels);
        }
        public void DeleteTypes(List<ProductTypeModel> typeModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (ProductTypeModel type in typeModels)
                {
                    parameters.Add("@id",type.Id);
                    connection.Execute("dbo.spProductTypes_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnTypesDeleted?.Invoke(this, typeModels);
        }
        public void DeleteClients(List<ClientModel> clientModels)
        {
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                DynamicParameters parameters = new DynamicParameters();
                foreach (ClientModel client in clientModels)
                {
                    parameters.Add("@id", client.Id);
                    connection.Execute("dbo.spClients_DeleteById", parameters, commandType: CommandType.StoredProcedure);
                    parameters = new DynamicParameters();
                }
            }
            OnClientsDeleted?.Invoke(this, clientModels);
        }

        public List<OrderModel> GetAllOrders()
        {
            List<OrderModel> orders = new List<OrderModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                //Loading orders
                orders = connection.Query<OrderModel>("dbo.spOrders_GetAll", commandType: CommandType.StoredProcedure).ToList();

                DynamicParameters parameters;
                foreach (OrderModel order in orders)
                {
                    parameters = new DynamicParameters();
                    parameters.Add("@OrderId", order.Id);

                    //Getting client for one of the loaded orders
                    order.Client = connection.Query<ClientModel>("dbo.spClients_GetByOrderId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                    //Getting products for one of the loaded orders
                    order.OrderedProducts = connection.Query<ProductModel>("dbo.spProducts_GetByOrderId", parameters, commandType: CommandType.StoredProcedure).ToList();

                    //Getting types, compositions and processing of all products for one of the loaded orders
                    LoadProductsData(order.OrderedProducts, connection);
                }
            }
            return orders;
        }
        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> products = new List<ProductModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                //Loading products
                products = connection.Query<ProductModel>("dbo.spProducts_GetAll", commandType: CommandType.StoredProcedure).ToList();

                //Getting types, compositions and processing of the loaded products
                LoadProductsData(products, connection);
            }
            return products;
        }
        public List<MaterialModel> GetAllMaterials()
        {
            List<MaterialModel> materials = new List<MaterialModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                materials = connection.Query<MaterialModel>("dbo.spMaterials_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return materials;
        }
        public List<JewelryTechniqueModel> GetAllTechniques()
        {
            List<JewelryTechniqueModel> techniques = new List<JewelryTechniqueModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                techniques = connection.Query<JewelryTechniqueModel>("dbo.spJewelryTechniques_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return techniques;
        }
        public List<ProductTypeModel> GetAllTypes()
        {
            List<ProductTypeModel> types = new List<ProductTypeModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                types = connection.Query<ProductTypeModel>("dbo.spProductTypes_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return types;
        }
        public List<ClientModel> GetAllClients()
        {
            List<ClientModel> clients = new List<ClientModel>();
            using (IDbConnection connection = new SqlConnection(GlobalStuff.GetConnectionString(connectionStringName)))
            {
                clients = connection.Query<ClientModel>("dbo.spClients_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }
            return clients;
        }

        private void InsertIntoCompositionAndProcessing(ProductModel productModel, IDbConnection connection)
        {
            foreach (MaterialModel material in productModel.ProductComposition)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", productModel.Id);
                parameters.Add("@MaterialId", material.Id);
                parameters.Add("@Amount", material.Amount);
                connection.Execute("dbo.spProductComposition_Insert", parameters, commandType: CommandType.StoredProcedure);
            }

            foreach (JewelryTechniqueModel technique in productModel.ProductProcessing)
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@ProductId", productModel.Id);
                parameters.Add("@TechniqueId", technique.Id);
                parameters.Add("@Amount", technique.Amount);
                connection.Execute("dbo.spProductProcessing_Insert", parameters, commandType: CommandType.StoredProcedure);
            }
        }
        private void LoadProductsData(List<ProductModel> products, IDbConnection connection)
        {
            DynamicParameters parameters;
            foreach (ProductModel product in products)
            {
                parameters = new DynamicParameters();
                parameters.Add("@ProductId", product.Id);

                //Getting types of the loaded products
                product.ProductType = connection.Query<ProductTypeModel>("dbo.spProductTypes_GetByProductId", parameters, commandType: CommandType.StoredProcedure).FirstOrDefault();

                //Getting compositions of the loaded products
                product.ProductComposition = connection.Query<MaterialModel>("dbo.spMaterials_GetByProductId", parameters, commandType: CommandType.StoredProcedure).ToList();

                //Getting processing of the loaded products
                product.ProductProcessing = connection.Query<JewelryTechniqueModel>("dbo.spJewelryTechniques_GetByProductId", parameters, commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
