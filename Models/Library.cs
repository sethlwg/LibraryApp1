public class Library
{
    public string Name {get; set;}

    public string Location {get; set;}

    private string Librarian {get; set;}

    private class Section// how library is organized
{
    public int Id {get; set;}

    public string Location {get; set;}
}

}


