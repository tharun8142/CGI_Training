using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq1
{
    internal class ActionDelegate
    {
        void Test1(Action<int,int> param1)
        {

        }
        void Test2(Func<int,int,string> param1)
        {
            Console.WriteLine(param1(10,5));
        }
        string some(int a,int b)
        {
            return a + b.ToString();
        }
    }
}
