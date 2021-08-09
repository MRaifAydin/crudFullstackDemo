using Dto.Conversion;
using Dto.Dto;
using HotelFinder.Business.Abstract;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.DataAccess.Concrete;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }

        public HotelDto CreateHotel(HotelDto hotel)
        {
            return _hotelRepository.CreateHotel(HotelConversion.ToEntity(hotel));
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public HotelDto GetHotelById(int id)
        {

            if (id > 0)
            {
                return _hotelRepository.GetHotelById(id);
            }

            throw new Exception("Id cannot be less than 1");
        }

        public HotelDto UpdateHotel(HotelDto hotel)
        {
            return _hotelRepository.UpdateHotel(HotelConversion.ToEntity(hotel));
        }
    }
}
