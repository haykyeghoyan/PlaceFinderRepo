using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PlaceFinder.BL.DTOs;
using PlaceFinder.BL.ServiceInterfaces;
using PlaceFinder.VMs;

namespace PlaceFinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        
        public AccountController(UserManager<IdentityUser> userManager, IUserService userService, 
                                            IMapper mapper)
        {
            _userManager = userManager;
            _userService = userService;
            _mapper = mapper;
        }

 
        [HttpPost]
        public async Task Register([FromBody] UserVM model)
        {
            var result = await _userManager.CreateAsync(new IdentityUser
            { UserName = model.Email, Email = model.Email }, model.PasswordHash);

        }
    }
}
