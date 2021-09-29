using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public User Get(string username, string password);
        public void Add(string username, string email, string firstName, string lastName, string password, DateTime createdAt, DateTime? updatedAt);
        public void Update(string username, string email, string firstName, string lastName, string password, DateTime updatedAt);
        public IEnumerable<Pantry> GetPantries(string username, string email, params string[] pantryNames);
        public IEnumerable<Recipe> GetRecipes(string username, string email, params string[] pantryNames);
    }
}
