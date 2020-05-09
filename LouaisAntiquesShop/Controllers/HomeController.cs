using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LouaisAntiquesShop.Models;
using LouaisAntiquesShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LouaisAntiquesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAntiqueRepository _antiqueRepository;
        public HomeController(IAntiqueRepository antiqueRepository)
        {
            _antiqueRepository = antiqueRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var antiques = _antiqueRepository.GetAllAntiques().OrderBy(a => a.Name);

            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to Louai's Antique Shop",
                Antiques = antiques.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Details(int id)
        {
            var antiqueItem = _antiqueRepository.GetAntiqueItemById(id);
            if (antiqueItem == null)
                return NotFound();

            return View(antiqueItem);
        }

    }
}
