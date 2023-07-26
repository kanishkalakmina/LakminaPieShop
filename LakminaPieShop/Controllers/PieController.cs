using LakminaPieShop.Models;
using LakminaPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LakminaPieShop.Controllers
{
    public class PieController : Controller
    {
       
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        // constructure injection
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
           // ViewBag.CurrentCategory = "Cheese cakes";
           // return View(_pieRepository.AllPies);

            PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies,"Cheese cakes");
            return View(pieListViewModel);
        }
    }
}
