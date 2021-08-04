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
        public Garage CreateGarage(Garage garage)
        {

            return _garageRepository.CreateGarage(garage);

        }

        public void DeleteGarage(int id)
        {
            _garageRepository.DeleteGarage(id);
        }

        public List<Garage> GetAllGarages()
        {
            return _garageRepository.GetAllGarages();
        }

        public Garage GetGarageById(int id)
        {
            return _garageRepository.GetGarageById(id);
        }

        public Garage UpdateGarage(Garage garage)
        {
            return _garageRepository.UpdateGarage(garage);
        }
    }
}
