using System.Drawing;

namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?
            // it will give an error because the password field is private and cannot be accessed from outside the class.
            Book b = new Book();
            //Console.WriteLine(b.password);
            #endregion

            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile?Why?
            // it will compile because the copiesInStock field is internal and can be accessed from within the same class.
            Console.WriteLine(b.copiesInStock);
            #endregion

            #region Add a public string Title; field to Book. Set it and print it from Main.
            Book book = new Book();
            book.Title = "Database Systems";
            Console.WriteLine(book.Title);
            #endregion

            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book,assign it Genre.Science, and print it.
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion

            #region Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            int x = (int)Genre.Fiction;
            int y = (int)Genre.NonFiction;
            int z = (int)Genre.Science;
            Console.WriteLine($"Fiction: {x}, NonFiction: {y}, Science: {z}");
            #endregion

            #region Given int genreNumber = 1;, cast it into a Genre value and print the result.
            int genreNumber = 1;

            Genre genre;
            if (Enum.IsDefined(typeof(Genre), genreNumber)){
                genre = (Genre)genreNumber;
                Console.WriteLine($"Genre: {genre}");
            }
            else
            {
                Console.WriteLine("Invalid genre number.");
            }
            #endregion

            #region Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.
            Genre genre1 = Genre.Fiction;
            string s = genre1.ToString();
            Console.WriteLine($"Genre: {s}");
            #endregion

            #region Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() andprint the result.
            string genreText = "Science";
            Genre genre2;
            genre2 = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine(genre2); 
            #endregion
        }
    }
}
