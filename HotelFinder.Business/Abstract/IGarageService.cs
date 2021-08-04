using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IGarageService
    {
        List<Garage> GetAllGarages();
        Garage GetGarageById(int id);
        Garage CreateGarage(Garage garage);
        Garage UpdateGarage(Garage garage);
        void DeleteGarage(int id);
    }
}
