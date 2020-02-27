using System;
using System.Collections.Generic;

namespace IQService.Models
{
    public class Payment
    {
        public int  Id { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }

        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
