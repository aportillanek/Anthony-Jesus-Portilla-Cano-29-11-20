using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Miniproyecto_BertoniSolutions.Connection;
using Miniproyecto_BertoniSolutions.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace Miniproyecto_BertoniSolutions.Controllers
{
    public class AlbumsController : Controller
    {
        public AlbumsController(IConfiguration configuration)
        {
            services = new Services(configuration);
        }
        readonly Services services;
        public IActionResult Index()
        {
            var response = services.GetAlbums();
            var listaAlbums = new List<Album>();

            if (response != null)
            {
                listaAlbums = JsonConvert.DeserializeObject<List<Album>>(response);
            }

            return View(listaAlbums);
        }
    }
}
