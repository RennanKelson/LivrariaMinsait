using System.ComponentModel.DataAnnotations;

namespace LivrariaMinsait.Data.DTO
{
    public class LivroResponseDTO
    {
        public LivroResponseDTO(int id, string titulo, string subTitulo, string resumo, int qtdePaginas, string dataPublicacao, string editora, int edicao, string autor)
        {
            Id=id;
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
        [Required(ErrorMessage = "O campo Título é obrigatorio!"), MaxLength(100)]
        public string Titulo { get; set; }
        [MaxLength(100)]
        public string SubTitulo { get; set; }
        [MaxLength(500)]
        public string Resumo { get; set; }
        [Range(1, 10000, ErrorMessage = "Coloque um valor entre 1 e 10000.")]
        [Required(ErrorMessage = "O campo Quantidade de Páginas é obrigatorio!")]
        public int QtdePaginas { get; set; }
        [Required(ErrorMessage = "O campo Data de Publicação é obrigatorio!")]
        public string DataPublicacao { get; set; }
        [Required(ErrorMessage = "O campo Editora é obrigatorio!"), MaxLength(150)]
        public string Editora { get; set; }
        [Range(1, 20, ErrorMessage = "Quantidade máxima para Edição é 20.")]
        public int Edicao { get; set; }
        [Required(ErrorMessage = "O campo Autor é obrigatorio!"), MaxLength(50)]
        public string Autor { get; set; }

    }
}
