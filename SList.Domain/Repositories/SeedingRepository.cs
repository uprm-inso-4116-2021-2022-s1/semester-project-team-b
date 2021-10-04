using SList.Domain.Factories;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories
{
    public class SeedingRepository : ISeedingRepository
    {
        private SListContextFactory _contextFactory;

        public SeedingRepository(SListContextFactory factory) => _contextFactory = factory;
        public void Seed()
        {
            throw new NotImplementedException();
        }
    }
}
