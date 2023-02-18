using AutoMapper;
using LivrariaMinsait.Data.DTOs;
using LivrariaMinsait.Models;

namespace LivrariaMinsait.Profiles
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<LivroRequestDTO, Livro>();
            CreateMap<Livro, LivroResponseDTO>();
        }
    }
}
