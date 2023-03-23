using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Data.Services;
using Shop.Models;

namespace Shop.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameService _service;

        public GameController(IGameService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get: Game/Create

        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create([Bind("GameTitle,GamePictureURL,Genre,Price")]Game game)
        {
            if (!ModelState.IsValid)
            {
                return View(game);
            }
            await _service.Addasync(game);
            return RedirectToAction(nameof(Index));
        }
        

        //Get: Game/Details/1

        public async Task<IActionResult> Details(Guid GameId)
        {
            var gameDetails = await _service.GetById(GameId);

            if (gameDetails == null) return View("NotFound");
            return View(gameDetails);
        }

        //Get: Game/Edit
        public async Task<IActionResult> Edit(Guid GameId)
        {
            var actorDetails = await _service.GetById(GameId);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Guid GameId, [Bind("GameId,GameTitle,GamePictureURL,Genre,Price")] Game game)
        {  

            if (!ModelState.IsValid)
            {
                return View(game);
            }
            await _service.UpdateAsync(GameId, game);
            return RedirectToAction(nameof(Index));
        }

        //Get: Game/Delete

        public async Task<IActionResult> Delete(Guid GameId)
        {
            var gameDetails = await _service.GetById(GameId);
            if (gameDetails == null) return View("NotFound");
            return View(gameDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Guid GameId)
        {
            var gameDetails = await _service.GetById(GameId);
            if (gameDetails == null) return View("NotFound");

            await _service.DeleteAsync(GameId);
            return RedirectToAction(nameof(Index));
        }
    }
}