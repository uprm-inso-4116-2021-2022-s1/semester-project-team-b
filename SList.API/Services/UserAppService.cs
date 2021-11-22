using SList.API.Services.Interfaces;
using SList.Commons.DataTransferObjects;
using SList.Commons.Extensions;
using SList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class UserAppService : IUserAppService
    {
        private IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(UserDTO user)
        {
            _userRepository.Add(user.Username,
                user.Email,
                user.FirstName,
                user.LastName,
                user.Password,
                createdAt: DateTime.Now,
                updatedAt: user.UpdatedAt);
        }

        public void AddPantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients)
        {
            throw new NotImplementedException();
        }

        public void DeleteAccount(string username)
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

        public PantryDTO FindPantry(string pantryName)
        {
            throw new NotImplementedException();
        }


        public UserDTO Get(string username, string password) => _userRepository.Get(username, password)?.ToUserDTO();
        public void Update(UserDTO user, string username, string password)
        {
            throw new NotImplementedException();
        }

        public void UpdatePantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients)
        {
            throw new NotImplementedException();
        }

        public void UpdatePantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients, string username)
        {
            throw new NotImplementedException();
        }

        public PantryDTO FindPantry(string pantryName, string username)
        {
            throw new NotImplementedException();
        }

         public IEnumerable<RecipeDTO> FindRecipesByUser(string username)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PantryDTO> GetPantries(string username)
        {
            throw new NotImplementedException();
        }
    }
}
