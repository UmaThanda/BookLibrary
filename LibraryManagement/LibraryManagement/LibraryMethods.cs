using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement { 

    class LibraryMethods //IComparable

    {
        List<Book> book = new List<Book> { };
        Book b = new Book();




        /*public static void findByName()
        {
            Console.WriteLine("enter keyword");
            string keyword = Console.ReadLine();

            }


        }

        public static void findByAuthor()
        {

        }

        public static void findByGenre()
        {

        }

        public static void findByType()
        {

        }
        public static void exitProgram()
        {

        }
        public static void editBook()
        {

        }
     
        public static void deleteBook()
        {

        }

  
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

    */
        public static void findAllBooks()
        {
        List<Book> books = new List<Book>();
        books = ExternalFile.readFromFile();
            Console.WriteLine(books);
        foreach(Book b in books)
        {
            Console.WriteLine(b.getAuthor());
        }
        }

        public static string addBook()
        {
            int year = 0;
            Console.WriteLine("Enter Book Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Author");
            string author = Console.ReadLine();
            Console.WriteLine("Enter Genre");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter Book Type");
            string type = Console.ReadLine();
            if (type.Equals("HardCopy"))
            {
                Console.WriteLine("Enter Year");
                year = Convert.ToInt32(Console.ReadLine());
            }else if(type.Equals("SoftCopy"))
            {
                Console.WriteLine("Enter Version");
                year = Convert.ToInt32(Console.ReadLine());
            }
            return name + "\t" + author + "\t" + genre + "\t" + type + "\t" + year;

        }

    }
}
