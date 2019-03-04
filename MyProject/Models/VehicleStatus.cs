using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class VehicleStatus
    {
        [Key]
        public int Id { get; set; }
        public string Status { get; set; }
        public virtual Vehicle Vehicle { get; set; }

    }
}