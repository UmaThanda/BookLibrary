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
                try
                {
                    if (book.getName().Equals(keyword))
                    {
                        Console.WriteLine(book.getName() + ":" + book.getAuthor() + ":" + book.getGenre() + ":" + book.getType());
                        break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry.. Try a different keyword");
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
                try
                {
                    if (book.getAuthor() == keyword)
                    {
                        Console.WriteLine("Books written by " + book.getAuthor() + " " + book.getName() + ":" + book.getAuthor() + ":" + book.getGenre() + ":" + book.getType());

                    }
                }
                /*t
                 
                catch
                {
                    Console.WriteLine("Sorry.. Look for another author");
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
                try
                {
                    if (book.getGenre().Equals(keyword))
                    {
                        Console.WriteLine(book.getName() + book.getAuthor() + book.getGenre() + book.getType());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Sorry.. Look for a different Genre");
                }

            }
        }

        public static void findByType()
        {
            Console.WriteLine("Enter Type -  HardCopy or SoftCopy ? ");
            string keyword = Console.ReadLine().ToLower();
            List<Book> books = ExternalFile.getData();
            Console.WriteLine("here is the list");

            foreach (Book book in books)
            {
                try
                {
                    if (book.getType() == keyword)
                    {
                        Console.WriteLine(book.getName() + book.getAuthor() + book.getGenre() + book.getType());
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("The type you are looking for is unavailable currently");

                }
            }
        }


        public static void findAllBooks()
        {
            var externalFile = new ExternalFile();
            List<Book> books = ExternalFile.getData();

            for (int i = 0; i < books.Count; i++)
            {

                Console.WriteLine(i + 1 + ")." + books[i].getName() + ":" + books[i].getAuthor() + ":" + books[i].getGenre() + ":" + books[i].getType());
            }
            Console.ReadLine();
        }



        public static void addBook()
        {


            var externalFile = new ExternalFile();

            Console.WriteLine("Enter Book Type");
            string givenType = Console.ReadLine();
            if (givenType.Equals("HardCopy"))
            {
                Console.WriteLine("Enter Book Name");
                string givenName = Console.ReadLine();

                Console.WriteLine("Enter Author");
                string givenAuthor = Console.ReadLine();

                Console.WriteLine("Enter Genre");
                string givenGenre = Console.ReadLine();

                Console.WriteLine("Enter Year");
                var givenYear = Convert.ToInt32(Console.ReadLine());

                Hardcopy book = new Hardcopy(givenName, givenAuthor, givenGenre, givenYear, givenType);
                externalFile.writeData(book);



            }
            else if (givenType.Equals("SoftCopy"))
            {

                Console.WriteLine("Enter Book Name");
                string givenName = Console.ReadLine();

                Console.WriteLine("Enter Author");
                string givenAuthor = Console.ReadLine();

                Console.WriteLine("Enter Genre");
                string givenGenre = Console.ReadLine();

                Console.WriteLine("Enter Version");
                var givenVersion = Convert.ToInt32(Console.ReadLine());

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
            Console.WriteLine("Details of the book you chose");
            Console.WriteLine(books[bookNum - 1].getName() + ":" + books[bookNum - 1].getAuthor() + ":" + books[bookNum - 1].getGenre() + ":" + books[bookNum - 1].getType());

            Console.WriteLine("Enter new Book Author");
            string editAuthor = Console.ReadLine();
            books[bookNum - 1].setAuthor(editAuthor);

            externalFile.writeAllBooks(books);
        }

    }
}

   

    

