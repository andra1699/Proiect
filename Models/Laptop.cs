using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect.Models
{
    public class Laptop
    {
        public int ID { get; set; }
        

        public string Processor { get; set; }
        public string DiskSpace { get; set; }
        public string GraphicsCard { get; set; }
        [Display(Name = "Denumire")]
        public string Name { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }


        public int BrandID { get; set; }
        public Brand Brand { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
