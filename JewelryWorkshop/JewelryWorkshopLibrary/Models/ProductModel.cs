namespace JewelryWorkshopLibrary.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public ProductTypeModel ProductType { get; set; }

        public decimal ProductPrice { get; set; }

        public List<MaterialModel> ProductComposition { get; set; }

        public List<JewelryTechniqueModel> ProductProcessing { get; set; }

        public int Quantity { get; set; }

        public string ProductNameAndProductPrice 
        {
            get
            {
                return $"{ProductName} - {ProductPrice:C2}";
            } 
        }

        public string ProductNameAndQuantity
        {
            get
            {
                return $"{ProductName} - {Quantity}x";//Wedding Ring - 1x
            }
        }
    }
}