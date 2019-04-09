using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineBook.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WineBook.Controllers
{
    public class BreweryController : Controller
    {
        public IActionResult GetBreweryPartialView([Bind("Producer", "Brewery", "Winery")] ProducerViewModel producerViewModel)
        {
            producerViewModel.Brewery = new Brewery();
            return PartialView("_BreweryCreatePartial", producerViewModel);
            }
    }
}
