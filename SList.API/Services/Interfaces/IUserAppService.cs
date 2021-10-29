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
        public void EditPassword(string password);
        public void DeleteAccount(string username);
        void AddPantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients);
        void UpdatePantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients);
        PantryDTO findPantry(string pantryName);
    }
}
