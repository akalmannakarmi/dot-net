// There is a book library. Define classes respecrively for a book and a library.
// The library must contain a name and a list of books. The books must contain
// the title, author, publisher, release data and ISBN-number. In the class,
// which describes the library, create methods to add a book to the library,
// to search for a book by a predefined author, to display information about
// a book and to delete fromt the library.
namespace Lab5
{
    public class Q7
    {
        public static void run(string[] args)
        {
            Library library = new Library("City Library");

            Book book1 = createBook();
            Book book2 = createBook();
            Book book3 = createBook();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.Write("Search by Author:");
            var author = Console.ReadLine();
            var authorBooks = library.SearchBooksByAuthor(author);

            Console.WriteLine("\nDisplaying Book Informations");
            foreach (var book in authorBooks)
            {
                book.DisplayBookInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Deleting Frist Book");
            library.DeleteBook(authorBooks.First().ISBN);

            Console.WriteLine("\nDisplaying Book Informations");
            authorBooks = library.SearchBooksByAuthor(author);
            foreach (var book in authorBooks)
            {
                book.DisplayBookInfo();
                Console.WriteLine();
            }
        }
        public static Book createBook()
        {
            Console.WriteLine("Creating Book!");
            Console.Write("Enter Title:");
            var title = Console.ReadLine();

            Console.Write("Enter Author:");
            var author = Console.ReadLine();

            Console.Write("Enter Publisher:");
            var publisher = Console.ReadLine();

            Console.Write("Enter Release Date:");
            var releaseDate = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter ISBN:");
            var isbn = Console.ReadLine();
            return new Book(title, author, publisher, releaseDate, isbn);

        }
    }
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Release Date: {ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
    public class Library
    {
        public string Name { get; set; }
        private List<Book> Books { get; set; }

        public Library(string name)
        {
            Name = name;
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
        }

        public List<Book> SearchBooksByAuthor(string author)
        {
            return Books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public void DisplayBookInfo(string isbn)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                book.DisplayBookInfo();
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbn} not found.");
            }
        }

        public void DeleteBook(string isbn)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn);
            if (book != null)
            {
                Books.Remove(book);
                Console.WriteLine($"Book '{book.Title}' by {book.Author} deleted from the library.");
            }
            else
            {
                Console.WriteLine($"Book with ISBN {isbn} not found.");
            }
        }
    }
}