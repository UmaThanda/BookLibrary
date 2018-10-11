using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Hardcopy:Book
    {
        private int year;

        public Hardcopy()
        {

        }

        public Hardcopy(string name, string author, string genre, int year, string  type) : base(name, author, genre, type)
        {
            base.setType("HardCopy");
            this.year = year;

        }
            

        public int getYear()
        {
            return year;
        }

        public void setYear(int year)
        {
            this.year = year;
        }


    }
}
