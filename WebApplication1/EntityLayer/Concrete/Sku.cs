using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Sku
    {
        [Key]
        public int SkuId { get; set; }
        public char SkuName { get; set; }
        public char SkuDescription { get; set; }
        public decimal SkuOldPrice { get; set; }
        public decimal SkuPrice { get; set; }       
        public bool SkuStatus { get; set; }
        public DateTime SkuCreationDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
