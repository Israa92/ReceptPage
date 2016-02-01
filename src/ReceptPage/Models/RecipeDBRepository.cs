﻿using System;
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
