using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryWorkshopLibrary.Models
{
    public class MaterialModel
    {
        public int Id { get; set; }

        public string MaterialName { get; set; }

        public decimal Price { get; set; }

        public string Unit { get; set; }

        public double Amount { get; set; }
    }
}
