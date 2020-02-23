using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQService.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual CustomerType CustomerType { get; set; }
        public bool IsActive { get; set; }
        public virtual CustomerStatus CustomerStatus { get; set; }
        public string PhysicalAddressLine1 { get; set; }
        public string PhysicalAddressLine2 { get; set; }
        public string PhysicalZipcode { get; set; }
        public string MailAddressLine1 { get; set; }
        public string MailAddressLine2 { get; set; }
        public string MailZipcode { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Fax { get; set; }

    }

}
