using System;
using System.Collections.Generic;

namespace LibraryManagement
{

    class LibraryMethods //IComparable
    {
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
        public static void FindAllBooks()
        {
            var externalFile = new ExternalFile();
            var books = externalFile.GetData();

            foreach (var book in books)
            {
                Console.WriteLine(book.Name + ":" + book.Author + ":" + book.Genre + ":" + book.Type);
            }
            Console.ReadLine();
        }

        public static void AddBook()
        {
            var externalFile = new ExternalFile();
            var book = new Book();

            Console.WriteLine("Enter Book Name");
            book.Name = Console.ReadLine();

            Console.WriteLine("Enter Author");
            book.Author = Console.ReadLine();

            Console.WriteLine("Enter Genre");
            book.Genre = Console.ReadLine();

            Console.WriteLine("Enter Book Type");
            book.Type = Console.ReadLine();

            externalFile.WriteData(book);

            Console.WriteLine("Book has been Added");
            Console.ReadLine();
        }

    }
}
