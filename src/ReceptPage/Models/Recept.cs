using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    [Table("Recepts")]
    public class Recept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Ingredients { get; set; }
        public string HowToDo { get; set; }
    }
}
