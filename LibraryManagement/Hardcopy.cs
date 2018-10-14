namespace LibraryManagement
{
   public class Hardcopy : Book
    {
        private string year;

        public Hardcopy()
        {

        }

        public Hardcopy(string name, string author, string genre, string year, string type) : base(name, author, genre, type)
        {
            base.setType("HardCopy");
            this.year = year;

        }


        public string getYear()
        {
            return year;
        }

        public void setYear(string year)
        {
            this.year = year;
        }


    }
}
