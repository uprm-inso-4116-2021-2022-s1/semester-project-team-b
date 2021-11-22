using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.API.Services.Interfaces;
using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private IRecipeAppService _recipeAppService;

        public RecipesController(IRecipeAppService recipeAppService)
        {
            _recipeAppService = recipeAppService;

        }

        /// <summary>
        /// Gets the recipes according its name
        /// </summary>
        /// <param name="recipeName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{recipeName}")]
        public List<RecipeDTO> FindRecipesByName([FromRoute] string recipeName)
            => _recipeAppService.FindRecipesByName(recipeName);

        /// <summary>
        /// Gets list of recipes according to appliances and/or ingredients
        /// </summary>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("find")]
        public List<RecipeDTO> FindRecipes(
            [FromQuery] List<ApplianceDTO> appliances, 
            [FromQuery] List<IngredientDTO> ingredients)
            => _recipeAppService.FindRecipes(appliances, ingredients);

        /// <summary>
        /// Gets list of recipes according to pantry items
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("find_by_pantry")]
        public List<RecipeDTO> FindRecipesByPantry(PantryDTO pantry)
            => _recipeAppService.FindRecipesByPantry(pantry);

        /// <summary>
        /// Adds a new recipe
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="username"></param>s
        /// <param name="cookTime"></param>
        /// <param name="prepTime"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <param name="instructions"></param>
        [HttpPost]
        [Route("add")]
        public void Add([FromQuery] string recipeName,
            [FromQuery] string username,
            [FromQuery] TimeSpan cookTime,
            [FromQuery] TimeSpan prepTime,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients,
            [FromQuery] List<InstructionsDTO> instructions)
                => _recipeAppService.Add(recipeName,
                    username,
                    cookTime,
                    prepTime,
                    appliances,
                    ingredients,
                    instructions);

        /// <summary>
        /// Updates an existing recipe
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="username"></param>
        /// <param name="cookTime"></param>
        /// <param name="prepTime"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <param name="instructions"></param>
        [HttpPost]
        [Route("{recipeName}/update")]
        public void Update([FromRoute] string recipeName,
            [FromQuery] string username,
            [FromQuery] TimeSpan cookTime,
            [FromQuery] TimeSpan prepTime,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients,
            [FromQuery] List<InstructionsDTO> instructions)
                => _recipeAppService.Update(
                    recipeName,
                    username,
                    cookTime,
                    prepTime,
                    appliances,
                    ingredients,
                    instructions);


    }
}