using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services.Interfaces
{
    public interface IUserAppService
    {
        public UserDTO Get(string username, string password);
        public void Add(UserDTO user);
        public void Update(UserDTO user, string username, string password);
        public void ChangePasswordByEmail(string password, string email);
        public void ChangePasswordByUsername(string password, string username);
        public void DeleteAccount(string username);
        public void AddPantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients);
        public void UpdatePantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients, string username);
        public PantryDTO FindPantry(string pantryName, string username);
        public IEnumerable<RecipeDTO> FindRecipesByUser(string username);
        public IEnumerable<PantryDTO> GetPantries(string username);
    }
}
