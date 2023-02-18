using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaMinsait.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Key]
        [Column("id")]
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Column("Titulo")]
        [Display(Name = "Título")]
        [Required, MaxLength(100)]
        public string Titulo { get; set; }

        [Column("Subtitulo")]
        [Display(Name = "Subtítulo")]
        [MaxLength(100)]
        public string SubTitulo { get; set; }

        [Column("Resumo")]
        [Display(Name = "Resumo")]
        [MaxLength(500)]
        public string Resumo { get; set; }

        [Column("QtdePaginas")]
        [Display(Name = "Número de páginas")]
        [Required, Range(1, 10000)]
        public int QtdePaginas { get; set; }

        [Column("DataPublicacao")]
        [Display(Name = "Data de publicação")]
        [Required]
        public DateTime DataPublicacao { get; set; }

        [Column("Editora")]
        [Display(Name = "Editora")]
        [Required, MaxLength(150)]
        public string Editora { get; set; }

        [Column("Edicao")]
        [Display(Name = "Edição")]
        [MaxLength(2), Range(1, 99)]
        public int Edicao { get; set; }

        [Column("Autor")]
        [Display(Name = "Autor")]
        [Required, MaxLength(50)]
        public string Autor { get; set; }
    }
}
