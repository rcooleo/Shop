using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Data.Services
{
    public class GameService : IGameService
    {
        private readonly AppDbContext _context;
        public GameService(AppDbContext context)
        {
            _context = context;
        }

        public async Task Addasync(Game game)
        {
            await _context.Games.AddAsync(game);
            await _context.SaveChangesAsync();
        }

        public void Delete(Guid GameId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Game>> GetAll()
        {
            var result = await _context.Games.ToListAsync();
            return result;
        }

        public async Task<Game> GetById(Guid GameId)
        {
            var result = await _context.Games.FirstOrDefaultAsync(n => n.GameId == GameId);
            return result;
        }

        public async Task<Game> UpdateAsync(Guid GameId, Game newGame)
        {
            _context.Update(newGame);
            await _context.SaveChangesAsync();
            return newGame;
        }

        public async Task DeleteAsync(Guid GameId)
        {
            var result = await _context.Games.FirstOrDefaultAsync(n => n.GameId == GameId);
            _context.Games.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
