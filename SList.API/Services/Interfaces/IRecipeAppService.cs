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

        public void Add(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionsDTO> instructions);

        public void Update(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionsDTO> instructions);

        public List<RecipeDTO> FindRecipes(List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients);

    }
}
