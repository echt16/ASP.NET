using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.IO;
using lab3.Models;
using Microsoft.Identity.Client;

namespace lab3.Pages
{
    public class IndexModel : PageModel
    {
        private LibraryContext context;
        internal List<Book> Books { get; set; }
        internal List<Author> Authors { get; set; }
        internal List<Style> Styles { get; set; }
        internal List<Publisher> Publishers { get; set; }
        public IndexModel(LibraryContext db)
        {
            context = db;
            Books = context.Books.ToList();
            Authors = context.Authors.ToList();
            Publishers = context.Publishers.ToList();
            Styles = context.Styles.ToList();
        }

        public RedirectToPageResult OnPost(string id)
        {
            CookieOptions co = new CookieOptions();
            co.Expires = DateTimeOffset.UtcNow.AddDays(1);
            Response.Cookies.Append("id", id.ToString(), co);
            return RedirectToPage("/Read");
        }

        public RedirectToPageResult OnPostCreate()
        {
            return RedirectToPage("/Create");
        }
    }
}
