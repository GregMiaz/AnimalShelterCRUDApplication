using SOCAnimalShelterDataMigration.Models;
using SOCAnimalShelterDataMigration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Controllers
{
    public class ReadController
    {
        public List<Animal> ReadAnimals()
        {
            var animalsRepository = new AnimalsRepository();
            return animalsRepository.ReadAll();
        }
    }
}
