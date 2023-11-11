
public class Account
{
    public int no_borrowed_books { get; set; }
    public int no_reserved_books { get; set; }
    public int no_returned_books { get; set; }
    public int no_lost_books { get; set; }
    public decimal fine_amount { get; set; }

    public decimal Calculate_fine()
    {
        decimal fine = 0;

        // Calculate fine based on number of overdue books
        int overdue_books = no_borrowed_books - no_returned_books - no_lost_books;
        if (overdue_books > 0)
        {
            fine = overdue_books * 0.25m; // $0.25 per day overdue
        }

        // Add additional fine for lost books
        if (no_lost_books > 0)
        {
            fine += no_lost_books * 5.00m; // $5.00 per lost book
        }

        return fine_amount = fine;
    }
}
