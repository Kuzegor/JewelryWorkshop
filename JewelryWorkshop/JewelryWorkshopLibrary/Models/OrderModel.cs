using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryWorkshopLibrary.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public ClientModel Client { get; set; }

        public string StartDate { get; set; }

        public List<ProductModel> OrderedProducts { get; set; }

        public bool OrderIsComplete { get; set; }

        public decimal TotalPrice { get; private set; }

        public void GetTotalPriceOfProducts(List<ProductModel> addedProducts)
        {
            decimal output = 0.0M;

            foreach (ProductModel product in addedProducts)
            {
                output += Decimal.Multiply(product.ProductPrice, Convert.ToDecimal(product.Quantity));
            }

            TotalPrice = output;
        }
    }
}
