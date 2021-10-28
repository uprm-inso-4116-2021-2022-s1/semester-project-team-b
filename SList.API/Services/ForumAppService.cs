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
        public void Add(ForumDTO forum)
        {
            throw new NotImplementedException();
        }

        public void EditForum(string forum)
        {
            throw new NotImplementedException();
        }

        public ForumDTO Get(string forumpost)
        {
            throw new NotImplementedException();
        }
    }
}
