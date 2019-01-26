using System.ComponentModel.DataAnnotations;

namespace OpenBlog.Model
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        [Display(Name = "User Post")]
        public string PostBody { get; set; }

        public string ImageUrl { get; set; }

        public string UserId { get; set; }

        public int Likes { get; set; }
    }

    public class PostViewModel
    {

    }
}
