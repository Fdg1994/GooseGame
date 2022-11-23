using AutoMapper;
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

