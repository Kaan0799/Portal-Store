using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }
        public decimal OrderItemUnitPrice { get; set; }
        public int OrderItemQuantity { get; set; }
        public bool OrderItemStatus { get; set; }
        public DateTime OrderItemCreationDate { get; set; }
        public int SkuId { get; set; }
        public Sku Skus { get; set; }
        public int OrderdId { get; set; }
        public Order Orders { get; set; }

    }

}
