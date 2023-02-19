using LivrariaMinsait.Data.DTO;
using LivrariaMinsait.Models;

namespace LivrariaMinsait.Repositories
{
    public interface ILivroRepository
    {
        Task<IEnumerable<Livro>> ListarTodos();
        Task<Livro> ListarPorID(int Id);
        Task<Livro> Inserir(Livro livro);
        Task Atualizar(int id, LivroRequestDTO livro);
        Task Deletar(int Id);
    }
}
