using SOCAnimalShelterDataMigration.Models;
using SOCAnimalShelterDataMigration.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOCAnimalShelterDataMigration.Repository
{
    internal class AnimalsRepository
    {
        private SQLManager _sqlManager;

        public AnimalsRepository()
        {
            _sqlManager = ConnectionStringManager.NewSQLManager;
        }

        public int Add(Animal animal)
        {
            string sql = String.Format("insert into Animals (Name, Species," +
                " Weight, Date_Of_Birth) values ('{0}', '{1}', {2}, '{3}')",
                animal.Name, animal.Species, animal.Weight, animal.DateOfBirth.Date.ToString("yyyyMMdd"));

            int result = _sqlManager.WriteData(sql);
            return result;
        }

        public int Delete(Animal animal)
        {
            string sql = string.Format("delete Animals where Id={0}", animal.Id);

            int result = _sqlManager.WriteData(sql);
            return result;
        }

        public void Clear()
        {
            string sql = "truncate table Animals";
            _sqlManager.WriteData(sql);
        }

        public int Edit(Animal animal)
        {
            string sql = String.Format($"update Animals set Name='{animal.Name}', Species='{animal.Species}'," +
                $" Weight={animal.Weight}, Date_Of_Birth='{animal.DateOfBirth}' where Id={animal.Id}");

            int result = _sqlManager.WriteData(sql);
            return result;
        }

        public Animal Read(int id)
        {
            string sql = String.Format("select Id, Name, Species, Weight, Date_Of_Birth from Animals" +
                " where Id={0}", id);

            List<string> result = _sqlManager.ReadData(sql);
            string[] cells = result[0].Split(';');
            var temporaryAnimal = new Animal()
            {
                Id = Convert.ToInt32(cells[0]),
                Name = cells[1],
                Species = cells[2],
                Weight = Convert.ToInt32(cells[3]),
                DateOfBirth = Convert.ToDateTime(cells[4])
            };

            return temporaryAnimal;
        }

        public List<Animal> ReadAll()
        {
            string sql = "select Id, Name, Species, Weight, Date_Of_Birth from Animals";

            List<string> result = _sqlManager.ReadData(sql);

            var animalList = new List<Animal>();

            foreach (var item in result)
            {
                string[] cells = item.Split(';');
                var temporaryAnimal = new Animal()
                {
                    Id = Convert.ToInt32(cells[0]),
                    Name = cells[1],
                    Species = cells[2],
                    Weight = Convert.ToInt32(cells[3]),
                    DateOfBirth = Convert.ToDateTime(cells[4])
                };
                animalList.Add(temporaryAnimal);
            }
            return animalList;
        }
    }
}
