using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryWorkshopLibrary.Models
{
    public class JewelryTechniqueModel
    {
        public int Id { get; set; }

        public string TechniqueName { get; set; }

        public decimal Price { get; set; }

        public string Unit { get; set; }

        public double Amount { get; set; }
    }
}
