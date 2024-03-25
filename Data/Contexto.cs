using ComoFazerCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace ComoFazerCrud.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) 
            : base(options)
                { }
        
        public DbSet<Servicos> Servicos { get; set; }

        public DbSet<Login> Login { get; set; }

        public DbSet<Publicacao> Publicacao { get; set; }
    }
    }

