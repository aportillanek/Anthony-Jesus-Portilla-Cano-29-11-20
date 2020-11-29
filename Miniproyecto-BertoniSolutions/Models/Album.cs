using System.Collections.Generic;
using System.ComponentModel;

namespace Miniproyecto_BertoniSolutions.Models
{
    public class Album
    {
        public Album()
        {
            Photos = new List<Photo>();
        }
        public int userId { get; set; }
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Titulo")]
        public string title { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
