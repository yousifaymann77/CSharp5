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

        }
    }
}
