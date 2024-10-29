using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class YCon
    {
        // we can't initialize a class object without the constructor. There will always be implicit constructor.
        //Implicit constructors are called by default. with implicit constructors all objects instantiated for the class will have same values.
        //Parameterized constructors will give us the chance to initialize objects for the class with different variables.
        int x;

        public YCon(int i)
        {
            this.x = i;
            Console.WriteLine("X= "+x); //
            Console.WriteLine("Parameterized constructors allows us to assign values");
        }

        

    }
}
