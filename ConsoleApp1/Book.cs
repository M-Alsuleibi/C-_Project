
using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }

    public DateTime DueDate { get; set; }
    public bool IsReserved { get; set; }
    public string Feedback { get; set; }

    public void RequestBook()
    {
        Console.WriteLine($"Requesting book: {Title} by {Author}");
    }

    public void RenewBook()
    {
        Console.WriteLine($"Renewing book: {Title} by {Author}");
    }

    public void ShowDueDate()
    {
        Console.WriteLine($"Due date for {Title} by {Author}: {DueDate}");
    }

    public void ShowReservationStatus()
    {
        Console.WriteLine($"Reservation status for {Title} by {Author}: {(IsReserved ? "Reserved" : "Not reserved")}");
    }

    public void LeaveFeedback(string feedback)
    {
        Feedback = feedback;
        Console.WriteLine($"Feedback for {Title} by {Author}: {Feedback}");
    }
}
