using Dto.Conversion;
using Dto.Dto;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class GarageRepository : IGarageRepository
    {
        public GarageDto CreateGarage(Garage garage)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Garages.Add(garage);
                hotelDbContext.SaveChanges();
                return GarageConversion.ToApi(garage);
            }
        }

        public void DeleteGarage(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deletedGarage = GetGarageById(id);
                hotelDbContext.Garages.Remove(GarageConversion.ToEntity(deletedGarage));
                hotelDbContext.SaveChanges();
            }
        }

        public List<Garage> GetAllGarages()
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Garages.ToList();
            }
        }

        public GarageDto GetGarageById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return GarageConversion.ToApi(hotelDbContext.Garages.AsNoTracking().Where(x => x.GarageId == id).FirstOrDefault());
            }
        }

        public GarageDto UpdateGarage(Garage garage)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Garages.Update(garage);
                hotelDbContext.SaveChanges();
                return GarageConversion.ToApi(garage);
            }
        }
    }
}
