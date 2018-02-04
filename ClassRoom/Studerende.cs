using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Studerende
    {
         string _name;
         int _birthmonth;
         int _birthday;

        public Studerende(string name, int birthmonth, int birthday)
        {
            _name = Name;
            _birthmonth = Birthmonth;
            _birthday = Birthday;
        }

        public string Name
        {
            get { return _name; }

            set { _name = value; }
        }

        public int Birthmonth
        {
            get {return _birthmonth; }

            set { _birthmonth = value; }
        }

        public int Birthday
        {
            get { return _birthday; }

            set { _birthday = value; }
        }

        public string seasons()
        {
            if(Birthday == 3)
        }
    }
}
