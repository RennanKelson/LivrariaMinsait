using LivrariaMinsait.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaMinsait.Context
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> options) : base(options)
        {
        }
        public DbSet<Livro> Livros { get; set; }
    }
}
