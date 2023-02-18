using LivrariaMinsait.Models;

namespace LivrariaMinsait.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> Get();
        Task<Livro> Get(int Id);
        Task<Livro> Create(Livro livro);
        Task Update(Livro livro);
        Task Delete(int Id);
    }
}
