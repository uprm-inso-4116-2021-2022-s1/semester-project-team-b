using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services.Interfaces
{
    public interface IRecipeAppService
    {
        public RecipeDTO Get(string RecipeName);

        void Add(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionDTO> instructions);

        void Update(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionDTO> instructions);

        List<RecipeDTO> FindRecipes(List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients);

        void AddPantry(string pantryName, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients);

        void UpdatePantry(string pantryName, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients);

        PantryDTO findPantry(string pantryName);
    }
}
