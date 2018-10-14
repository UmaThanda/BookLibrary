using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{

    class LibraryMethods
    {
        List<Book> book = new List<Book>();
        Book b = new Book();

        public static void findByName()
        {
            List<Book> books = ExternalFile.getData();
            Console.WriteLine("enter keyword");
            string keyword = Console.ReadLine();

            foreach (Book book in books)
            {

                if (book.getName().Equals(keyword))
                {
                    Console.WriteLine(book.getName() + ":" + book.getAuthor() + ":" + book.getGenre() + ":" + book.getType());
                    break;
                }


                else
                {
                    Console.WriteLine("Sorry.. Try a different keyword");
                    break;
                }
            }
        }

        public static void findByAuthor()
        {
            Console.WriteLine("enter author name");
            string keyword = Console.ReadLine();
            List<Book> books = ExternalFile.getData();
            foreach (Book book in books)
            {
                if (book.getAuthor() == keyword)
                {
                    Console.WriteLine("Books written by " + book.getAuthor() + " " + book.getName() + ":" + book.getAuthor() + ":" + book.getGenre() + ":" + book.getType());
                    break;
                }

                }
                
                


                else

                {
                    Console.WriteLine("Sorry.. Look for another author");
                    break;
                }
            }
        }



        public static void findByGenre()
        {
            Console.WriteLine("enter Genre");
            string keyword = Console.ReadLine();
            List<Book> books = ExternalFile.getData();

            foreach (Book book in books)
            {
                if (book.getGenre().Equals(keyword))
                {
                    Console.WriteLine(book.getName() + book.getAuthor() + book.getGenre() + book.getType());
                    break;
                }

                else
                {
                    Console.WriteLine("Sorry.. Look for a different Genre");
                    break;
                }
            }
        }

        public static void findByType()
        {
            Console.WriteLine("Enter Type -  HardCopy or SoftCopy ? ");
            string keyword = Console.ReadLine().ToLower();
            List<Book> books = ExternalFile.getData();
            if (string.Equals(keyword, "hardcopy", StringComparison.OrdinalIgnoreCase) ||
                (string.Equals(keyword, "softcopy", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Here is the list for type - " + keyword);

                foreach (Book book in books)
                {
                    if (string.Equals(keyword, book.getType(), StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(book.getName() + ": " + book.getType());
                        //break;
                    }
                }

            }
            else
            {
                Console.WriteLine("The type you are looking for is unavailable");
                //break;

            }
        }



        public static void findAllBooks()
        {
            var externalFile = new ExternalFile();
            List<Book> books = ExternalFile.getData();

            for (int i = 0; i < books.Count; i++)
            {
                if(books[i].GetType().ToString().Equals("LibraryManagement.Hardcopy", StringComparison.OrdinalIgnoreCase))
                {
                    var hardcopy = (Hardcopy)books[i];
                    Console.WriteLine(i + 1 + "). " + books[i].getName() + ":" + books[i].getAuthor() + ":" + books[i].getGenre() + ":" + books[i].getType() + ":" + hardcopy.getYear());
                }
                else
                {
                    var softcopy = (Softcopy)books[i];
                    Console.WriteLine(i + 1 + "). " + books[i].getName() + ":" + books[i].getAuthor() + ":" + books[i].getGenre() + ":" + books[i].getType() + ":" + softcopy.getVersion());
                }
            }
            Console.ReadLine();
        }

        public static void addBook()
        {
            var externalFile = new ExternalFile();

            Console.WriteLine("Enter Book Type - hardcopy or softcopy");
            string givenType = Console.ReadLine();
            //if (givenType.Equals("HardCopy"))
            if (string.Equals(givenType, "hardcopy", StringComparison.OrdinalIgnoreCase))

            {
                Console.WriteLine("Enter Book Name");
                string givenName = Console.ReadLine();

                Console.WriteLine("Enter Author");
                string givenAuthor = Console.ReadLine();

                Console.WriteLine("Enter Genre");
                string givenGenre = Console.ReadLine();

                Console.WriteLine("Enter Year");
                var givenYear = Console.ReadLine();

                Hardcopy book = new Hardcopy(givenName, givenAuthor, givenGenre, givenYear, givenType);
                externalFile.writeData(book);



            }
            // else if (givenType.Equals("SoftCopy"))
            else if (string.Equals(givenType, "softcopy", StringComparison.OrdinalIgnoreCase))
            {

                Console.WriteLine("Enter Book Name");
                string givenName = Console.ReadLine();

                Console.WriteLine("Enter Author");
                string givenAuthor = Console.ReadLine();

                Console.WriteLine("Enter Genre");
                string givenGenre = Console.ReadLine();

                Console.WriteLine("Enter Version");
                var givenVersion = Console.ReadLine();

                Softcopy book = new Softcopy(givenName, givenAuthor, givenGenre, givenVersion, givenType);


                externalFile.writeData(book);
            }



            Console.WriteLine("Book has been Added");
            Console.ReadLine();
        }

        public static void editBook()
        {
            var externalFile = new ExternalFile();
            List<Book> books = ExternalFile.getData();

            findAllBooks();
            Console.WriteLine("Please enter a book number");
            var bookNum = Convert.ToInt32(Console.ReadLine());
            var bookNum = InputCheck.CheckInteger("Please enter a book number : ", books.Count);

            Console.WriteLine("Details of the book you choose");
            Console.WriteLine(books[bookNum - 1].getName() + ":" + books[bookNum - 1].getAuthor() + ":" + books[bookNum - 1].getGenre() + ":" + books[bookNum - 1].getType());

            Console.WriteLine("Enter new Book Author");
            string editAuthor = Console.ReadLine();
            books[bookNum - 1].setAuthor(editAuthor);

            externalFile.writeAllBooks(books);
        }

        public static void deleteBook()
        {
            var externalFile = new ExternalFile();
            List<Book> books = ExternalFile.getData();

            findAllBooks();
            Console.WriteLine("Please enter a book number");
            var bookNum = Convert.ToInt32(Console.ReadLine());
            books.RemoveAt(bookNum - 1);
          
            Console.WriteLine("Details of the book you choose");
            Console.WriteLine(books[bookNum - 1].getName() + ":" + books[bookNum - 1].getAuthor() + ":" + books[bookNum - 1].getGenre() + ":" + books[bookNum - 1].getType());

            externalFile.writeAllBooks(books);
        }
    }
}