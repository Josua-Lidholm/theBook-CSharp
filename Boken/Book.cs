namespace Boken;

public class Book
{
    // Class properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Pages { get; set; }
    public bool IsLong => Pages > 300; 
    

    // Class methods
    public void Describe()
    {
        if (IsLong == true)
        {
            Console.WriteLine(this.Title + " av " + this.Author + ", " + this.Pages + " sidor (lång bok).");    
        }
        else
        {
            Console.WriteLine(this.Title + " av " + this.Author + ", " + this.Pages + " sidor.");
        }
        
    }

    // Class constructor
    public Book(string bookTitle, string bookAuthor, int bookPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        Pages = bookPages;
    }
}