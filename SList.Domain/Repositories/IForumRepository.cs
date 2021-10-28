using SList.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SList.Domain.Repositories
{
    public interface IForumRepository 
    {
        public void Get(string title, string username, string password);
        public void Update(string title, string username, string password, string newName);
        public Forum Add(string title, string content, string username, string password);
        public void AddComment(string title, string username, string password, string commentContent, string parentContent);
        public void UpdateComment(string title, string username, string password, string commentContent, string parentContent, string updatedContent);
    }
}
