using System.Numerics;

namespace thirdtask
{
    public class Book
    {
        public string title;
        public string author;
        public string isbn;
        public bool isAvailable;

        public Book(string title, string author, string isbn, bool isAvailable = true)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.isAvailable = isAvailable;
        }
    }
    public class Library
    {
        List<Book> books = new List<Book>();

        public string DisplayBooks()
        {
            string result = "";
            for (int i = 0; i < books.Count; i++)
            {
            result += $"Title: {books[i].title}, Author: {books[i].author}, ISBN: {books[i].isbn}, Available: {books[i].isAvailable}\n";
            }
            return result;
        }
        public string AddBook(Book book)
        {
            books.Add(book);
            return "done";
        }
        public string SearchBook(string author)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].author == author)
                    return "is available";         
            }
            return "is not available";

        }
        public void BorrowBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title && books[i].isAvailable)
                    books[i].isAvailable = false;
            }
            
        }
        public string ReturnBook(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == title && !books[i].isAvailable)
                    books[i].isAvailable = true;
            }
            return "done";

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book( "al-ayam",  "taha husine", "1234567890");
            Book book2 = new Book(" alfetna-alkobra", "taha husine", "1234567891");
            Book book3 = new Book("alwaad-alhaq", "taha husine", "1234567892");
            Book book4 = new Book(" awdate-alrooh", "tawfeeq al-hakeem", "1234567893");
            Book book5 = new Book("shahrazade", "tawfeeq al-hakeem", "1234567894");
            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            Console.WriteLine(library.SearchBook("taha husine"));
            Console.WriteLine( library.DisplayBooks());
            library.BorrowBook("al-ayam");
            Console.WriteLine( library.DisplayBooks());
            Console.WriteLine( library.SearchBook("al-ayam"));
            library.AddBook(new("al-tareeq ela allah","ameer moneer","1234567895"));
            Console.WriteLine( library.ReturnBook("al-ayam"));
            Console.WriteLine( library.DisplayBooks());
            


        }
    }
}
