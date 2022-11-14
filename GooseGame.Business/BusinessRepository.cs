using GooseGame.Business.Models;
using GooseGame.Data.Entities;
using GooseGame.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GooseGame.Business
{
    public class BusinessRepository
    {
        private DummyRepository dummyRepository;

        public BusinessRepository()
        {
            dummyRepository = new DummyRepository();
        }

        public void AddDummy(DummyModel dummy)
        {
            //MAPPING (!)
            Dummy newDummy = new Dummy
            {
                Age = dummy.Age,
                FirstName = dummy.FirstName,
                LastName = dummy.LastName
            };

            dummyRepository.AddDummy(newDummy);
        }


        //PUUR VOOR TEST
        public DummyModel CreateDummyEntity()
        {
            return new DummyModel { Age = 26, FirstName = "Ken", LastName = "Field", Id = 1 };
        }
    }
}
