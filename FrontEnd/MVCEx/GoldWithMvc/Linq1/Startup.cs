using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class Startup
    {
        delegate void Calc(double a, double b);//delegate type declaration

        public Startup()
        {
            Calc c; //delegate variable
            c = Add;   //stores address of Add function
                                   // Console.WriteLine( c(4,4)); //calling add function through delegate variable
                                   // c = (double k, double j) => { return k + j; }; ///statement lambda
            c += (double k, double j) => { Console.WriteLine(k * j); }; ///expression lambda
            c(4, 5);//will call add function and lambda function
            // multicast delegate - more than one function address stored (+=)
            // single cast delegate - one functiona address is stored.

            c += delegate (double x, double y) { Console.WriteLine(x / y); };
            Function1(Add);//calling with named function
            Function1((x, y) => { }); //calling lambda function
            Function3((a, b, c) => a + b + c);
        }

       static void Add(double x, double y) { Console.WriteLine(x + y); }
        static void Function1(Calc param1)
        {
            param1(4, 5);
        }
        static void Function3(Func<double, double, double, double> param1)
        //param1 can receive address of a function which accept three double values
        //and return a double value
        { }
    }
}
