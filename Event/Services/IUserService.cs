using Event.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Event.Services
{
    public interface IUserService
    {
        Task<User> Login();
        Task<User> AddUser(User user);
        Task DeleteUser(int id);
        Task<User> UpdateUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
    }
}
