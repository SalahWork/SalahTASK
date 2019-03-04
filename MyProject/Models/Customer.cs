using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Address { get; set; }
        public virtual List <Vehicle> Vehicles { get; set; }
    }
}