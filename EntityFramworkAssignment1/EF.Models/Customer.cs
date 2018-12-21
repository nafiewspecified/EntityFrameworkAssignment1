using System.Collections.Generic;

namespace EF.Models
{
    public class Customer
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public List<Product> ProductList { get; set; }
        public long ProductId { get; set; }
        
    }
}