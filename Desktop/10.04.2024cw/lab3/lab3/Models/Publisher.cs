namespace lab3.Models
{
    public class Publisher
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public virtual List<Book> Books { get; set; }
        public Publisher()
        {
            Books = new List<Book>();
        }
    }
}
