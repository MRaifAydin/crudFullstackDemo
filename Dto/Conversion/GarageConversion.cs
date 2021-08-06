using Dto.Dto;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.Conversion
{
    public static class GarageConversion
    {
        public static Garage ToEntity(GarageDto garage)
        {
            return new Garage
            {
                Capacity = garage.Capacity,
                CarCount = garage.CarCount,
                GarageId = garage.GarageId,
                HotelId = garage.HotelId,
            };
        }

        public static GarageDto ToApi(Garage garage)
        {
            return new GarageDto
            {
                Capacity = garage.Capacity,
                CarCount = garage.CarCount,
                GarageId = garage.GarageId,
                HotelId = garage.HotelId,
            };
        }

    }
}
