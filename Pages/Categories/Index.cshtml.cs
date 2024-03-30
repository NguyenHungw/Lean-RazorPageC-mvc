using AbbWeb_MVC.Data;
using AbbWeb_MVC.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbWeb_MVC.Pages.Categories
{
    public class IndexModel : PageModel
    {

        // ?? d? li?u thông qua applicationdbcontext
        private readonly ApplicationDbContext _db;


        public IEnumerable<Category> categories { get; set; }
        public IndexModel(ApplicationDbContext db)
        {
            _db = db;

        }
        public void OnGet()
        {
            categories = _db.Catagories;
        }
    }
}
