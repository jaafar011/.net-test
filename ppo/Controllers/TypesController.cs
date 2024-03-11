using BLL;
using DAL.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ppo.Controllers
{
    public class TypesController : Controller
    {
        private readonly TypessServices _services;

        public TypesController(TypessServices services)
        {
            _services = services;
        }

        public IActionResult Index()
        {
            List<Typess> types = _services.GetAll();
            return View(types);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
   
        public IActionResult Create(Typess newType)
        {
          
            
                _services.Add(newType);
                return RedirectToAction("Index");
         
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Typess type = _services.GetById(id);
            if (type == null)
            {
                return NotFound();
            }
            return View(type);
        }

        [HttpPost]
        
        public IActionResult Update(Typess updatedType)
        {
            if (ModelState.IsValid)
            {
                _services.Update(updatedType);
                return RedirectToAction("Index");
            }
            return View(updatedType);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Typess type = _services.GetById(id);
            if (type == null)
            {
                return NotFound();
            }
            return View(type);
        }

        [HttpPost]
        
        public IActionResult DeleteConfirmed(int id)
        {
            _services.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            Typess type = _services.GetById(id);
            if (type == null)
            {
                return NotFound();
            }
            return View(type);
        }
    }
}
