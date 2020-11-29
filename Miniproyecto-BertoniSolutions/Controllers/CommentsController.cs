using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Miniproyecto_BertoniSolutions.Connection;
using Miniproyecto_BertoniSolutions.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Miniproyecto_BertoniSolutions.Controllers
{
    public class CommentsController : Controller
    {
        public CommentsController(IConfiguration configuration)
        {
            services = new Services(configuration);
        }
        readonly Services services;
        public IActionResult Index(int photoId = 0)
        {
            var response = services.GetComments(photoId);
            var ListaComments = new List<Comment>();

            if (response != null)
            {
                ListaComments = JsonConvert.DeserializeObject<List<Comment>>(response);
            }
            return View(ListaComments);
        }
    }
}
