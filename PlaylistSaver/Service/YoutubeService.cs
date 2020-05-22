using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YoutubeExplode;

namespace PlaylistSaver.Data
{
    public class YoutubeService
    {
       public readonly YoutubeClient youtube = new YoutubeClient();
        public bool ChekUrl(string url)
        {
            Uri uriResult;
            return  Uri.TryCreate(url, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }
    }
}
