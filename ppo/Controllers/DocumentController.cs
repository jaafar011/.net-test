using BLL;
using DAL.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ppo.Controllers
{
    public class DocumentController : Controller
    {
        private readonly DocumentssServices _services;

        public DocumentController(DocumentssServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            return View(_services.GetAll());
        }

        [HttpGet] // Ajoutez l'attribut [HttpGet] pour indiquer que c'est une action GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Documentss newDocument)
        {
            _services.Ajouter(newDocument);
            return RedirectToAction("Index");
        }


        [HttpGet] // Ajoutez l'attribut [HttpGet] pour indiquer que c'est une action GET
        public IActionResult Update(int id)
        {      
            return View(_services.GetDocumentById(id));
        }


        [HttpPost]
        public IActionResult Update(Documentss updatedDocument)
        {     
            _services.Update(updatedDocument);
            return RedirectToAction("Index");
        }
        [HttpGet] // Ajoutez l'attribut [HttpGet] pour indiquer que c'est une action GET
        public IActionResult Delete(int id)
        { var obj = _services.GetDocumentById(id);

            return View(obj);
        }

        [HttpPost]
        public IActionResult Deletee(int id)
        {
            _services.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var document = _services.GetDocumentById(id);

            if (document == null)
            {
                return NotFound(); // Retourne une vue NotFound si le document n'est pas trouvé
            }

            return View(document);
        }
    }
}
