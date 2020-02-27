using System;
namespace IQService.Models
{
    public class CustomerPerson
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int  CustomerId { get; set; }
        public Customer Customer { get; set; }


    }
}
