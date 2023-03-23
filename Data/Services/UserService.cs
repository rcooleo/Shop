using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data.Services
{
    public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Addasync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public void Delete(Guid GameId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            var result = await _context.Users.ToListAsync();
            return result;
        }

        public async Task<User> GetById(Guid UserId)
        {
            var result = await _context.Users.FirstOrDefaultAsync(n => n.UserId == UserId);
            return result;
        }

        public async Task<User> UpdateAsync(Guid UserId, User newUser)
        {
            _context.Update(newUser);
            await _context.SaveChangesAsync();
            return newUser;
        }

        public async Task DeleteAsync(Guid UserId)
        {
            var result = await _context.Users.FirstOrDefaultAsync(n => n.UserId == UserId);
            _context.Users.Remove(result);
            await _context.SaveChangesAsync();
        }

    }
}
