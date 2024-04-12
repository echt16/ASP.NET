namespace lab3.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StyleId { get; set; }
        public Style Style { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public int Year {  get; set; }
    }
}
