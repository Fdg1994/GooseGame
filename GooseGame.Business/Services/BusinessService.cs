using AutoMapper;
using GooseGame.Data.NewEntities;

namespace GooseGame.Business.Services

{
    internal class BusinessService
    {
        private MapperConfiguration config = new MapperConfiguration(
            cfg => cfg.AddProfile(new MyAutoMapperProfile())
            );

        private IMapper mapper;

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