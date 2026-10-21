namespace Boken;

public class Book
{
    public string title { get; set; }
    public string author { get; set; }
    public int pages { get; set; }

    public void Describe()
    {
        Console.WriteLine(this.title + " av " + this.author + ", " + this.pages + " sidor");
    }

    public Book(string bookTitle, string bookAuthor, int bookPages)
    {
        title = bookTitle;
        author = bookAuthor;
        pages = bookPages;
    }
}