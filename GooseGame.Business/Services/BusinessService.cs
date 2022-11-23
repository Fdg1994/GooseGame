using AutoMapper;

using GooseGame.Business;
using GooseGame.Data.NewEntities;
using GooseGame.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GooseGame.Data.Services

using GooseGame.Data.Entities;

namespace GooseGame.Business.Services

{
    internal class BusinessService
    {
        MapperConfiguration config = new MapperConfiguration(
            cfg => cfg.AddProfile(new MyAutoMapperProfile())
            );

        IMapper mapper;

        public BusinessService()
        {
            mapper = config.CreateMapper();
        }
        public PlayerModel GetPlayerModel()
        {
            return new PlayerModel
            {
                Name = Console.ReadLine(),
            };
        }

        public Player GetPlayerModelToDB(PlayerModel model)
        {
            var entity = mapper.Map<Player>(model);
            
            return entity;
        }

        public PlayedGame GetGameToDB(Game game)
        {
            var entity = mapper.Map<PlayedGame>(game);

            return entity;
        }
    }
}

