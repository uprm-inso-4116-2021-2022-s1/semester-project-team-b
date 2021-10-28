using SList.Commons.DataTransferObjects;
using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Commons.Extensions
{
    public static class CommentExtensions
    {
        public static CommentDTO ToCommentDTO(this Comment comment) =>
            new CommentDTO
            {
            };

    }
}
