using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        private string _className;
        private List<Studerende> _classList;
        private DateTime _semesterStart;

        public KlasseRum()
        {
            _classList = new List<Studerende>();
        }

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }

        public List<Studerende> ClassList
        {
            get { return _classList;}

            set { _classList = value; }
        }

        public DateTime SemesterStart
        {
            get{ return  _semesterStart;}

            set { _semesterStart = value; }
        }

        


         public override string ToString()
        {
            return _className + _classList + _semesterStart;
        }
    }
}
