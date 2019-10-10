using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrbanDevelopmentProj.Models
{
    public class AdminDetail
    {
        [Key]
        public int AdminID { get; set; } 
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string Department { get; set; }

    }
}
