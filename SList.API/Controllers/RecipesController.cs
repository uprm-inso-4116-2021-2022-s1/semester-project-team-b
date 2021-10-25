using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SList.API.Services.Interfaces;
using SList.Domain.Models.DataTransferObjects;
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
        /// Gets the recipe according its name
        /// </summary>
        /// <param name="recipeName"></param>
        /// <returns></returns>
        [HttpGet]
        public RecipeDTO Get([FromQuery] string recipeName) 
            => _recipeAppService.Get(recipeName);

        /// <summary>
        /// Gets list of recipes according to appliances and/or ingredients
        /// </summary>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("find_recipes")]
        public List<RecipeDTO> FindRecipes([FromQuery] List<ApplianceDTO> appliances, [FromQuery] List<IngredientDTO> ingredients)
            => _recipeAppService.FindRecipes(appliances, ingredients);

        /// <summary>
        /// Adds a new recipe
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="cookTime"></param>
        /// <param name="prepTime"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <param name="instructions"></param>
        [HttpPost]
        [Route("add_recipe")]
        public void Add([FromQuery] string recipeName,
            [FromQuery] TimeSpan cookTime,
            [FromQuery] TimeSpan prepTime,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients,
            [FromQuery] List<InstructionDTO> instructions)
                => _recipeAppService.Add(recipeName,
                                            cookTime,
                                            prepTime,
                                            appliances,
                                            ingredients,
                                            instructions);

        /// <summary>
        /// Updates an existing recipe
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="cookTime"></param>
        /// <param name="prepTime"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <param name="instructions"></param>
        [HttpPost]
        [Route("update_recipe")]
        public void Update([FromQuery] string recipeName,
            [FromQuery] TimeSpan cookTime,
            [FromQuery] TimeSpan prepTime,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients,
            [FromQuery] List<InstructionDTO> instructions) 
                => _recipeAppService.Update(recipeName,
                                            cookTime, 
                                            prepTime, 
                                            appliances, 
                                            ingredients, 
                                            instructions);

        /// <summary>
        /// Creates a pantry with list of appliances and ingredients
        /// </summary>
        /// <param name="pantryName"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        [HttpPost]
        [Route("add_pantry")]
        public void AddPantry([FromQuery] string pantryName,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients)
                => _recipeAppService.AddPantry(pantryName,
                                                appliances,
                                                ingredients);

        /// <summary>
        /// Updates existing pantry
        /// </summary>
        /// <param name="pantryName"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        [HttpPost]
        [Route("update_pantry")]
        public void UpdatePantry([FromQuery] string pantryName,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients)
                => _recipeAppService.UpdatePantry(pantryName,
                                                    appliances,
                                                    ingredients);


        /// <summary>
        /// Find existing pantries
        /// </summary>
        /// <param name="pantryName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get_pantry")]
        public PantryDTO findPantry([FromQuery] string pantryName) => _recipeAppService.findPantry(pantryName);
    }
}
