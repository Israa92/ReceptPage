using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ReceptPage.Models;
using ReceptPage.ViewModels;

namespace ReceptPage.Controllers
{
    public class RecipesController : Controller
    {
        IRecipeRepository _repository;
        public RecipesController(IRecipeRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Published()
        {
            return View(_repository.GetAllRecipes());
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Published");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.Edit(id));
        }

        [HttpPost]
        public IActionResult Edit(EditRecipeViewModel recipeModel)
        {
            _repository.Edit(recipeModel);
            return RedirectToAction("Published");
        }
    }
}
