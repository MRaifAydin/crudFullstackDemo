using Dto.Conversion;
using Dto.Dto;
using HotelFinder.DataAccess.Abstract;
using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public HotelDto CreateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Add(hotel);
                hotelDbContext.SaveChanges();
                return HotelConversion.ToApi(hotel);
            }
        }

        public void DeleteHotel(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                var deletedHotel = GetHotelById(id);
                hotelDbContext.Hotels.Remove(HotelConversion.ToEntity(deletedHotel));
                hotelDbContext.SaveChanges();
            }
        }

        public List<Hotel> GetAllHotels()
        {
            using(var hotelDbContext = new HotelDbContext())
            {
                return hotelDbContext.Hotels.ToList();
            }
        }

        public HotelDto GetHotelById(int id)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                return HotelConversion.ToApi(hotelDbContext.Hotels.Find(id));
            }
        }

        public HotelDto UpdateHotel(Hotel hotel)
        {
            using (var hotelDbContext = new HotelDbContext())
            {
                hotelDbContext.Hotels.Update(hotel);
                hotelDbContext.SaveChanges();
                return HotelConversion.ToApi(hotel);
            }
        }
    }
}
