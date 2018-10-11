using System;

namespace LibraryManagement
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Welcome to our Library");

            string role = InputCheck.checkRole("User/Admin(u/a)?: ");

            switch (role)
            {
                case "u":

                    user();
                    break;

                case "a":

                    admin();
                    break;
            }


        }

        public static void user()
        {
            userMenu();
            int input = InputCheck.CheckInteger("Please select a number", 6);
            switch (input)
            {
                case 1:
                    //    LibraryMethods.findByName();
                    break;
                case 2:
                    //    LibraryMethods.findByAuthor();
                    break;
                case 3:
                    //    LibraryMethods.findByGenre();
                    break;
                case 4:
                    //   LibraryMethods.findByType();
                    break;
                case 5:
                    LibraryMethods.FindAllBooks();
                    break;
                default:
                    return;
            }
            user();
        }

        public static void admin()
        {
            adminMenu();
            int input = InputCheck.CheckInteger("Please select a number", 9);
            switch (input)
            {
                case 1:
                    // LibraryMethods.findByName();
                    break;
                case 2:
                    // LibraryMethods.findByAuthor();
                    break;
                case 3:
                    //LibraryMethods.findByGenre();
                    break;
                case 4:
                    // LibraryMethods.findByType();
                    break;
                case 5:
                    LibraryMethods.FindAllBooks();
                    break;
                case 6:
                    // LibraryMethods.editBook();
                    break;
                case 7:
                    LibraryMethods.AddBook();
                    break;
                case 8:
                    // LibraryMethods.deleteBook();
                    break;
                default:
                    return;
            }
            admin();
        }




        public static void userMenu()
        {
            Console.WriteLine("1.  Find book by keyword");
            Console.WriteLine("2.  Find book by author");
            Console.WriteLine("3.  Find book by genre");
            Console.WriteLine("4.  Find book by type");
            Console.WriteLine("5.  List all books (A-Z)");
            Console.WriteLine("6.  Quit");

        }


        public static void adminMenu()
        {
            Console.WriteLine("1.  Find book by keyword");
            Console.WriteLine("2.  Find book by author");
            Console.WriteLine("3.  Find book by genre");
            Console.WriteLine("4.  Find book by type");
            Console.WriteLine("5.  List all books (A-Z)");
            Console.WriteLine("6.  Edit book");
            Console.WriteLine("7.  Add book");
            Console.WriteLine("8.  Delete book");
            Console.WriteLine("9.  Quit");
        }












    }
}
