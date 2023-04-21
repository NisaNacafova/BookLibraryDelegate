using Practice.Models;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("Suc ve Ceza", "Fyudor Dostyevski", 245, 500);
        Book book2 = new Book("Alice in Wonderland", "Lewis Carrol", 450, 200);
        Book book3=new Book("Arms and the Man", "Shaw", 230, 150);
        Book book4 = new Book("Bilincaltinin gucu", "Joseph Murphy", 350, 530);
        Library library = new Library();
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);
        Console.WriteLine(library.GetBook(x => x.Price > 300).Name);
        library.FindAllBooks(x => x.Id > 2).ForEach(x => Console.WriteLine($"Id; {x.Id}, Name; {x.Name}, Author; {x.AuthorName}, Pagecount; {x.Price}, Price; {x.Price}"));

        Console.WriteLine($"Silinen kitab sayi => {library.RemoveBook(x => x.Id <= 2)}");



    }
}