using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class RecipeTestRepository : IRecipeRepository
    {
        RecipesContext _context;
        static List<Recipe> recipes = new List<Recipe>();

        public RecipeTestRepository(RecipesContext context)
        {
            _context = context;

            recipes.Add(new Recipe { Id = 1, Name = "Boo", Age = 20, Email = "boo@hotmail.com", NameOfPlate = "Pasta", Ingredients = "Pasta", HowToDo = "Pasta" });
            recipes.Add(new Recipe { Id = 2, Name = "Ann", Age = 20, Email = "boo@hotmail.com", NameOfPlate = "Pasta", Ingredients = "Pasta", HowToDo = "Pasta" });
            recipes.Add(new Recipe { Id = 3, Name = "Lii", Age = 20, Email = "boo@hotmail.com", NameOfPlate = "Pasta", Ingredients = "Pasta", HowToDo = "Pasta" });
        }

        public ListRecipeViewModel[] GetAllRecipes()
        {
            return recipes
                .Select(r => new ListRecipeViewModel
                {
                    Name = r.Name,
                    NameOfPlate = r.NameOfPlate,
                    Ingredients = r.Ingredients,
                    HowToDo = r.HowToDo
                })
                .ToArray();
                
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

        public void DisplayRecipe(List<ListRecipeViewModel> viewModels)
        {
            var receptFromDB = _context.Recipes.ToArray();
            foreach (var recept in receptFromDB)
            {
                var viewModel = new ListRecipeViewModel();
                viewModel.Id = recept.Id;
                viewModel.Name = recept.Name;
                viewModel.NameOfPlate = recept.NameOfPlate;
                viewModel.Ingredients = recept.Ingredients;
                viewModel.HowToDo = recept.HowToDo;

                viewModels.Add(viewModel);
            }
        }
    }
}
