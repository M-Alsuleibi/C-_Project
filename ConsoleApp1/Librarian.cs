
public class Librarian
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Password { get; set; }

    public bool VerifyLibrarian(int id, string password)
    {
        return id == Id && password == Password;
    }

    public List<Book> Search(string searchString)
    {
        // implementation of book search logic
    }
}
