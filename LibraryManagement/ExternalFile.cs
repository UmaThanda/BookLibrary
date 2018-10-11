using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class ExternalFile

    {
        public static string file = @"C:\Users\User\Desktop\BookFile.txt";


        public static List<Book> readFromFile()
        {
            string []content = null; 
            StreamReader reader = new StreamReader(file);
            List<Book> books = new List<Book>();

            while (reader.EndOfStream == false)
            {
                char[] delimiter = new char[] { '\t' };
                content = reader.ReadLine().Split(delimiter);
                Console.WriteLine(content);
                Book b = new Book();

                
                if (content[3].Trim().Equals("HardCopy"))
                {
                    Console.WriteLine("found a hard one");
                    Hardcopy bH = new Hardcopy();
                    bH.setName(content[0].Trim());
                    bH.setAuthor(content[1].Trim());
                    bH.setGenre(content[2].Trim());
                    bH.setType(content[3].Trim());
                    bH.setYear(Convert.ToInt32(content[4].Trim()));
                    b = bH;
                    books.Add(bH);

                    
                }
                else if (content[3].Equals("SoftCopy"))
                {
                    Console.WriteLine("found a soft one");

                    Softcopy bS = new Softcopy();
                    bS.setName(content[0].Trim());
                    bS.setAuthor(content[1].Trim());
                    bS.setGenre(content[2].Trim());
                    bS.setType(content[3].Trim());
                    bS.setVersion(Convert.ToInt32(content[4].Trim()));
                    b = bS;
                    books.Add(bS);

                    
                }
            }
            reader.Close();
            return books;

        }

        public static void writeFile(string book)
        {
            StreamReader reader = new StreamReader(file);
            StreamWriter writer = new StreamWriter(file);
            // check for append
            while (!reader.EndOfStream)
            {
                writer.WriteLine(book);
            }
        }
        

    }
}
