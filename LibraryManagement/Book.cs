namespace LibraryManagement
{

    public class Book : System.IComparable<Book>
    {
        private string name;
        private string author;
        private string genre;
        private string type;


        public Book()
        {
        }

        public Book(string name, string author, string genre, string type)
        {
            this.name = name;
            this.author = author;
            this.genre = genre;
            this.type = type;
        }


        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getAuthor()
        {
            return author;
        }

        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getGenre()
        {
            return genre;
        }

        public void setGenre(string genre)
        {
            this.genre = genre;
        }
        public string getType()
        {
            return type;
        }

        public void setType(string type)
        {
            this.type = type;
        }

        public int CompareTo(Book other)
        {
            int result = this.name.CompareTo(other.name);
            return result;
        }

    }
}