using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Hand_In_2.Data.Model;
using Hand_In_2.Data.Persistance;
using Hand_In_2.Pages;

namespace Hand_In_2.Data.Impl
{
    public class AdultService : IAdultsService
    {
        private IReadAndWriteData<Adult> _readAndWriteData;
        private IList<Adult> adults;

      
        public AdultService(IReadAndWriteData<Adult> readAndWriteData)
        {
            _readAndWriteData = readAndWriteData;
            adults = _readAndWriteData.ReadData();
        }

        public IList<Adult> getAllAdults()
        {
            return _readAndWriteData.ReadData();
        }

        public void addAdult(Adult adult)
        {
            adults.Add(adult);
            saveChanges(out var json);
        }

        private void saveChanges(out string json)
        {
            json = JsonSerializer.Serialize(adults);
            _readAndWriteData.SaveChanges(json);
        }

        public IList<Adult> RemoveAdult(string firstName, string lastName)
        {
            Adult adult = adults.First(t => t.FirstName.Equals(firstName) && t.LastName.Equals(lastName));
            adults.Remove(adult); 
            saveChanges(out var json);
            return adults;
        }

   
    }
}