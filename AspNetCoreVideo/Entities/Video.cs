using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
       public Genres Genre { get; set; }
    }
}
