using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories
{
    public interface IRecipeRepository
    {
        public Recipe FindRecipesByName(string name);
        public IEnumerable<Recipe> GetRecipesContaining(IEnumerable<string>ingredients, IEnumerable<string> appliances);
        public void Update(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt);
        public Recipe Add(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt, string username, string password);

    }
}
