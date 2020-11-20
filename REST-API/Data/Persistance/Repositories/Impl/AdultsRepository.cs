using System.Collections.Generic;
using System.Linq;
using Hand_In_2.Data.Model;

namespace Hand_In_2.Data.Persistance
{
    public class AdultsRepository : IAdultsRepository
    {
        private ExampleDBContext _applicationContext;

        public AdultsRepository(ExampleDBContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public IList<Adult> getAllAdults()
        {
            return _applicationContext.Adult.ToList();
        }

        public void addAdult(Adult adult)
        {
            _applicationContext.Adult.Add(adult);
        }

        public IList<Adult> removeAdult(string firstName, string lastName)
        {
            Adult adult =
                _applicationContext.Adult.First(n => n.FirstName.Equals(firstName) && n.LastName.Equals(lastName));
            _applicationContext.Adult.Remove(adult);
            return getAllAdults();
        }
    }
}