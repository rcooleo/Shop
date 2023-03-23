using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid UserId);
        Task Addasync(User user);
        Task<User> UpdateAsync(Guid UserId, User newUser);
        Task DeleteAsync(Guid UserId);
    }
}
