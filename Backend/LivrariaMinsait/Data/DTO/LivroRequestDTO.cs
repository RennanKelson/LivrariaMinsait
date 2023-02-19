namespace LivrariaMinsait.Data.DTO
{
    public class LivroRequestDTO
    {
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
