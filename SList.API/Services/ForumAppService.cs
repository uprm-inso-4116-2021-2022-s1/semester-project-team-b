using SList.API.Services.Interfaces;
using SList.Commons.DataTransferObjects;
using SList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class ForumAppService : IForumAppService
    {
        private IForumRepository _forumRepository;

        public ForumAppService(IForumRepository forumRepository)
        {
            _forumRepository = forumRepository;
        }

        public void Add(string title, string content, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void AddComment(string title, string username, string password, string commentContent, string parentContent)
        {
            throw new NotImplementedException();
        }

        public ForumDTO Get(string title, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(string title, string username, string password, string newName)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(string title, string username, string password, string commentContent, string parentContent, string updatedContent)
        {
            throw new NotImplementedException();
        }
    }
}
