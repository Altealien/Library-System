using LibrarySystem.Core;


class Program
{
    static void Main()
    {
        Book book = new() { Title = "Things Fall Apart", Author = "Chinua Achebe", ISBN = "978-0-435-90553-6" };
        Console.WriteLine(book.Title);

        Member member = new() { Id = 1234890, Name = "Odell Hansel" };
        Console.WriteLine($"{member.Name} : {member.Id}");

        Loan loan = new() { LoanedBook = book, LoanedBy = member, LoanedDate = DateTime.Now };
        Console.WriteLine($"{loan.LoanedBy.Name} borrowed {loan.LoanedBook.Title} on {loan.LoanedDate:d}");
    }
}