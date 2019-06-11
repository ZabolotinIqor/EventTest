using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.DTOs;
using Event.EntityFramework;
using Event.Models;
using Microsoft.EntityFrameworkCore;

namespace Event.Services
{
    public class UserService : IUserService
    {
        private readonly EventDbContext context;

        public UserService(EventDbContext context)
        {
            this.context = context;
        }
        public async Task<User> Reqister(ReqisterDTO user)
        {
            var _user = new User()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            await context.User.AddAsync(_user);
            await context.SaveChangesAsync();
            return _user;

        }

        public async Task DeleteUser(int id)
        {
            var res = context.User.FirstOrDefault(p => p.Id == id);
            context.User.Remove(res);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await context.User.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            return await context.User.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<User> Login(LoginDTO loginDto)
        {
            var result = await context.User.FirstOrDefaultAsync(p => p.Email == loginDto.email);
            return result;
        }

        public async Task<User> UpdateUser(User user)
        {
            var _user = await context.User.FirstOrDefaultAsync(p => p.Id == user.Id);
            _user.FirstName = user.FirstName;
            _user.LastName = user.LastName;
            _user.Email = user.Email;
            await context.SaveChangesAsync();
            return _user;
        }
    }
}
