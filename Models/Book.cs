public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }
    public string CopyrightInfo { get; set; }
    protected Category Category {get; set; }


    public Book () {
        Title = string.Empty;
        Id = 0;
        Author = string.Empty;
        Year = 0;
        CopyrightInfo = string.Empty;
    }
}

