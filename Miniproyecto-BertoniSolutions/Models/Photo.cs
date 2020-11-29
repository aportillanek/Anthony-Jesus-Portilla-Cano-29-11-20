using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Miniproyecto_BertoniSolutions.Models
{
    public class Photo
    {
        public Photo()
        {
            Comments = new List<Comment>();
        }

        public int albumId { get; set; }
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Titulo")]
        public string title { get; set; }
        public string url { get; set; }
        public string thumbnailUrl { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
