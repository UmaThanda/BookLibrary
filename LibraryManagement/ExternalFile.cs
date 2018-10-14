using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryManagement
{
    public class ExternalFile
    {
        public static List<Book> getData()
        {
            List<Book> books = new List<Book>();
            var lines = File.ReadAllLines("BookData.txt");

            foreach (var line in lines)
            {
                var bookArray = line.Split(':');
                if (bookArray[3].Trim().Equals("HardCopy", StringComparison.OrdinalIgnoreCase))
                {
                    Hardcopy hardBook = new Hardcopy();
                    hardBook.setName(bookArray[0].Trim());
                    hardBook.setAuthor(bookArray[1].Trim());
                    hardBook.setGenre(bookArray[2].Trim());
                    hardBook.setType(bookArray[3].Trim());
                    hardBook.setYear(bookArray[4].Trim());
                    books.Add(hardBook);
                }
                else if (bookArray[3].Trim().Equals("SoftCopy", StringComparison.OrdinalIgnoreCase))
                {
                    Softcopy softBook = new Softcopy();
                    softBook.setName(bookArray[0].Trim());
                    softBook.setAuthor(bookArray[1].Trim());
                    softBook.setGenre(bookArray[2].Trim());
                    softBook.setType(bookArray[3].Trim());
                    softBook.setVersion(bookArray[4].Trim());
                    books.Add(softBook);
                }
            }
            books.Sort();
            return books;
        }

        public void writeData(Book book)
        {
            if (book.getType().Equals("HardCopy"))
            {
                Hardcopy b = (Hardcopy)book;
                string bookData = b.getName() + ":" + b.getAuthor() + ":" + b.getGenre() + ":" + b.getType() + ":" + b.getYear();
                File.AppendAllText("BookData.txt", bookData + Environment.NewLine);

            }
            else
            {
                Softcopy b = (Softcopy)book;
                string bookData = b.getName() + ":" + b.getAuthor() + ":" + b.getGenre() + ":" + b.getType() + ":" + b.getVersion();
                File.AppendAllText("BookData.txt", bookData + Environment.NewLine);

            }
        }


        public void writeAllBooks(List<Book> books)
        {
            File.WriteAllText("BookData.txt", String.Empty);
            foreach (var book in books)
                if (book.getType().Equals("HardCopy"))
                {
                    Hardcopy b = (Hardcopy)book;
                    string bookData = b.getName() + ":" + b.getAuthor() + ":" + b.getGenre() + ":" + b.getType() + ":" + b.getYear();
                    File.AppendAllText("BookData.txt", bookData + Environment.NewLine);
                }
                else
                {
                    Softcopy b = (Softcopy)book;
                    string bookData = b.getName() + ":" + b.getAuthor() + ":" + b.getGenre() + ":" + b.getType() + ":" + b.getVersion();
                    File.AppendAllText("BookData.txt", bookData + Environment.NewLine);

                }
        }

    }
}