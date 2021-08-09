using Dto.Dto;
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        private IMemoryCache _memoryCache;
        private readonly string hotelKey = "hotelKey";


        public HotelsController(IHotelService hotelService, IMemoryCache memoryCache)
        {
            _hotelService = hotelService;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            List<Hotel> hotelCollection = null;

            if (_memoryCache.TryGetValue(hotelKey,out hotelCollection))
            {
                return hotelCollection;
            }
            hotelCollection = _hotelService.GetAllHotels();

            var cacheOptions = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromSeconds(90));

            _memoryCache.Set(hotelKey, hotelCollection, cacheOptions);
            return hotelCollection;
        }

        [HttpGet("{id}")]
        public HotelDto Get(int id)
        {
            return _hotelService.GetHotelById(id);
        }

        [HttpPost]
        public HotelDto Post([FromBody] HotelDto hotel)
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]
        public HotelDto Put([FromBody] HotelDto hotel)
        {
            return _hotelService.UpdateHotel(hotel);
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
