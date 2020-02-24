using System;
namespace IQService.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public DateTime QuoteDate { get; set; }

        public Service Service { get; set; }
    }
}
