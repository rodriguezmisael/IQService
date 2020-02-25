using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQService.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ServiceDate { get; set; }

        public virtual ServiceType ServiceType { get; set; }
        public virtual ServiceStatus ServiceStatus { get; set; }
        public virtual ICollection<CustomerService> CustomerServices { get; set; }
        public virtual ICollection<ServiceDate> ServiceDates { get; set; }
        public Quote Quote { get; set; }
        public Invoice Invoice { get; set; }
    }
}
