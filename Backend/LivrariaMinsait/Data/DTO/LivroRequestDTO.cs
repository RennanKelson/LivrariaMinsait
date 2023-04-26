using System.ComponentModel.DataAnnotations;

namespace LivrariaMinsait.Data.DTO
{
    public class LivroRequestDTO
    {
        [Required(ErrorMessage = "O campo Título é obrigatorio!"), MaxLength(100)]
        public string Titulo { get; set; }
        [MaxLength(100)]
        public string? SubTitulo { get; set; }
        [MaxLength(500)]
        public string? Resumo { get; set; }
        [Range(1, 10000, ErrorMessage = "Coloque um valor entre 1 e 10000 para o número de páginas.")]
        [Required(ErrorMessage = "O campo Quantidade de Páginas é obrigatorio!")]
        public int QtdePaginas { get; set; }
        [Required(ErrorMessage = "O campo Data de Publicação é obrigatorio!")]
        public DateTime DataPublicacao { get; set; }
        [Required(ErrorMessage = "O campo Editora é obrigatorio!"), MaxLength(150)]
        public string Editora { get; set; }
        [Range(1, 20, ErrorMessage = "Quantidade máxima para Edição é 20.")]
        public int? Edicao { get; set; }
        [Required(ErrorMessage = "O campo Autor é obrigatorio!"), MaxLength(50)]
        public List<string> Autor { get; set; }
    }
}
