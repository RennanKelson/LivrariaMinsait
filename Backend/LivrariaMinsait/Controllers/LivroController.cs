using Azure.Core;
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
        public async Task<IEnumerable<Livro>> ListarTodos()
        {
            return await _livroRepository.ListarTodos();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> ListarPorID(int id)
        {
            return await _livroRepository.ListarPorID(id);
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> InserirLivro([FromBody] Livro livro)
        {
            var novoLivro = await _livroRepository.Inserir(livro);
            return CreatedAtAction(nameof(ListarTodos), new { id = novoLivro.Id }, novoLivro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var livroDelete = await _livroRepository.ListarPorID(id);
            if (livroDelete == null)
                return NotFound();

            await _livroRepository.Deletar(livroDelete.Id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutLivros(int id, [FromBody] Livro livro)
        {
            if (id != livro.Id)
                return BadRequest();

            await _livroRepository.Atualizar(livro);

            return NoContent();
        }

    }
}