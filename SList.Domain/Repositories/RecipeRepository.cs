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

        public Recipe Add(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt, string username, string password)
        {
            throw new NotImplementedException();
        }

        public Recipe Get(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> GetRecipesContaining(IEnumerable<string> ingredients, IEnumerable<string> appliances)
        {
            throw new NotImplementedException();
        }

        public void Update(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt)
        {
            throw new NotImplementedException();
        }
    }
}
