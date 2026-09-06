namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main(outside the class). What happens, and why?
            // it will give an error because the password field is private and cannot be accessed from outside the class.
            Book b = new Book();
            Console.WriteLine(b.password); 
            #endregion
        }
    }
}
