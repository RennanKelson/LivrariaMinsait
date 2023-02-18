using System.ComponentModel.DataAnnotations;

namespace LivrariaMinsait.Data.DTOs
{
    public class LivroResponseDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Título não pode estar em branco")]
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Resumo { get; set; }
        [Required]
        [Range(1, 10000, ErrorMessage = "Quantidade de páginas deve ser maior que zero e menor que dez mil.")]
        public int QuantidadeDePaginas { get; set; }
        [Required(ErrorMessage = "Data não pode estar em branco")]
        public string DataPublicacao { get; set; }
        [Required(ErrorMessage = "Editora não pode estar em branco")]
        public string Editora { get; set; }
        [Range(1, 99, ErrorMessage = "Quantidade de páginas deve ser maior que zero.")]
        public int Edicao { get; set; }
        [Required(ErrorMessage = "Autor não pode estar em branco")]
        public string? Autor { get; set; }
    }
}
