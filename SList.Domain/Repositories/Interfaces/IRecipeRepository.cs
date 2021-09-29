using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        public Recipe Get(string name);
        public IEnumerable<Recipe> GetRecipesContaining(IEnumerable<string>ingredients, IEnumerable<string> appliances);
        public void Update(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt);
        public Recipe Add(string name, string content, IEnumerable<string> ingredients, IEnumerable<string> appliances, DateTime updatedAt, string username, string password);

    }
}
