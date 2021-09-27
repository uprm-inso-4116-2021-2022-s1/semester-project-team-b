using SList.API.Services.Interfaces;
using SList.Domain.Extensions;
using SList.Domain.Models;
using SList.Domain.Models.DataTransferObjects;
using SList.Domain.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services
{
    public class UserAppService : IUserAppService
    {
        private IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Add(UserDTO user)
        {
            _userRepository.Add(user.Username,
                user.Email,
                user.FirstName,
                user.LastName,
                user.Password,
                createdAt: DateTime.Now,
                updatedAt: user.UpdatedAt);
        }
        public UserDTO Get(string username, string password) => _userRepository.Get(username, password)?.ToUserDTO();
    }
}
