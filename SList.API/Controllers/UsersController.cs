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
    public class UsersController : ControllerBase
    {
        private IUserAppService _userAppService;

        public UsersController(IUserAppService userAppService)
        {
            _userAppService = userAppService;

        }

        /// <summary>
        /// Find existing user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [Route("{username}")]
        [HttpGet]
        public UserDTO Get([FromRoute] string username, [FromQuery] string password) => 
            _userAppService.Get(username, password);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        [Route("add")]
        public void Add([FromBody] UserDTO user) => 
            _userAppService.Add(user);

        /// <summary>
        /// Changes password for resigtered user
        /// </summary>
        /// <param name="password"></param>
        /// <param name="email"></param>
        [HttpPost]
        [Route("{email}/change_password")]
        public void changePasswordByEmail([FromQuery] string password, [FromRoute] string email) => 
            _userAppService.ChangePasswordByEmail(password, email);
        /// <summary>
        /// Changes password for resigtered email
        /// </summary>
        /// <param name="password"></param>
        /// <param name="username"></param>
        [HttpPost]
        [Route("{username}/change_password")]
        public void changePasswordByUsername([FromQuery] string password, [FromRoute] string username) => 
            _userAppService.ChangePasswordByUsername(password, username);
        [HttpDelete]
        
        [Route("{username}/delete_account")]
        public void DeleteAccount([FromRoute] string username) => _userAppService.DeleteAccount(username);

        /// <summary>
        /// Creates a pantry with list of appliances and ingredients
        /// </summary>
        /// <param name="pantryName"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        [HttpPost]
        [Route("{username}/pantries/add")]
        public void AddPantry([FromQuery] string pantryName,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients)
                => _userAppService.AddPantry(pantryName,
                    appliances,
                    ingredients);

        /// <summary>
        /// Updates existing pantry
        /// </summary>
        /// <param name="pantryName"></param>
        /// <param name="appliances"></param>
        /// <param name="ingredients"></param>
        /// <param name="username"></param>
        [HttpPost]
        [Route("{username}/pantries/update")]
        public void UpdatePantry([FromQuery] string pantryName,
            [FromQuery] List<ApplianceDTO> appliances,
            [FromQuery] List<IngredientDTO> ingredients,
            [FromRoute] string username)
                => _userAppService.UpdatePantry(
                    pantryName,
                    appliances,
                    ingredients,
                    username);

        /// <summary>
        /// Find existing pantries
        /// </summary>
        /// <param name="pantryName"></param>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{username}/pantries/{pantryName}")]
        public PantryDTO FindPantry([FromQuery] string pantryName, [FromRoute] string username)
            => _userAppService.FindPantry(pantryName, username);
        /// <summary>
        /// Find existing pantries
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{username}/pantries")]
        public IEnumerable<PantryDTO> GetPantries([FromRoute] string username)
            => _userAppService.GetPantries(username).ToList();

        /// <summary>
        /// Find existing recipes for user
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{username}/recipes")]
        public List<RecipeDTO> FindRecipesByUser([FromRoute] string username) 
            => _userAppService.FindRecipesByUser(username).ToList();
    }
}
