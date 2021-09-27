using SList.Domain.Factories;
using SList.Domain.Models;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories
{
    public class ForumRepository : IForumRepository
    {
        private SListContextFactory _contextFactory;

        public ForumRepository(SListContextFactory factory)
        {
            _contextFactory = factory;

        }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Add(Forum enity)
        {
            throw new NotImplementedException();
        }

        public Forum Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Forum> GetAll()
        {
            throw new NotImplementedException();
        }

        public Forum Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
