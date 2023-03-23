using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var ServiceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = ServiceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Games
                var con = context;
                if (!context.Games.Any())
                {
                    context.Games.AddRange(new List<Game>()
                    {
                        new Game()
                        {
                            GameId = Guid.NewGuid(),
                            GameTitle = "testtitle",
                            Genre = Genre.Action,
                            Price = 33,
                            GamePictureURL = ""
                        },
                        new Game()
                        {
                            GameId = Guid.NewGuid(),
                            GameTitle = "testtitle",
                            Genre = Genre.Action,
                            Price = 33,
                            GamePictureURL = ""
                        }
                    });
                    context.SaveChanges();
                }
                //Person
               
                //Person_Games
              
            }
        }
    }
}
