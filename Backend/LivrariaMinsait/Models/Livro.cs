using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LivrariaMinsait.Models
{
    [Table("Livro")]
    public class Livro
    {
        public Livro (string titulo, string? subTitulo, string? resumo, int qtdePaginas, DateTime dataPublicacao, string editora, int edicao, string autor)
        {
            Titulo=titulo;
            SubTitulo=subTitulo;
            Resumo=resumo;
            QtdePaginas=qtdePaginas;
            DataPublicacao=dataPublicacao;
            Editora=editora;
            Edicao=edicao;
            Autor=autor;
        }

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
