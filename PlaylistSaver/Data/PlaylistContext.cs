using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PlaylistSaver.Data
{
    public class PlaylistContext:DbContext
    {
        
        public DbSet<YoutubeExplode.Playlists.Playlist> Playlists { get; set; }
        public ApplicationContentext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionBuilder optionsBuilder)
    }
}
