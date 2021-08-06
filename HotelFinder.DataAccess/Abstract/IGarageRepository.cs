using Dto.Dto;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IGarageRepository
    {
        List<Garage> GetAllGarages();
        GarageDto GetGarageById(int id);
        GarageDto CreateGarage(Garage garage);
        GarageDto UpdateGarage(Garage garage);
        void DeleteGarage(int id);
    }
}
