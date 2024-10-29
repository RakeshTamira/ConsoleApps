using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class CopyCon
    {
        string name = "Sai";
        CopyCon() {
            Console.WriteLine("This is a parameter less constructor");
        }
        CopyCon(string txt)
        {
            this.name = txt;
            Console.WriteLine("This is a parameterized constructor " + this.name);
        }

        CopyCon(CopyCon obj)
        {
            this.name = obj.name + " Reddy";
            Console.WriteLine("This is the copy constructor " + name);
        }

        //and it is the first to be executed whena  program runs and it can't
        //be parameterized because we won't have a chance to pass the variable since it is the first line to be executed in the program
        static CopyCon()
        {
            Console.WriteLine("This is the static constructor"); 
        }

        public static void Main(string [] args)
        {
            CopyCon obj1 = new CopyCon();
            CopyCon obj2 = new CopyCon("Rakesh");
            CopyCon obj3 = new CopyCon(obj2);

            YCon obj4 = new YCon(1);
        }
    }
}
