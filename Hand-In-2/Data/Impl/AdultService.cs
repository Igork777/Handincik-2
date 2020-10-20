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
        private ISaveData IsaveData;
        private IList<Adult> adults;

        public AdultService()
        {
            IsaveData = new FileContext();
            adults = IsaveData.ReadData<Adult>(enums.adults);
        }

        public IList<Adult> getAllAdults()
        {
            return IsaveData.ReadData<Adult>(enums.adults);
        }

        public void addAdult(Adult adult)
        {
            adults.Add(adult);
            saveChanges(out var json);
        }

        private void saveChanges(out string json)
        {
            json = JsonSerializer.Serialize(adults);
            IsaveData.SaveChanges(enums.adults, json);
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