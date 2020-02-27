using System;
namespace IQService.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string PaymentCode { get; set; }
        public string Description { get; set; }

        public Payment Payment { get; set; }
    }


}
