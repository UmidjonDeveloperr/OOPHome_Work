using OOPHOMEWORK.Classes;

System.Console.WriteLine("Enter a book's name: ");
string BookName=Console.ReadLine();
System.Console.WriteLine("Enter a book's Autor: ");
string BookAutor=Console.ReadLine();
System.Console.WriteLine("Enter a book's price: ");
int BookPrice=Convert.ToInt32(Console.ReadLine());

Book book=new Book(BookName, BookPrice);
System.Console.WriteLine(book.Autor);
System.Console.WriteLine(book.Price);

System.Console.WriteLine("Enter a count of books: ");
int count = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(book.ValueOfBooks(count, BookPrice));