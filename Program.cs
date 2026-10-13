using BooksLibrary;
using BooksLibrary.Schemes;

try
{
    Books books = new Books();

    // 1) read all books from XML file
    string xmlFilePath = "books.xml";
    books.ReadBooks(xmlFilePath);

    // 2) add a book to the list
    books.AddBook(new BookScheme
    {
        Title = "Harry Potter and the Philosopher's Stone",
        Author = "J. K. Rowling",
        NumberOfPages = 5400
    });

    // 3) sort
    books.SortBooks();

    // 4) search
    var foundBooks = books.SearchBookByPartOfTitle("Potter");

    // 5) write new books data into XML file
    books.WriteBooks(xmlFilePath);
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}