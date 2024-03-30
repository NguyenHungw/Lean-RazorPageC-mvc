using AbbWeb_MVC.Data;
using AbbWeb_MVC.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbWeb_MVC.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {

        }
        //kieu tra ve
        public async Task<IActionResult> OnPost(Category category) 
        {
            if (category.Name == category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("", "Name Must not same displayorder ");
            }
            if(ModelState.IsValid)
            {
                await _db.Catagories.AddAsync(category);
                await _db.SaveChangesAsync();
                return RedirectToPage("index");
            }
        return Page();
        }
    }
}
