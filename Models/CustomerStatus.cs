using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQService.Models
{
    public class CustomerStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
