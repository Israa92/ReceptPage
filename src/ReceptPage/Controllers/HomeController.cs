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
        IRecipeRepository _repository;
        ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IRecipeRepository repository)
        {
            _repository = repository;
            _logger = logger;
        }
        public IActionResult Index()
        {
            //_logger.LogInformation("HomeController.Index called");
            //throw new Exception("FEL");
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

            _repository.AddRecipe(viewModel);
            return RedirectToAction("published", "Recipes");
        }
    }
}
