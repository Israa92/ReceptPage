using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ReceptPage.Models;

namespace ReceptPage.Controllers
{
    [Route("Recipes")]
    public class RecipesController : Controller
    {
        RecipesContext _context;
        public RecipesController(RecipesContext context)
        {
            _context = context;
        }

        [Route("Published")]
        public IActionResult Published()
        {
            var receptFromDB = _context.Recepts.ToArray();
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

        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Recipe recipe = _context.Recepts.Find(id);
        //    if (recipe == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(recipe);
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Recipe recipe = _context.Recepts.Find(id);
        //    _context.Recepts.Remove(recipe);
        //    _context.SaveChanges();
        //    return RedirectToAction("published");
        //}
    }
}
