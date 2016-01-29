using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public interface IRecipeRepository
    {
        void AddRecipe(CreateRecipeViewModel viewModel);
    }
}
