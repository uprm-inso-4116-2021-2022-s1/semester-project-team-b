using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumsController : ControllerBase
    {
        private IForumAppService _forumAppService;

        public ForumsController(IForumAppService forumAppService)
        {
            _forumAppService = forumAppService;

        }
    }
}
