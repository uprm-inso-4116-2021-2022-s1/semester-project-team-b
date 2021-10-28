using SList.Commons.DataTransferObjects;
using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Commons.Extensions
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
                CreatedAt = user.CreatedAt,
                Comments = user.Comments
                    ?.Select(c => c.ToCommentDTO())
                    .ToList() ?? new List<CommentDTO>()
            };

    }
}
