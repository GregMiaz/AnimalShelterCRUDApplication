using AnimalShelterLibrary;
using SOCAnimalShelterDataMigration.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Controllers
{
    public class MigrationController
    {
        public void FileToDatabaseMigration(string path)
        {   
            // 1. Getting data from file
            var animalManager = new AnimalManager(path);
            OperationResult operationResult = animalManager.ReadData();

            List<AnimalShelterLibrary.Animal> fileAnimals = operationResult.DataList;


            // 2. Clearing table
            var animalsRepository = new AnimalsRepository();
            animalsRepository.Clear();

            // 3. Transfering animals to database

            foreach (var fileAnimal in fileAnimals)
            {
                var animal = new SOCAnimalShelterDataMigration.Models.Animal()
                {
                    Id = fileAnimal.Id,
                    Name = fileAnimal.Name,
                    Species = fileAnimal.Species,
                    Weight = fileAnimal.Weight,
                    DateOfBirth = fileAnimal.DateOfBirth
                };

                animalsRepository.Add(animal);
            }

        }
    }
}
