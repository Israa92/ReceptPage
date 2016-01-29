using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using ReceptPage.Models;
using Microsoft.Extensions.Logging;

namespace ReceptPage.Controllers
{
    public class HomeController : Controller
    {
        RecipesContext _context;
        ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, RecipesContext context)
        {
            _context = context;
            _logger = logger;
        }
        
        public IActionResult Index()
        {
            //_logger.LogInformation("HomeController.Index called");
            throw new Exception("FEL");
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateRecipeViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            var recept = new Recipe();
            recept.Name = viewModel.Name;
            recept.Age = viewModel.Age;
            recept.Email = viewModel.Email;
            recept.NameOfPlate = viewModel.NameOfPlate;
            recept.Ingredients = viewModel.Ingredients;
            recept.HowToDo = viewModel.HowToDo;

            _context.Recepts.Add(recept);
            _context.SaveChanges();

            return RedirectToAction("published", "Recipes");
        }
    }
}
