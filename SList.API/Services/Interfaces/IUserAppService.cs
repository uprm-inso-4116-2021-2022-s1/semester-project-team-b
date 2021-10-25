using SList.Domain.Models.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SList.API.Services.Interfaces
{
    public interface IUserAppService
    {
        public UserDTO Get(string username, string password);
        public void Add(UserDTO user);
        void EditPassword(string password);
        string DeleteAccount(string username);
    }
}
