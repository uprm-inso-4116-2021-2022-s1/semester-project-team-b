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
        [HttpGet]
        public UserDTO Get([FromQuery] string username, [FromQuery] string password) => _userAppService.Get(username, password);

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        [Route("add")]
        public void Add([FromQuery] UserDTO user) => _userAppService.Add(user);

        /// <summary>
        /// Changes password
        /// </summary>
        /// <param name="password"></param>
        [HttpPost]
        [Route("edit_password")]
        public void EditPassword([FromQuery] string password) => _userAppService.EditPassword(password);

        [HttpDelete]
        [Route("delete_account")]
        public void DeleteAccount([FromQuery] string username) => _userAppService.DeleteAccount(username);

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
                => _userAppService.AddPantry(pantryName,
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
                => _userAppService.UpdatePantry(pantryName,
                                                    appliances,
                                                    ingredients);


        /// <summary>
        /// Find existing pantries
        /// </summary>
        /// <param name="pantryName"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get_pantry")]
        public PantryDTO findPantry([FromQuery] string pantryName) => _userAppService.findPantry(pantryName);
    }
}
