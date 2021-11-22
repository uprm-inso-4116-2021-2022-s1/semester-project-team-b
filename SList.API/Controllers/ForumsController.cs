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
        [Route("{title}")]
        public ForumDTO Get(
            [FromRoute] string title,
            [FromQuery] string username,
            [FromQuery] string password)
                => _forumAppService.Get(
                    title,
                    username,
                    password);
        [HttpPost]
        [Route("{title}/update")]
        public void Update(
            [FromRoute] string title,
            [FromQuery] string username,
            [FromQuery] string password,
            [FromQuery] string newName)
                => _forumAppService.Update(
                    title,
                    username,
                    password, 
                    newName);
        [HttpPost]
        [Route("add/{title}")]
        public void Add(
            [FromRoute] string title,
            [FromQuery] string content,
            [FromQuery] string username,
            [FromQuery] string password) 
                => _forumAppService.Add(
                    title,
                    content,
                    username,
                    password);
        [HttpPost]
        [Route("{title}/comments/add")]
        public void AddComment(
            [FromRoute] string title,
            [FromQuery] string username,
            [FromQuery] string password,
            [FromQuery] string commentContent, 
            [FromQuery] string parentContent) 
                => _forumAppService.AddComment(
                    title, 
                    username,
                    password,
                    commentContent, 
                    parentContent);
        [HttpPost]
        [Route("{title}/comments/update")]
        public void UpdateComment(
            [FromRoute] string title,
            [FromQuery] string username, 
            [FromQuery] string password, 
            [FromQuery] string commentContent, 
            [FromQuery] string parentContent,
            [FromQuery] string updatedContent) 
                => _forumAppService.UpdateComment(
                    title,
                    username,
                    password, 
                    commentContent, 
                    parentContent,
                    updatedContent);

    }
}
