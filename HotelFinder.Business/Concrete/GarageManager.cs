using Dto.Conversion;
using Dto.Dto;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class GarageManager : IGarageService
    {
        private IGarageRepository _garageRepository;
        
        public GarageManager(IGarageRepository garageRepository)
        {
            _garageRepository = garageRepository;
        }

        public GarageDto CreateGarage(GarageDto garage)
        {
            return _garageRepository.CreateGarage(GarageConversion.ToEntity(garage));
        }

        public void DeleteGarage(int id)
        {
            _garageRepository.DeleteGarage(id);
        }

        public List<Garage> GetAllGarages()
        {
            return _garageRepository.GetAllGarages();
        }

        public GarageDto GetGarageById(int id)
        {
            return _garageRepository.GetGarageById(id);
        }

        public GarageDto UpdateGarage(GarageDto garage)
        {
            return _garageRepository.UpdateGarage(GarageConversion.ToEntity(garage));
        }
        
    }
}
