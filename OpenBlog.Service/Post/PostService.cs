using OpenBlog.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenBlog.Service
{
    public interface IPostService
    {
        IEnumerable<PostViewModel> GetAllPost();
        PostViewModel GetPostById(int id);
    }

    public class PostService : IPostService
    {
        private readonly OpenBlogContext _context;
        public PostService(OpenBlogContext context)
        {
            _context = context;
        }

        public IEnumerable<PostViewModel> GetAllPost()
        {
            throw new NotImplementedException();
        }

        public PostViewModel GetPostById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
