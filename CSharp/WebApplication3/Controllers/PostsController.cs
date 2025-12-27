using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PostsController : Controller
    {
        private static List<Post> posts = new List<Post>();

        public IActionResult Index()
        {
            return View(posts);
        }

        public IActionResult Details(int id)
        {
            var post = posts.FirstOrDefault(p => p.id == id);
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            post.id = posts.Count + 1;
            posts.Add(post);
            return RedirectToAction("Index");
        }
    }
}
