using BLL;
using DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ppo.Controllers
{
    public class CategorieController : Controller
    {
        private readonly CategorieServices _services;

        public CategorieController(CategorieServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View(_services.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Categorie newCategorie)
        {
            _services.Add(newCategorie);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var categorie = _services.GetCategorieById(id);
            if (categorie == null)
            {
                return NotFound();
            }
            return View(categorie);
        }

        [HttpPost]
        public IActionResult Update(Categorie updatedCategorie)
        {

                _services.Update(updatedCategorie);
                return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult delete(int id)
        {
            var categorie = _services.GetCategorieById(id);
            if (categorie == null)
            {
                return NotFound();
            }
            return View(categorie);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id) // Correction du nom de l'action Delete
        {
            _services.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var categorie = _services.GetCategorieById(id);
            if (categorie == null)
            {
                return NotFound();
            }
            return View(categorie);
        }
    }
}
