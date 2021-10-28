using SList.Infrastructure.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Infrastructure.Repositories
{
    public class SeedingRepository
    {
        private SListContextFactory _contextFactory;

        public SeedingRepository(SListContextFactory factory) => _contextFactory = factory;
        public void Seed()
        {
            throw new NotImplementedException();
        }
    }
}
