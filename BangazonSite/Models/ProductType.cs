using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BangazonSite.Models
{
    public class ProductType
    {
        public int Id { get; set; }
        public string Category { get; set; }

        [NotMapped]
        public int Quantity { get; set; }
        public List<Product> Products { get; set; }
    }
}
