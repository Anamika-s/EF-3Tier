using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int QtyInStock { get; set; }
        public DateTime LastUpdated { get; set; }

        //Foreign Key (One to many)
        public Supplier Supplier { get; set; }
    }
}
