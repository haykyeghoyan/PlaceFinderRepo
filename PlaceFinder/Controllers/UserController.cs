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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public UserVM Get(int id)
        {
            var user = _userService.GetUserById(id);
            UserVM response = _mapper.Map<UserVM>(user);
            return response;
        }

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] UserVM user)
        {
            UserDTO _user = _mapper.Map<UserDTO>(user);
            _userService.Insert(_user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserVM user)
        {
            UserDTO _user = _mapper.Map<UserDTO>(user);
            _user.Id = id;
            _userService.Update(_user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id, [FromBody] UserVM user)
        {
            UserDTO _user = _mapper.Map<UserDTO>(user);
            _user.Id = id;
            _userService.Delete(_user);
        }
    }
}
