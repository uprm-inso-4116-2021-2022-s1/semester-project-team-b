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
    public class RecipeRepository : IRecipeRepository
    {
        private SListContextFactory _contextFactory;

        public RecipeRepository(SListContextFactory factory)
        {
            _contextFactory = factory;

        }
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Add(Recipe enity)
        {
            throw new NotImplementedException();
        }

        public Recipe Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public Recipe Remove()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
