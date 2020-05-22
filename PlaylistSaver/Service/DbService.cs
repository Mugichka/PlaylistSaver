using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistSaver.Service
{
    public class DbService
    {
        using(AppContext db=new AppContext())
        void AddVideo(string url)
        {
        db.Playlist.Add(url);
        }
    }
}
