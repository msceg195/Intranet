using Intranet.Models;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Intranet.Controllers
{
    public class HomeController : Controller
    {
        private static readonly DbModel dbModel = new DbModel();
        public async Task<ActionResult> Index()
        {
            List<Post> posts = await dbModel.Post.ToListAsync();
            return View(posts);
        }

        public async Task<ActionResult> Details(int? id)
        {
            return View(await dbModel.Post.FindAsync(id));
        }

        public async Task<ActionResult> Page(int? id)
        {
            return View(await dbModel.Post.Where(q => q.PageId == id).ToListAsync());
        }
    }
}