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

                //User
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            UserId = 'F645905F-6434-4600-ADDD-BB6925B870B3',
                            Firstname = "admin",
                            Lastname = "admin",
                            Age = 18,
                            UserEmail = "admin@admit.at",
                            UserPassword = "admin",                                           
                        },
                        new User()
                        {
                           UserId = '48DFEF30-223E-4F62-B727-53C649701341',
                            Firstname = "user",
                            Lastname = "user",
                            Age = 18,
                            UserEmail = "user@user.at",
                            UserPassword = "user",
                        }
                    });
                    context.SaveChanges();
                }

                //User
                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            UserId = 'F645905F-6434-4600-ADDD-BB6925B870B3',
                            Firstname = "admin",
                            Lastname = "admin",
                            Age = 18,
                            UserEmail = "admin@admit.at",
                            UserPassword = "admin",
                        },
                        new User()
                        {
                           UserId = '48DFEF30-223E-4F62-B727-53C649701341',
                            Firstname = "user",
                            Lastname = "user",
                            Age = 18,
                            UserEmail = "user@user.at",
                            UserPassword = "user",
                        }
                    });
                    context.SaveChanges();
                }

                //Person_Games

            }
        }
    }
}
