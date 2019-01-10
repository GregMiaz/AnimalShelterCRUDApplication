using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelterLibrary
{
    public class OperationResult
    {
        public List<Animal> DataList;
        public List<int> RowsNotLoadedCorrectly;

        public bool IsSuccess
        {
            get
            {
                return RowsNotLoadedCorrectly == null ? true : false;
            }
        }

        public void AddRowNotLoadedCorrectly(int rowNumber)
        {
            if (RowsNotLoadedCorrectly==null)
            {
                RowsNotLoadedCorrectly = new List<int>();
            }
            RowsNotLoadedCorrectly.Add(rowNumber);
        }
    }
}
