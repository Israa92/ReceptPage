using ReceptPage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReceptPage.Models
{
    public class RecipeTestRepository : IRecipeRepository
    {
        static List<Recipe> recipes = new List<Recipe>();

        public RecipeTestRepository()
        {
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
            
        }

        public void Delete(int id)
        {
            Recipe recipe = recipes.FirstOrDefault(r => r.Id == id);
            // Radera
        }

        public EditRecipeViewModel Edit(int id)
        {
            var recipe = recipes.FirstOrDefault(r => r.Id == id);
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
            var recipe = recipes.FirstOrDefault(r => r.Id == editModel.Id);

            recipe.Name = editModel.Name;
            recipe.NameOfPlate = editModel.NameOfPlate;
            recipe.Ingredients = editModel.Ingredients;
            recipe.HowToDo = editModel.HowToDo;
        }

    }
}
