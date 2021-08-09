using Dto.Dto;
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
        GarageDto GetGarageById(int id);
        GarageDto CreateGarage(GarageDto garage);
        GarageDto UpdateGarage(GarageDto garage);
        void DeleteGarage(int id);
    }
}
