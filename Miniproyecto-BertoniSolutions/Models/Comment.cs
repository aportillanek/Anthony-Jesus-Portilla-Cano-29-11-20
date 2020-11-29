using System.ComponentModel;

namespace Miniproyecto_BertoniSolutions.Models
{
    public class Comment
    {
        public int postId { get; set; }
        [DisplayName("Id")]
        public int id { get; set; }
        [DisplayName("Nombre")]
        public string name { get; set; }
        [DisplayName("Correo")]
        public string email { get; set; }
        [DisplayName("Cuerpo")]
        public string body { get; set; }
    }
}
