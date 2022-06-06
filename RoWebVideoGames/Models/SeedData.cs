using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RoWebVideoGames.Data;
using System;
using System.Linq;

namespace RoWebVideoGames.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new VideoGamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<VideoGamesContext>>()))
            {
                // Look for any movies.
                if (context.Games.Any())
                {
                    return;   // DB has been seeded
                }

                context.Games.AddRange(
                    new Games
                    {
                        Title = "League of Legends",
                        ReleaseDate = DateTime.Parse("2009-10-27"),
                        Genre = "MOBA ARPG",
                        Price = 0M
                    },

                    new Games
                    {
                        Title = "Fall Guys: Ultimate Knockout",
                        ReleaseDate = DateTime.Parse("2020-8-4"),
                        Genre = "Battle Royale Platformer",
                        Price = 29.99M
                    },

                    new Games
                    {
                        Title = "Grand Theft Auto V",
                        ReleaseDate = DateTime.Parse("2013-9-17"),
                        Genre = " Singleplayer Multiplayer",
                        Price = 59.99M
                    },

                    new Games
                    {
                        Title = "Counter-Strike: Global Offensive",
                        ReleaseDate = DateTime.Parse("2012-8-21"),
                        Genre = "Multiplayer",
                        Price = 29.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}