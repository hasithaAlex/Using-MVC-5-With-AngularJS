using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5WithAngular.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name is requied.")]
        [MinLength(5)]
        public String Name { get; set; }
        public float Price { get; set; }
    }
}