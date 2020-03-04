using System;
using System.Linq;
using SavySodaDemo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace SavySodaDemo.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesGameContext(
                serviceProvider.GetRequiredService<
                DbContextOptions<RazorPagesGameContext>>()))
            {
                // Check if any games are already in the database
                if (context.Game.Any())
                {
                    return; // DB has already been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        ID = 1,
                        Title = "Pixel Starships",
                        ReleaseDate = DateTime.Parse("2016-1-6"),
                        Genre = "MMO",
                        ImageUrl = "https://savysodademostorage.blob.core.windows.net/savysodademoblob/pixel-starships.png",
                        Description = "Pixel Starships is the world’s first total spaceship management game in an 8bit massive online universe. In Pixel Starships, you command every aspect of your ship from construction to battles in a single persistent world."
                    },

                    new Game
                    {
                        ID = 2,
                        Title = "Devil May Cry 5",
                        ReleaseDate = DateTime.Parse("2019-3-8"),
                        Genre = "Action",
                        ImageUrl = "https://savysodademostorage.blob.core.windows.net/savysodademoblob/devil-may-cry-5.jpg",
                        Description = "The ultimate Devil Hunter is back in style, in the game action fans have been waiting for."
                    },

                    new Game
                    {
                        ID = 3,
                        Title = "Death Stranding",
                        ReleaseDate = DateTime.Parse("2019-11-8"),
                        Genre = "Walking Simulator",
                        ImageUrl = "https://savysodademostorage.blob.core.windows.net/savysodademoblob/death-stranding.jpg",
                        Description = "From legendary game creator Hideo Kojima comes an all-new, genre-defying experience. Sam Bridges must brave a world utterly transformed by the Death Stranding. Carrying the disconnected remnants of our future in his hands, he embarks on a journey to reconnect the shattered world one step at a time."
                    },

                    new Game
                    {
                        ID = 4,
                        Title = "Monster Hunter World",
                        ReleaseDate = DateTime.Parse("2018-8-10"),
                        Genre = "Action RPG",
                        ImageUrl = "https://savysodademostorage.blob.core.windows.net/savysodademoblob/monster-hunter-world.jpg",
                        Description = "Welcome to a new world! In Monster Hunter: World, the latest installment in the series, you can enjoy the ultimate hunting experience, using everything at your disposal to hunt monsters in a new world teeming with surprises and excitement."
                    },

                    new Game
                    {
                        ID = 5,
                        Title = "Divinity Original Sin 2",
                        ReleaseDate = DateTime.Parse("2017-09-14"),
                        Genre = "Turn-Based RPG",
                        ImageUrl = "https://savysodademostorage.blob.core.windows.net/savysodademoblob/divinity-original-sin-2.jpg",
                        Description = "The eagerly anticipated sequel to the award-winning RPG. Gather your party. Master deep, tactical combat. Join up to 3 other players - but know that only one of you will have the chance to become a God."
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
