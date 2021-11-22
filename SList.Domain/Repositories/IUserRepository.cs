using SList.Domain.Models;
using System;
using System.Collections.Generic;

namespace SList.Domain.Repositories
{
    public interface IUserRepository
    {
        public void ChangePasswordByEmail(string password, string email);
        public void ChangePasswordByUsername(string password, string username);
        public void DeleteAccount(string username);
        public void AddPantry(string pantryName, List<Appliance> appliances, List<Ingredient> ingredients, string username);
        public void UpdatePantry(string pantryName, List<Appliance> appliances, List<Ingredient> ingredients, string username);
        public Pantry FindPantry(string pantryName, string username);
        public IEnumerable<Pantry> GetPantries(string username);
        public IEnumerable<Recipe> FindRecipesByUser(string username);
        public User Get(string username, string password);
        public void Add(string username, string email, string firstName, string lastName, string password, DateTime createdAt, DateTime? updatedAt);
        public void Update(string username, string email, string firstName, string lastName, string password, DateTime updatedAt);
    }
}
