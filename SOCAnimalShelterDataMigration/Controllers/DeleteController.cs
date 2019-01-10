using SOCAnimalShelterDataMigration.Models;
using SOCAnimalShelterDataMigration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Controllers
{
    public class DeleteController
    {
        public int DeleteAnimal(int id)
        {
            var animalsRepository = new AnimalsRepository();
            return animalsRepository.Delete(new Animal() { Id = id });
        }
    }
}
