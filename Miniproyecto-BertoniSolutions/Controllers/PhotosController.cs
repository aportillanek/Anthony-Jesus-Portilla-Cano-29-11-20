using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Miniproyecto_BertoniSolutions.Connection;
using Miniproyecto_BertoniSolutions.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Miniproyecto_BertoniSolutions.Controllers
{
    public class PhotosController : Controller
    {
        public PhotosController(IConfiguration configuration)
        {
            services = new Services(configuration);
        }
        readonly Services services;
        public IActionResult Index(int albumId = 0)
        {
            var response = services.GetPhotos(albumId);
            var listaPhotos = new List<Photo>();

            if (response != null)
            {
                listaPhotos = JsonConvert.DeserializeObject<List<Photo>>(response);
            }

            return View(listaPhotos);
        }
        [HttpPost]
        public IActionResult CargarComments(int photoId = 0)
        {
            var response = services.GetComments(photoId);
            var listaComments = new List<Comment>();

            if (response != null)
            {
                listaComments = JsonConvert.DeserializeObject<List<Comment>>(response);
            }

            return PartialView("PartialPhotos", listaComments);
        }
    }
}
