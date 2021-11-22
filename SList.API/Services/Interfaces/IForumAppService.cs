using SList.Commons.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services.Interfaces
{
    public interface IForumAppService
    {
        public ForumDTO Get(string title, string username, string password);
        public void Update(string title, string username, string password, string newName);
        public void Add(string title, string content, string username, string password);
        public void AddComment(string title, string username, string password, string commentContent, string parentContent);
        public void UpdateComment(string title, string username, string password, string commentContent, string parentContent, string updatedContent);
    }
}
