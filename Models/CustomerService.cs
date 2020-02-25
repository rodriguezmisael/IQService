using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQService.Models
{
    public class CustomerService
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public DateTime ServiceDate { get; set; }
        public string Description { get; set; }
    }
}
