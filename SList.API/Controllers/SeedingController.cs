using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeedingController : ControllerBase
    {
        private ISeedingRepository _seedingRepository;

        public SeedingController(ISeedingRepository seedingRepository) => _seedingRepository = seedingRepository;

        [HttpPost]
        [Route("")]
        public void Seed() => _seedingRepository.Seed();
    }
}
