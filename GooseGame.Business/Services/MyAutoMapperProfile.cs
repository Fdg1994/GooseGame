using AutoMapper;
using GooseGame.Data.Entities;

namespace GooseGame.Business.Services
{
    internal class MyAutoMapperProfile : Profile
    {
        public MyAutoMapperProfile()
        {
            CreateMap<PlayerEntity, PlayerModel>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                .ReverseMap();
        }
    }
}
