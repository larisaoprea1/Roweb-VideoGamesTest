using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RoWebVideoGames.Models;

namespace RoWebVideoGames.Data
{
    public class VideoGamesContext : DbContext
    {
        public VideoGamesContext (DbContextOptions<VideoGamesContext> options)
            : base(options)
        {
        }

        public DbSet<RoWebVideoGames.Models.Games>? Games { get; set; }
    }
}
