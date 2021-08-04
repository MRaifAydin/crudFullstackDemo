using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class GarageRepository : IGarageRepository
    {
        public Garage CreateGarage(Garage garage)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Garages.Add(garage);
                hotelDbContext.SaveChanges();
                return garage;
            }
        }

        public void DeleteGarage(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deletedHotel = GetGarageById(id);
                hotelDbContext.Garages.Remove(deletedHotel);
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

        public Garage GetGarageById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Garages.Find(id);
            }
        }

        public Garage UpdateGarage(Garage garage)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Garages.Update(garage);
                hotelDbContext.SaveChanges();
                return garage;
            }
        }
    }
}
