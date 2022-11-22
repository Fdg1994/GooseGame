using AutoMapper;
using GooseGame.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


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
        private PlayerEntity GetPlayerFromDB()
        {
            return new PlayerEntity
            {
                Name = "Default",
            };
        }

        public PlayerModel GetPlayer()
        {
            var entity = GetPlayerFromDB();

            var model = mapper.Map<PlayerModel>(entity);

            return model;
        }
    }
}

