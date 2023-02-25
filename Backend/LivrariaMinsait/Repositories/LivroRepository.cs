using LivrariaMinsait.Context;
using LivrariaMinsait.Data.DTO;
using LivrariaMinsait.Models;
using Microsoft.AspNetCore.Components.Forms;
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
        public async Task<Livro> Inserir(Livro livro)
        {
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            return livro;
        }

        public async Task Deletar(int id)
        {
            var deleteLivro = await _context.Livros.FindAsync(id);
            if (deleteLivro == null)
            {
                throw new Exception($"Id: {id} não encontrado");
            }
            _context.Livros.Remove(deleteLivro);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            return await _context.Livros.ToListAsync();
        }

        public async Task<Livro> ListarPorID(int id)
        {
            var procurarLivro= await _context.Livros.FindAsync(id);
            if (procurarLivro== null)
            {
                throw new Exception($"Id: {id} não encontrado");
            }
            return procurarLivro;
        }

        public async Task Atualizar(int id, LivroRequestDTO livro)
        {
            if (id == null)
            {
                throw new Exception("Id não pode ser nulo");
            }
            var procurarLivro = await _context.Livros.FindAsync(id);
            if (id == null)
            {
                throw new Exception($"Livro não encontrado para este Id: {id}");
            }
            procurarLivro.Titulo = livro.Titulo;
            procurarLivro.SubTitulo = livro.SubTitulo;
            procurarLivro.Resumo = livro.Resumo;
            procurarLivro.QtdePaginas = livro.QtdePaginas;
            procurarLivro.DataPublicacao = livro.DataPublicacao.ToString("yyyy-MM-dd");
            procurarLivro.Editora = livro.Editora;
            procurarLivro.Edicao = livro.Edicao;
            procurarLivro.Autor = livro.Autor;
            _context.Entry(procurarLivro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}

