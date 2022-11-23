using AutoMapper;
using GooseGame.Business;
using GooseGame.Data.NewEntities;
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
            CreateMap<PlayerModel, Player>().ReverseMap();
            CreateMap<PlayedGameModel, PlayedGame>().ReverseMap();           
        }
    }
}
