﻿namespace lab3.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public virtual List<Book> Books { get; set; }
        public Author()
        {
            Books = new List<Book>();
        }
    }
}
