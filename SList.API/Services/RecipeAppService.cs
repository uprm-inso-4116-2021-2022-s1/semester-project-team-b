using SList.API.Services.Interfaces;
using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class RecipeAppService : IRecipeAppService
    {
        public void Add(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionDTO> instructions)
        {
            throw new NotImplementedException();
        }

        public void AddPantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients)
        {
            throw new NotImplementedException();
        }

        public PantryDTO findPantry(string pantryName)
        {
            throw new NotImplementedException();
        }

        public List<RecipeDTO> FindRecipes(List<ApplianceDTO> appliances, List<IngredientDTO> ingredients)
        {
            throw new NotImplementedException();
        }

        public RecipeDTO Get(string RecipeName)
        {
            throw new NotImplementedException();
        }

        public void Update(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionDTO> instructions)
        {
            throw new NotImplementedException();
        }

        public void UpdatePantry(string pantryName, List<ApplianceDTO> appliances, List<IngredientDTO> ingredients)
        {
            throw new NotImplementedException();
        }
    }
}
