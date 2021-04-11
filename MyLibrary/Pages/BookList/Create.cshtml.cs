using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary.Model;

namespace MyLibrary.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _context.Books.Add(Book);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    

    }
}
