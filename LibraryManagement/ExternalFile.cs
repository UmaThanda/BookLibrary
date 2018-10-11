using System;
using System.Collections.Generic;
using System.IO;

namespace LibraryManagement
{
    public class ExternalFile
    {
        public List<Book> GetData()
        {
            var books = new List<Book>();

            var lines = File.ReadAllLines("BookData.txt");
            foreach (var line in lines)
            {
                var bookArray = line.Split(':');
                books.Add(new Book
                {
                    Name = bookArray[0],
                    Author = bookArray[1],
                    Genre = bookArray[2],
                    Type = bookArray[3]
                });
            }
            return books;
        }

        public void WriteData(Book book)
        {
            string bookData = book.Name + ":" + book.Author + ":" + book.Genre + ":" + book.Type;
            File.AppendAllText("BookData.txt", bookData + Environment.NewLine);
        }
    }
}