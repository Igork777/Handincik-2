using System.Collections.Generic;
using System.Threading.Tasks;
using Hand_In_2.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace Hand_In_2.Data
{
    public interface IAdultsService
    {
       
        Task<IList<Adult>> getAllAdults();
        Task addAdult(Adult adult);
        Task removeAdult(string firstName, string lastName);

    }
}