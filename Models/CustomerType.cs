﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IQService.Models
{
    public class CustomerType
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IList<Customer> Customers { get; set; }
    }
}
