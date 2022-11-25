using AutoMapper;
using GooseGame.Data.Entities;
using GooseGame.Data.NewEntities;

namespace GooseGame.Business.Services
{
    internal class MyAutoMapperProfile : Profile
    {
        public MyAutoMapperProfile()
        {
            CreateMap<PlayerModel, PlayerDb>().ReverseMap();
        }
    }
}