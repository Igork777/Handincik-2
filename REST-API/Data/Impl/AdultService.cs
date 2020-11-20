using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Hand_In_2.Data.Model;
using Hand_In_2.Data.Persistance;

namespace Hand_In_2.Data.Impl
{
    public class AdultService : IAdultsService
    {
     
       private UnitOfWork _unitOfWork;
      
        public AdultService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Adult> getAllAdults()
        {
            IList<Adult> adults =  _unitOfWork.AdultRepo.getAllAdults();
            _unitOfWork.Save();
            return adults;
        }

        public void addAdult(Adult adult)
        {
          _unitOfWork.AdultRepo.addAdult(adult);
          _unitOfWork.Save();
        }
        

        public IList<Adult> removeAdult(string firstName, string lastName)
        {
            Adult adult = _unitOfWork.AdultRepo.getAllAdults().FirstOrDefault(t => t.FirstName.Equals(firstName) && t.LastName.Equals(lastName));
            _unitOfWork.Save();
            if (adult != null)
            {
                _unitOfWork.AdultRepo.removeAdult(adult.FirstName, adult.LastName);
                _unitOfWork.Save();
            }

            IList<Adult> adults = _unitOfWork.AdultRepo.getAllAdults();
            _unitOfWork.Save();
            return adults;
        }

   
    }
}