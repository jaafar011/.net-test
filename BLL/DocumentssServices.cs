using DAL;
using DAL.Entity;
using System.Reflection.Metadata;

namespace BLL
{
    public class DocumentssServices
    {
        private readonly MyDbContext _db;

        public DocumentssServices(MyDbContext db)
        {
            _db = db;
        }

        public List<Documentss> GetAll()
        {
            
            
                List<Documentss> liste = _db.documents.ToList();
                return liste;
            
        }

        public void Ajouter(Documentss document)
        {
            // Assurez-vous que la catégorie existe avant d'ajouter le document
           

            

                _db.documents.Add(document);
                _db.SaveChanges();
            }
            
        


        public void Update(Documentss document)
        {
            var existingDocument = _db.documents.Find(document.Id);

            if (existingDocument != null)
            {
                existingDocument.Nom = document.Nom;
                existingDocument.Date = document.Date;
                existingDocument.IdType = document.IdType;
                existingDocument.Taille = document.Taille;
                existingDocument.IdCategorie = document.IdCategorie;

                _db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var documentToDelete = _db.documents.Find(id);

            if (documentToDelete != null)
            {
                _db.documents.Remove(documentToDelete);
                _db.SaveChanges();
            }
        }

        public Documentss GetDocumentById(int id)
        {
             var doc = _db.documents.Find(id);
            return doc;
        }
    }
}
