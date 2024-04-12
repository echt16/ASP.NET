using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace lab3.Pages
{
    public class ReadModel : PageModel
    {
        private LibraryContext context;
        internal Book Book { get; set; }
        internal Author Author { get; set; }
        internal Style Style { get; set; }
        internal Publisher Publisher { get; set; }

        public int Id { get; set; }

        public ReadModel(LibraryContext db)
        {
            context = db;
        }

        public void FillProperties()
        {
            Book = context.Books.First(x => x.Id == Id);
            Author = context.Authors.First(x => x.Id == Book.AuthorId);
            Style = context.Styles.First(x => x.Id == Book.StyleId);
            Publisher = context.Publishers.First(x => x.Id == Book.PublisherId);
        }

        public async Task<IActionResult> OnPostDelete()
        {
            Id = int.Parse(Request.Cookies["id"]);
            var book = context.Books.FirstOrDefault(x => x.Id == Id);

            if (book != null)
            {
                context.Books.Remove(book);
                await context.SaveChangesAsync();
            }

            return RedirectToPage("/Index");
        }

        public RedirectToPageResult OnPostEdit()
        {
            Id = int.Parse(Request.Cookies["id"]);
            Response.Cookies.Append("id", Id.ToString(), new CookieOptions()
            {
                 Expires = DateTimeOffset.UtcNow.AddDays(1)
            });
            return RedirectToPage("/Edit");
        }
    }
}
