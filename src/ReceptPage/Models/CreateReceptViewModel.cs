using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class CreateReceptViewModel
    {
        [Display(Name= "Namn")]
        [Required (ErrorMessage ="Du behöver ett namn!")]
        public string Name { get; set; }
        [Display(Name= "Ålder")]
        [Range(18, 90, ErrorMessage ="Du måste vara över 18 år")]
        public int Age { get; set; }
        [Display(Name = "E-mail")]
        //[RegularExpression(@"[^\w\s]", ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
        [Display(Name = "Ingredienser")]
        [Required(ErrorMessage = "Vi behöver din ingredienser")]
        public string Ingredients { get; set; }
        [Display(Name = "Gör så")]
        [Required(ErrorMessage = "Vi behöver din sätt")]
        public string HowToDo { get; set; }
    }
}
