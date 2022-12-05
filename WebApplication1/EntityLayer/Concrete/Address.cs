using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public char AddressLine { get; set; }
        public char AddressCountry { get; set; }
        public char AddressCity { get; set; }
        public char AddressDistrict { get; set; }
        public int AddressZipCode { get; set; }
        public bool AddressStatus { get; set; }
        public DateTime AddressCreationDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customers { get; set; }
    }
}
