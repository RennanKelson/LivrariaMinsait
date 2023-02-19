namespace LivrariaMinsait.Data.DTO
{
    public class LivroResponseDTO
    {
        public LivroResponseDTO(int id, string titulo, string subTitulo, string resumo, int qtdePaginas, DateTime dataPublicacao, string editora, int edicao, string autor)
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
