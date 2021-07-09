using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary.Model;

namespace MyLibrary.Pages.BookList
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet(int id)
        {
            Book = _context.Books.Find(id);
        }

        public ActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                _context.Update(Book);
                _context.SaveChanges();

                return RedirectToPage("Index");
                
            }
            else
            {
                return Page();
            }
        }
    }
}
