using AutoMapper;
using GooseGame.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Data.Services
{
    internal class MyAutoMapperProfile : Profile
    {
        public MyAutoMapperProfile()
        {
            CreateMap<PlayerEntity, Player>()
                .ForMember(x => x.Name, y => y.MapFrom(z => z.Name))
                
                .ReverseMap();
        }
    }
}
