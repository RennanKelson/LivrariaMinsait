using LivrariaMinsait.Models;
using LivrariaMinsait.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IEnumerable<Livro>> GetLivro()
        {
            return await _livroRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Livro>> GetLivro(int id)
        {
            return await _livroRepository.Get(id);
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> PostLivros([FromBody] Livro livro)
        {
            var newLivro = await _livroRepository.Create(livro);
            return CreatedAtAction(nameof(GetLivro), new { id = newLivro.Id }, newLivro);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var livroDelete = await _livroRepository.Get(id);
            if (livroDelete == null)
                return NotFound();

            await _livroRepository.Delete(livroDelete.Id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutLivros(int id, [FromBody] Livro livro)
        {
            if (id != livro.Id)
                return BadRequest();

            await _livroRepository.Update(livro);

            return NoContent();
        }
    }
}
