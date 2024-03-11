using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
   public class Documentss
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
       
        public string Nom { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public int IdType { get; set; }

        [Required]
        public int Taille { get; set; }

        public int IdCategorie { get; set; }


        [ForeignKey("IdCategorie")]
        public Categorie Categorie { get; set; }
        [ForeignKey("IdType")]

        public Typess Typess { get; set; }  
    }
}
