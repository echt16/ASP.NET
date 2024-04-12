namespace lab3.Models
{
    public class Style
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
        public Style()
        {
            Books = new List<Book>();
        }
    }
}
