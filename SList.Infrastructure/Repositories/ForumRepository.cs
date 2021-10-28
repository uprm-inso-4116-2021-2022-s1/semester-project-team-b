using SList.Infrastructure.Factories;
using SList.Domain.Models;
using SList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Infrastructure.Repositories
{
    public class ForumRepository : IForumRepository
    {
        private SListContextFactory _contextFactory;

        public ForumRepository(SListContextFactory factory)
        {
            _contextFactory = factory;

        }

        public Forum Add(string name, string content, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void AddComment(string name, string username, string password, string commentContent, string parentContent)
        {
            throw new NotImplementedException();
        }

        public void Get(string name, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(string name, string username, string password, string newName)
        {
            throw new NotImplementedException();
        }

        public void UpdateComment(string name, string username, string password, string commentContent, string parentContent, string updatedContent)
        {
            throw new NotImplementedException();
        }
    }
}
