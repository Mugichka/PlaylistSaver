using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PlaylistSaver.Models;

namespace PlaylistSaver.Data
{
    public class PlaylistSaverContext : ApiAuthorizationDbContext<SaverUser>
    {
        public PlaylistSaverContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<YoutubeExplode.Playlists.Playlist> Playlist { get; set; }
        public DbSet<YoutubeExplode.Videos.Video> Video { get; set; }
        public DbSet<YoutubeExplode.Channels.Channel> Channel { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected 

    }
}
