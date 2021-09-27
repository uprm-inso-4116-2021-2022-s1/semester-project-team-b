using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.API.Services.Interfaces;
using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;

        }

        [HttpGet]
        public UserDTO Get([FromQuery] string username, [FromQuery] string password) => _userAppService.Get(username, password);

        [HttpPost]
        [Route("add")]
        public void Add([FromQuery] UserDTO user) => _userAppService.Add(user);

    }
}
