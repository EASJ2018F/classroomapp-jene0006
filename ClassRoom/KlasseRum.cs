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

        public void Seasons()
        {
            int Spring = 0;
            int Summer = 0;
            int Fall = 0;
            int Winter = 0;

            foreach (var Studerende in ClassList)
            {
                if (Studerende.Seasons()=="Spring")
                {
                    Spring += 1;
                }

                if (Studerende.Seasons() == "Summer")
                {
                    Summer += 1;
                }

                if (Studerende.Seasons() == "Fall")
                {
                    Fall += 1;
                }

                if (Studerende.Seasons() == "Winter")
                {
                    Winter += 1;
                }

                Console.WriteLine($"Spring: {Spring}");
                Console.WriteLine($"Summer: {Summer}");
                Console.WriteLine($"Fall: {Fall}");
                Console.WriteLine($"Winter: {Winter}");
            }



        }

        


         public override string ToString()
        {
            return $"{ClassName}{ClassList}{SemesterStart}";
        }
    }
}
