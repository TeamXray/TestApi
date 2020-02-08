using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestApi.Models
{
    public class UsER
    { 

        [Key]
        public int id { get; set; }
        public String name { get; set; }
        public int MyProperty { get; set; }
        public int gg { get; set; }
    }
}
