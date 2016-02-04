using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.ViewModels
{
    public class EditRecipeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameOfPlate { get; set; }
        public string Ingredients { get; set; }
        public string HowToDo { get; set; }
    }
}
