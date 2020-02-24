using System;
namespace IQService.Models
{
    public class ServiceDate
    {
        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
