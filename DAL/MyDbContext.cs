using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Documentss> documents { get; set; }
        public DbSet<Typess>    types{ get; set; }
        public DbSet<Categorie> categories { get; set; }
    }
}