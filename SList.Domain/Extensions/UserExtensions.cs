using SList.Domain.Models;
using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Extensions
{
    public static class UserExtensions
    {
        public static UserDTO ToUserDTO(this User user) =>
            new UserDTO
            {
                Username = user.Username,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Password = user.Password,
                UpdatedAt = user.UpdatedAt,
                CreatedAt = user.CreatedAt
            };

    }
}
