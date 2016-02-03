using ReceptPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public interface IRecipeRepository
    {
        void AddRecipe(CreateRecipeViewModel viewModel);
        ListRecipeViewModel[] GetAllRecipes();
        void Delete(int id);
        EditRecipeViewModel Edit(int id);
        void Edit(EditRecipeViewModel editModel);
    }
}
