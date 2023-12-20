using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackAuth_WebAPI.Models
{
    public class Favorite
    {
        [Key]

        public int Id { get; set; }
        public string BookId { get; set; }
        public string TItle { get; set; }
        public string ThumbnailUrl { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
