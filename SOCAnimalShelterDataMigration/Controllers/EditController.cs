﻿using SOCAnimalShelterDataMigration.Models;
using SOCAnimalShelterDataMigration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Controllers
{
    public class EditController
    {
        public int EditAnimal(Animal animal)
        {
            var animalsRepository = new AnimalsRepository();
            return animalsRepository.Edit(animal);
        }
    }
}
