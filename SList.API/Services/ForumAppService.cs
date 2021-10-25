using SList.API.Services.Interfaces;
using SList.Domain.Extensions;
using SList.Domain.Models;
using SList.Domain.Models.DataTransferObjects;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class ForumAppService : IForumAppService
    {
        private IForumAppService _forumRepository;

        public ForumAppService(IForumAppService forumRepository)
        {
            _forumRepository = forumRepository;
        }
        public void Add(ForumDTO forum)
        {
            _forumRepository.Add(forum.Name,
                forum.Content,
                createdAt: DateTime.Now,
                forum.User
                updatedAt: forum.UpdatedAt);
        }

        public void EditForum(string forum)
        {
            throw new NotImplementedException();
        }

        public ForumDTO Get(stirng forumpost) => _forumRepository.Get(forumpost)?.ToForumDTO();
    }
}
