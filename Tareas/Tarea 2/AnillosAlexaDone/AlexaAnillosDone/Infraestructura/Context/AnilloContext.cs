using AlexaAnillosDone.Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace AlexaAnillosDone.Infraestructura.Context
{
    public class AnilloContext : DbContext
    {
        public AnilloContext(DbContextOptions<AnilloContext> options) : base(options)
        {
        }
        public DbSet<Anillo> Anillos { get; set; }
    }
}
