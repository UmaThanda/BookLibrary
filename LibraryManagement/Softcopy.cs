namespace LibraryManagement
{
    public class Softcopy : Book
    {
        private string version;

        public Softcopy()
        {

        }

        public Softcopy(string name, string author, string genre, string version, string type) : base(name, author, genre, type)
        {
            base.setType("SoftCopy");
            this.version = version;

        }

        public string getVersion()
        {
            return version;
        }

        public void setVersion(string version)
        {
            this.version = version;
        }
    }
}