using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Services
{
    public interface IGameService
    {
        Task<IEnumerable<Game>> GetAll();
        Task<Game> GetById(Guid GameId);
        Task Addasync(Game game);
        Task<Game> UpdateAsync(Guid GameId, Game newGame);
        Task DeleteAsync(Guid GameId);
    }
}
