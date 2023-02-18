using AutoMapper;
using LivrariaMinsait.Context;
using LivrariaMinsait.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaMinsait.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        public readonly LivroContext _context;

        public LivroRepository(LivroContext context)
        {
            _context = context;
        }
        public async Task<Livro> Create(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return livro;
        }

        public async Task Delete(int id)
        {
            var deleteLivro = await _context.Livros.FindAsync(id);
            if (deleteLivro == null)
            {
                throw new Exception($"Id: {id} não encontrado");
            }
            _context.Livros.Remove(deleteLivro);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Livro>> Get()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> Get(int id)
        {
            var procurarLivro= await _context.Livros.FindAsync(id);
            if (procurarLivro== null)
            {
                throw new Exception($"Id: {id} não encontrado");
            }
            return procurarLivro;
        }

        public async Task Update(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
