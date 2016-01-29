using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class RecipeDBRepository : IRecipeRepository
    {
        RecipesContext _context;
        public RecipeDBRepository(RecipesContext context)
        {
            _context = context;
        }

        public void AddRecipe(CreateRecipeViewModel viewModel)
        {
            var recipe = new Recipe();
            recipe.Name = viewModel.Name;
            recipe.Age = viewModel.Age;
            recipe.Email = viewModel.Email;
            recipe.NameOfPlate = viewModel.NameOfPlate;
            recipe.Ingredients = viewModel.Ingredients;
            recipe.HowToDo = viewModel.HowToDo;

            _context.Recipes.Add(recipe);
            _context.SaveChanges();
        }

        public void DisplayRecipe()
        {
            return;
        }
    }
}
