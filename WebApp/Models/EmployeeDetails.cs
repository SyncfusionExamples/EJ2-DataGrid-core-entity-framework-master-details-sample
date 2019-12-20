using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class EmployeeDetails
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int ItemNo { get; set; }
        public string ItemDetails { get; set; }
    }
}
