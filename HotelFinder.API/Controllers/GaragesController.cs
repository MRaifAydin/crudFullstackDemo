using Dto.Dto;
using HotelFinder.Business.Abstract;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GaragesController : ControllerBase
    {
        private IGarageService _garageService;

        public GaragesController(IGarageService garageService)
        {
            _garageService = garageService;
        }

        [HttpGet]
        public List<Garage> Get()
        {
            return _garageService.GetAllGarages();
        }

        [HttpGet("{id}")]
        public Garage Get(int id)
        {
            return _garageService.GetGarageById(id);
        }
        
        [HttpPost]
        public Garage Post([FromBody]Garage garage)
        {
            return _garageService.CreateGarage(garage);
        }

        [HttpPut]
        public Garage Put([FromBody]Garage garage)
        {
            return _garageService.UpdateGarage(garage);
        }

        [HttpDelete("{id}")]
        public void DeleteGarage(int id)
        {
            _garageService.DeleteGarage(id);
        }
    }
}
