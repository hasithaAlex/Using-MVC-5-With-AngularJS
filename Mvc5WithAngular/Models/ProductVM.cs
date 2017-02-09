using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc5WithAngular.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string NameID { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}