using Azure.Core;
using LivrariaMinsait.Data.DTO;
using LivrariaMinsait.Models;
using LivrariaMinsait.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace LivrariaMinsait.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;
        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<LivroResponseDTO>> ListarTodos()
        {
            try
            {
                var listarLivros = await _livroRepository.ListarTodos();
                var listaLivroRetorno = new List<LivroResponseDTO>();
                foreach (var livro in listarLivros)
                {
                    var livroRetorno = new LivroResponseDTO
                        (livro.Id, livro.Titulo, livro.SubTitulo, livro.Resumo, livro.QtdePaginas, livro.DataPublicacao, livro.Editora, livro.Edicao, livro.Autor);
                    listaLivroRetorno.Add(livroRetorno);
                }
                return listaLivroRetorno;
            }
            catch (Exception)
            {
                return Enumerable.Empty<LivroResponseDTO>();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroResponseDTO>> ListarPorID(int id)
        {
            var livroSalvo = await _livroRepository.ListarPorID(id);
            var livroRetorno = new LivroResponseDTO
                (livroSalvo.Id, livroSalvo.Titulo, livroSalvo.SubTitulo, livroSalvo.Resumo, livroSalvo.QtdePaginas, livroSalvo.DataPublicacao, livroSalvo.Editora, livroSalvo.Edicao, livroSalvo.Autor);
            return livroRetorno;
        }

        [HttpPost]
        public async Task<ActionResult<LivroResponseDTO>> InserirLivro([FromBody] LivroRequestDTO livro)
        {
            if (livro == null)
            { 
                return BadRequest();
            }
            try
            {
                var novoLivro = new Livro
                    (livro.Titulo, livro.SubTitulo, livro.Resumo, livro.QtdePaginas, livro.DataPublicacao.ToString("yyyy-MM-dd"), livro.Editora, livro.Edicao, livro.Autor);
                var livroSalvo = await _livroRepository.Inserir(novoLivro);

                var livroRetorno = new LivroResponseDTO
                    (livroSalvo.Id, livroSalvo.Titulo, livroSalvo.SubTitulo, livroSalvo.Resumo, livroSalvo.QtdePaginas, livroSalvo.DataPublicacao, livroSalvo.Editora, livroSalvo.Edicao, livroSalvo.Autor);
                return livroRetorno;
            }
            catch (Exception)
            {
                throw new Exception("Algum campo está inválido por favor revise");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var livroDelete = await _livroRepository.ListarPorID(id);

            await _livroRepository.Deletar(livroDelete.Id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutLivros(int id, [FromBody] LivroRequestDTO livro)
        {
            await _livroRepository.Atualizar(id, livro);
            return NoContent();
        }

    }
}