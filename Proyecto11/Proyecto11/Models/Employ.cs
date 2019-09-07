using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto11.Models
{
    public class Employ
    {
        [key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required][Range(1,100000)]
        public int Salary { get; set; }
        [Required][DataTime]
        public int Birthday { get; set; }
        public string Note { get; set; }
    }
}