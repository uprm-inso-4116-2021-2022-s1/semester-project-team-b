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
    public class UserRepository : IUserRepository
    {
        private SListContextFactory _contextFactory;

        public UserRepository(SListContextFactory factory) => _contextFactory = factory;
        public void Add(
            string username,
            string email,
            string firstName,
            string lastName,
            string password,
            DateTime createdAt,
            DateTime? updatedAt)
        {
            using (var ctx = _contextFactory.CreateDbContext())
            {
                ctx.Add(new User 
                {
                    Username = username,
                    CreatedAt = createdAt,
                    Email = email,
                    FirstName = firstName,
                    LastName = lastName,
                    Password = password,
                    UpdatedAt = updatedAt
                });
                ctx.SaveChanges();
            };
        }

        public void AddPantry(string pantryName, List<Appliance> appliances, List<Ingredient> ingredients, string username)
        {
            throw new NotImplementedException();
        }

        public void ChangePasswordByEmail(string password, string email)
        {
            throw new NotImplementedException();
        }

        public void ChangePasswordByUsername(string password, string username)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(string username)
        {
            throw new NotImplementedException();
        }

        public Pantry FindPantry(string pantryName, string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Recipe> FindRecipesByUser(string username)
        {
            throw new NotImplementedException();
        }

        public User Get(string username, string password)
        {
            using var ctx = _contextFactory.CreateDbContext();

            return ctx
                .Users
                .Where(u => u.Username == username && u.Password == password)
                .FirstOrDefault();
        }

        public IEnumerable<Pantry> GetPantries(string username)
        {
            throw new NotImplementedException();
        }

        public void Update(string username, string email, string firstName, string lastName, string password, DateTime updatedAt)
        {
            throw new NotImplementedException();
        }

        public void UpdatePantry(string pantryName, List<Appliance> appliances, List<Ingredient> ingredients, string username)
        {
            throw new NotImplementedException();
        }
    }
}
