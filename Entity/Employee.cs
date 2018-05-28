using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Employee
    {
        [Key]
        public int UserId { get; set; }
        public string First_Name { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }

    }
}
