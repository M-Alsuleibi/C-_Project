
using System;
using System.Collections.Generic;

class LibraryDatabase
{
    private List<Book> List_of_books = new List<Book>();

    public void AddBook(Book book)
    {
        List_of_books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void DeleteBook(string title)
    {
        Book book = SearchBook(title);
        if (book != null)
        {
            List_of_books.Remove(book);
            Console.WriteLine("Book deleted successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void UpdateBook(string title, Book updatedBook)
    {
        Book book = SearchBook(title);
        if (book != null)
        {
            int index = List_of_books.IndexOf(book);
            List_of_books[index] = updatedBook;
            Console.WriteLine("Book updated successfully!");
        }
        else
        {
            Console.WriteLine("Book not found!");
        }
    }

    public void DisplayBooks()
    {
        if (List_of_books.Count == 0)
        {
            Console.WriteLine("No books in the library!");
        }
        else
        {
            Console.WriteLine("List of books:");
            foreach (Book book in List_of_books)
            {
                Console.WriteLine(book.ToString());
            }
        }
    }

    public Book SearchBook(string title)
    {
        foreach (Book book in List_of_books)
        {
            if (book.Title == title)
            {
                return book;
            }
        }
        return null;
    }
}

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Title} by {Author}, published in {Year}";
    }
}
