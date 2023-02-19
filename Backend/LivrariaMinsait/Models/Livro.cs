using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaMinsait.Models
{
    [Table("Livro")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string SubTitulo { get; set; }

        public string Resumo { get; set; }

        public int QtdePaginas { get; set; }

        public DateTime DataPublicacao { get; set; }

        public string Editora { get; set; }

        public int Edicao { get; set; }

        public string Autor { get; set; }
    }
}
