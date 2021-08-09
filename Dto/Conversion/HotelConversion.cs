using Dto.Dto;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Conversion
{
    public static class HotelConversion
    {
        public static Hotel ToEntity(HotelDto hotel)
        {
            return new Hotel
            {
                HotelId = hotel.HotelId,
                HotelName = hotel.HotelName,
                City = hotel.City
            };
        }

        public static HotelDto ToApi(Hotel hotel)
        {
            return new HotelDto
            {
                HotelId = hotel.HotelId,
                HotelName = hotel.HotelName,
                City = hotel.City
            };
        }

    }
}
