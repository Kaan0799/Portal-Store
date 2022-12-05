using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public char CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public DateTime CategoryCreationDate { get; set; }
        public List<Sku> Skus { get; set; }
    }
}
