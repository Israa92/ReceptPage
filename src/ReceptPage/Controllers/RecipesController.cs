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
        IRecipeRepository _repository;
        public RecipesController(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Published(List<ListRecipeViewModel> viewModels)
        {

            _repository.DisplayRecipe(viewModels);
            return View(viewModels);

            //return View(_repository.GetAllRecipes());
        }

        public string Delete(int id)
        {
            return "Raderar id" + id;
        }
    }
}
