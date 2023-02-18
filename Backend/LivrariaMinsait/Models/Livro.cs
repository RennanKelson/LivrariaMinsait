using System.ComponentModel.DataAnnotations;

namespace LivrariaMinsait.Models
{
    public class Livro
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "Título não pode estar em branco")]
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Resumo { get; set; }
        [Range(1, 10000, ErrorMessage = "Quantidade de páginas deve ser maior que zero e menor que dez mil.")]
        public int QuantidadeDePaginas { get; set; }
        public string DataPublicacao { get; set; }
        public string Editora { get; set; }
        [Range(1, 9999, ErrorMessage = "Quantidade de páginas deve ser maior que zero.")]
        public int Edicao { get; set; }
        public string? Autor { get; set; }
    }
}
