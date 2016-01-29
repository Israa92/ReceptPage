using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ReceptPage.Controllers
{
    public class ExceptionsController : Controller
    {
        ILogger<ExceptionsController> _logger;
        public ExceptionsController(ILogger<ExceptionsController> logger)
        {
            _logger = logger;
        }

        public IActionResult ErrorPage()
        {
            _logger.LogError("Ett fel har inträffat");
            return View();
        }
        public IActionResult PageNotFound404()
        {
            return View();
        }
    }
}
