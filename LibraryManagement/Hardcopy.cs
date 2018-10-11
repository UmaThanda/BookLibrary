namespace LibraryManagement
{
    public class HardCopy : Book
    {
        public int Year { get; set; }

        public HardCopy()
        {
            Type = "HardCopy";
        }
    }
}