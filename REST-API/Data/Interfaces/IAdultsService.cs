using System.Collections.Generic;
using Hand_In_2.Data.Model;

namespace Hand_In_2.Data
{
    public interface IAdultsService
    {
        IList<Adult> getAllAdults();
        void addAdult(Adult adult);
        IList<Adult> removeAdult(string firstName, string lastName);

    }
}