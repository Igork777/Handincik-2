using System.Collections.Generic;
using Hand_In_2.Data.Model;
using Hand_In_2.Pages;

namespace Hand_In_2.Data
{
    public interface IAdultsService
    {
        IList<Adult> getAllAdults();
        void addAdult(Adult adult);
        IList<Adult> RemoveAdult(string firstName, string lastName);

    }
}