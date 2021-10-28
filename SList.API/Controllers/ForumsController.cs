using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.API.Services.Interfaces;
using SList.Commons.DataTransferObjects;
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
        
        [HttpGet]
        public ForumDTO Get([FromQuery] string forumpost) => _forumAppService.Get(forumpost);
        
        [HttpPost]
        [Route("post_forum")]
        public void Add([FromQuery] ForumDTO forum) => _forumAppService.Add(forum);

        [HttpPost]
        [Route("edit_forum")]
        public void EditForum([FromQuery] string forumpost) => _forumAppService.EditForum(forumpost);

    }
}
