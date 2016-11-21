using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Model.Entity
{
    public sealed class Bill
    {
        [Key]
        public int id { get; set; }
        
        public DateTime date { get; set; }

        public string name { get; set; }

        public double money { get; set; }

        public int quantity { get; set; }


    }
}
