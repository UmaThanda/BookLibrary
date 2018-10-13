namespace LibraryManagement
{
    public class Softcopy : Book
    {
        private int version;

        public Softcopy()
        {

        }

        public Softcopy(string name, string author, string genre, int version, string type) : base(name, author, genre, type)
        {
            base.setType("SoftCopy");
            this.version = version;

        }

        public int getVersion()
        {
            return version;
        }

        public void setVersion(int version)
        {
            this.version = version;
        }
    }
}