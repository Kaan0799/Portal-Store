using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public char CustomerFirstName { get; set; }
        public char CustomerLastName { get; set; }
        public char CustomerEmail { get; set; }
        public int CustomerTcId { get; set; }
        public int CustomerBirthDate { get; set; }
        public char CustomerGsm { get; set; }
        public bool CustomerStatus { get; set; }
        public DateTime CustomerCreationDate { get; set; }
    }
}
