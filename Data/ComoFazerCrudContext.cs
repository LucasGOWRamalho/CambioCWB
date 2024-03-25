using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ComoFazerCrud.Models;

namespace ComoFazerCrud.Data
{
    public class ComoFazerCrudContext : DbContext
    {
        public ComoFazerCrudContext(DbContextOptions<ComoFazerCrudContext> options)
            : base(options)
        {
        }

        public DbSet<Servicos> Servicos { get; set; } = default!;
        public DbSet<Login> Login { get; set; } = default!;
        public DbSet<Publicacao> Publicacao { get; set; } = default!;
    }
}
