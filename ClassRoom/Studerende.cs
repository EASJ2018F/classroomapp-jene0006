using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
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

        public string Seasons()
        {
            if (Birthday == 3 || Birthday == 4 || Birthday == 5)
            {
                return "Spring";
            }

            else if (Birthday == 6 || Birthday == 7 || Birthday == 8)
            {
                return "Summer";
            }

            else if (Birthday == 9 || Birthday == 10 || Birthday == 11)
            {
                return "Fall";
            }
            else if (Birthday == 12 || Birthday == 1 || Birthday == 2)
            {
                return "Winter";
            }
            return "";

        }

        public override string ToString()
        {
            return  $"{Name}{Birthmonth}{Birthday}";
        }
    }


        
        
    
}
