using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterLibrary
{
    public class AnimalManager
    {
        private string _path;
        private SourceType _sourceType;

        /// <summary>
        /// Creates Animal Manager based on a path to local file
        /// </summary>
        /// <param name="path">Path to local file</param>
        public AnimalManager(string path)
        {
            _path = path;
        }

        /// <summary>
        /// Creates Animal Manager based on a path to local file or url address, based on a given source type
        /// </summary>
        /// <param name="path"></param>
        /// <param name="sourceType"></param>
        public AnimalManager(string path, SourceType sourceType)
            : this(path)
        {
            _sourceType = sourceType;
        }


        public OperationResult ReadData()
        {
            try
            {
                if (_sourceType == SourceType.File)
                {
                    string[] rows = File.ReadAllLines(_path);
                    return ReadData(rows);
                }
                else if (_sourceType == SourceType.WebPage)
                {
                    string data = new WebClient().DownloadString(_path);
                    string[] rows = data.Split('\n');
                    return ReadData(rows);
                }
                else
                {
                    throw new Exception("Unknown data source.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Wrong path");
            }

        }

        public OperationResult ReadData(string[] rows)
        {
            var operationResult = new OperationResult();
            var animals = new List<Animal>();

            for (int i = 1; i < rows.Length; i++)
            {
                try
                {
                    string[] cells = rows[i].Split(';');

                    var animal = new Animal();
                    animal.Id = Convert.ToInt32(cells[0]);
                    animal.Name = cells[1];
                    animal.Species = cells[2];
                    animal.Weight = Convert.ToInt32(cells[3]);
                    try
                    {
                        animal.DateOfBirth = Convert.ToDateTime(cells[4]);
                        animal.IsDateOfBirthCorrect = true;
                    }
                    catch (Exception)
                    {
                        animal.IsDateOfBirthCorrect = false;
                    }
                        animals.Add(animal);              
                }
                catch (Exception)
                {

                    operationResult.AddRowNotLoadedCorrectly(i);
                }
            }
            operationResult.DataList = animals;
            return operationResult;
        }
    }
}
