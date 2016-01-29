using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class ListRecipeViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Maträtt")]
        public string NameOfPlate { get; set; }

        [Display(Name = "Ingredienser")]
        public string Ingredients { get; set; }

        [Display(Name = "Gör så här")]
        public string HowToDo { get; set; }
    }
}
