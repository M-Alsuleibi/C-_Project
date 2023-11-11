public enum UserType
{
    Admin,
    Member
}

public class User
{
    public UserType UserType { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class LibraryManagementSystem
{
    private User currentUser;

    public bool Login(string username, string password)
    {
        // Here you should check the user credentials from your user database
        // For simplicity, I'm just checking against a single hardcoded user
        if (username == "admin" && password == "password")
        {
            currentUser = new User { UserType = UserType.Admin, Username = username, Password = password };
            return true;
        }
        return false;
    }

    public bool Register(UserType userType, string username, string password)
    {
        // Here you should add the new user to your user database
        // For simplicity, I'm just creating a new User object
        User newUser = new User { UserType = userType, Username = username, Password = password };
        return true;
    }

    public bool Logout()
    {
        if (currentUser != null)
        {
            currentUser = null;
            return true;
        }
        return false;
    }
}