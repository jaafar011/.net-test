using DAL;
using DAL.Entity;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public class TypessServices
    {
        private readonly MyDbContext _db;

        public TypessServices(MyDbContext db)
        {
            _db = db;
        }

        public List<Typess> GetAll()
        {
            return _db.types.ToList();
        }

       

        public void Add(Typess type)
        {
            _db.types.Add(type);
            _db.SaveChanges();
        }

        public void Update(Typess updatedType)
        {
            var existingType = _db.types.Find(updatedType.Id);

            if (existingType != null)
            {
                existingType.Nom = updatedType.Nom;
                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var typeToDelete = _db.types.Find(id);

            if (typeToDelete != null)
            {
                _db.types.Remove(typeToDelete);
                _db.SaveChanges();
            }
        }

        public Typess GetById(int id)
        {
            var types = _db.types. Find(id);
            return types;
        }
    }
}
