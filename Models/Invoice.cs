using System;
namespace IQService.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime InvoiceDate { get; set; }

        public Service Service { get; set; }
    }
}
