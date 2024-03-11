using DAL;
using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class CategorieServices
    {
        private readonly MyDbContext _db;

        public CategorieServices(MyDbContext db)
        {
            _db = db;
        }

        public List<Categorie> GetAll()
        {
            return _db.categories.ToList();
        }

        
        public void Add(Categorie categorie)
        {
            _db.categories.Add(categorie);
            _db.SaveChanges();
        }

        public void Update(Categorie updatedCategorie)
        {
            var existingCategorie = _db.categories.Find(updatedCategorie.Id);

            if (existingCategorie != null)
            {
                existingCategorie.Nom = updatedCategorie.Nom;
                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var categorieToDelete = _db.categories.Find(id);

            if (categorieToDelete != null)
            {
                _db.categories.Remove(categorieToDelete);
                _db.SaveChanges();
            }
        }
        public Categorie GetCategorieById(int id)
        {
            var categorie = _db.categories.Find(id);
            return categorie;
        }
    }
}
