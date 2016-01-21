using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class ListReceptViewModel
    {
        [Display(Name = "Namn")]
        public string Name { get; set; }
        [Display(Name = "Ingredienser")]
        public string Ingredients { get; set; }
        [Display(Name = "Gör så")]
        public string HowToDo { get; set; }
    }
}
