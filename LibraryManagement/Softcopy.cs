namespace LibraryManagement
{
    public class SoftCopy : Book
    {
        public int Version { get; set; }

        public SoftCopy()
        {
            Type = "SoftCopy";
        }
    }
}
