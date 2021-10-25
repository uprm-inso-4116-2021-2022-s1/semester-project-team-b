using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services.Interfaces
{
    public interface IForumAppService
    {
        public ForumDTO Get(string forumpost);
        public void Add(ForumDTO forum);
        void EditForum(string forumpost);
    }
}
