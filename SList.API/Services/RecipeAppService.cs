using SList.API.Services.Interfaces;
using SList.Commons.DataTransferObjects;
using SList.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class RecipeAppService : IRecipeAppService
    {
        private IRecipeRepository _recipeRepository;

        public RecipeAppService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public void Add(string recipeName, 
            TimeSpan cookTime, 
            TimeSpan prepTime, 
            List<ApplianceDTO> appliances, 
            List<IngredientDTO> ingredients, 
            List<InstructionsDTO> instructions)
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
            List<InstructionsDTO> instructions)
        {
            throw new NotImplementedException();
        }

    }
}
