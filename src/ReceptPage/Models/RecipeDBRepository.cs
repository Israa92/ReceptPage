using ReceptPage.ViewModels;
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

        public ListRecipeViewModel[] GetAllRecipes()
        {
            return _context.Recipes
                .Select(r => new ListRecipeViewModel
                {
                    Id = r.Id,
                    Name = r.Name,
                    NameOfPlate = r.NameOfPlate,
                    Ingredients = r.Ingredients,
                    HowToDo = r.HowToDo
                })
                .ToArray();

        }

        public void Delete(int id)
        {
            Recipe recipe = _context.Recipes.FirstOrDefault(r => r.Id == id);

            _context
                .Recipes
                .Remove(recipe);

            _context.SaveChanges();
        }

        public EditRecipeViewModel Edit(int id)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.Id == id);
            return new EditRecipeViewModel
            {
                Name = recipe.Name,
                NameOfPlate = recipe.NameOfPlate,
                Ingredients = recipe.Ingredients,
                HowToDo = recipe.HowToDo
            };
            
        }

        public void Edit(EditRecipeViewModel editModel)
        {
            var recipe = _context.Recipes.FirstOrDefault(r => r.Id == editModel.Id);

            recipe.Name = editModel.Name;
            recipe.NameOfPlate = editModel.NameOfPlate;
            recipe.Ingredients = editModel.Ingredients;
            recipe.HowToDo = editModel.HowToDo;

            _context.SaveChanges();
        }
    }
}
