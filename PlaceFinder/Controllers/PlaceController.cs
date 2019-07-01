using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.VMs;

namespace PlaceFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceService _placeService;
        private readonly IMapper _mapper;

        public PlaceController(IPlaceService placeService, IMapper mapper)
        {
            _placeService = placeService;
            _mapper = mapper;
        }

        // GET: api/Place
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Place/5
        [HttpGet("{id}")]
        public PlaceVM Get(int id)
        {
            var place = _placeService.GetPlaceById(id);
            PlaceVM response = _mapper.Map<PlaceVM>(place);
            return response;
        }

        // POST: api/Place
        [HttpPost]
        public void Post([FromBody] PlaceVM place)
        {
            PlaceDTO _place = _mapper.Map<PlaceDTO>(place);
            _placeService.Insert(_place);
        }

        // PUT: api/Place/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PlaceVM place)
        {
            PlaceDTO _place = _mapper.Map<PlaceDTO>(place);
            _place.Id = id;
            _placeService.Update(_place);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id,[FromBody] PlaceVM place)
        {
            PlaceDTO _place = _mapper.Map<PlaceDTO>(place);
            _place.Id = id;
            _placeService.Delete(_place);
        }
    }
}
