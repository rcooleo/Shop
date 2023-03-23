using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Data;
using Shop.Models;
using Shop.Data.Services;

namespace Shop.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }


        public IActionResult Login()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {

            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup([Bind("Firstname,Lastname,Username,Age,UserEmail,EmailConfirmed,Userpassword")]User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            await _service.Addasync(user);
            return RedirectToAction(nameof(Signup));
        }

        public IActionResult Singout()
        {
           // var data = _context.Users.ToList();
            return View();
        }
    }
}