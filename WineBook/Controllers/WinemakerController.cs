using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WineBook.Models;
using WineBook.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WineBook.Controllers
{
    public class WinemakerController : Controller
    {
        private readonly FermenteriaContext _context;

        public WinemakerController(FermenteriaContext context)
        {
            this._context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            string[] winemakerlist = 
                this._context.Wineries.Select(wm => wm.WineMakerName).Distinct().ToArray();

            return Json(winemakerlist);

        } 
        [HttpPost]
        public IActionResult Index(string Winemaker)
        {
            ViewData["Message"] = Winemaker;
            return View();
        }
    }
}
