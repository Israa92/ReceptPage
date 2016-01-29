using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ReceptPage.Models;

namespace ReceptPage.Controllers
{
    public class RecipesController : Controller
    {
        RecipesContext _context;
        public RecipesController(RecipesContext context)
        {
            _context = context;
        }

        public IActionResult Published()
        {
            var receptFromDB = _context.Recipes.ToArray();
            var viewModels = new List<ListRecipeViewModel>();
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
            return View(viewModels);
        }

        public string Delete(int id)
        {
            return "Raderar id" + id;
        }
    }
}
