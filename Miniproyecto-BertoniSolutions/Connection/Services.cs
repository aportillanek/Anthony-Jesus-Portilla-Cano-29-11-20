using Microsoft.Extensions.Configuration;
using System.Net;

namespace Miniproyecto_BertoniSolutions.Connection
{
    public class Services
    {
        protected readonly  IConfiguration _configuration;
        protected string urlBaseAddress;
        public Services( IConfiguration configuration)
        {
            _configuration = configuration;
            urlBaseAddress = _configuration["urlServices"];
        }
        public  string GetAlbums()
        {
            var url = urlBaseAddress+"/albums";

            return Get(url);
        }

        public  string GetPhotos(int AlbumId = 0)
        {
            var url = urlBaseAddress +"/photos";

            if (AlbumId != 0)
            {
                url = url + "?albumId=" + AlbumId.ToString();
            }

            return Get(url);
        }

        public  string GetComments(int PostId = 0)
        {
            var url = urlBaseAddress+ "/comments";

            if (PostId != 0)
            {
                url = url + "?postId=" + PostId.ToString();
            }

            return Get(url);
        }

        private static string Get(string url)
        {
            WebClient webClient = new WebClient();
            webClient.Headers.Add("Content-Type", "application/json");
            webClient.Encoding = System.Text.Encoding.UTF8;

            string data = webClient.DownloadString(url);
            return data;
        }
    }
}
