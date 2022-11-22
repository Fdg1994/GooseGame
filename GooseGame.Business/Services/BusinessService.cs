using AutoMapper;
using GooseGame.Data.NewEntities;
using GooseGame.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace GooseGame.Data.Services
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

        public Player GetPlayerModelToDB()
        {
            var model = GetPlayerModel();

            var entity = mapper.Map<Player>(model);
            
            return entity;
        }
    }
}

