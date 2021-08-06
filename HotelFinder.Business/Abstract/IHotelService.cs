using Dto.Dto;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        HotelDto GetHotelById(int id);
        HotelDto CreateHotel(HotelDto hotel);
        HotelDto UpdateHotel(HotelDto hotel);
        void DeleteHotel(int id);
    }
}
