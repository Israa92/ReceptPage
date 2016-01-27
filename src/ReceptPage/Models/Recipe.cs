using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    [Table("Recepts")]
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string NameOfPlate { get; set; }
        public string Ingredients { get; set; }
        public string HowToDo { get; set; }
    }
}
