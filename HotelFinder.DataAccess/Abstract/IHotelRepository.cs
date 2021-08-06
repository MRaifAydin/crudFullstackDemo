using Dto.Dto;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        HotelDto GetHotelById(int id);
        HotelDto CreateHotel(Hotel hotel);
        HotelDto UpdateHotel(Hotel hotel);
        void DeleteHotel(int id);
    }
}
