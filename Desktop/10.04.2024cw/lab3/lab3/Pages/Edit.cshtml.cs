using lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace lab3.Pages
{
    public class EditModel : PageModel
    {
        private LibraryContext context;
        internal List<Book> Books { get; set; }
        internal List<Author> Authors { get; set; }
        internal List<Style> Styles { get; set; }
        internal List<Publisher> Publishers { get; set; }

        public int Id { get; set; }

        public EditModel(LibraryContext db)
        {
            context = db;
        }

        public void FillProperties()
        {
            Books = context.Books.ToList();
            Authors = context.Authors.ToList();
            Styles = context.Styles.ToList();
            Publishers = context.Publishers.ToList();
        }

        public async Task<IActionResult> OnPost(string book, string publisher, string author, string style, string year)
        {
            Id = int.Parse(Request.Cookies["id"]);
            FillProperties();
            context.Books.FirstOrDefault(x => x.Id == Id).Name = book;
            context.Books.FirstOrDefault(x => x.Id == Id).Year = int.Parse(year);
            context.Books.FirstOrDefault(x => x.Id == Id).PublisherId = context.Publishers.First(x => x.Name == publisher).Id;
            context.Books.FirstOrDefault(x => x.Id == Id).AuthorId = context.Authors.First(x => x.Name == author).Id;
            context.Books.FirstOrDefault(x => x.Id == Id).StyleId = context.Styles.First(x => x.Name == style).Id;
            await context.SaveChangesAsync();
            return RedirectToPage("/Read");
        }
    }
}
