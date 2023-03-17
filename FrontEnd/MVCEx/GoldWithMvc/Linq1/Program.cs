using Linq1;
using System.Net.Http.Headers;

namespace Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {  
               string[] names = {
                "bhrarth",
                "uday",
                "sachin",
                "tharun",
                "syam"
                    };
            /*IEnumerable<string> data = from s in names
                       select s;
*/
            //or
            /*var data = from s in names
                       where s.StartsWith('s')
                       select s;
            foreach (string s in data)
            {
                Console.WriteLine(s);
            }*/
            //using extension  method
            var data1 = names.Where((s) => s.StartsWith('s'));
            foreach(string s in data1)
            {
                Console.WriteLine(s);
            }
            List<Product> items = new List<Product>()
            {
                new Product(){Id=1,Name="Samsumg z6",Price=3452},
                new Product(){Id=2,Name="Mi Max2",Price=6765},
                new Product(){Id=3,Name="Poco f5",Price=9876},
                new Product(){Id=4,Name="Realme 6",Price=22345},
                new Product(){Id=5,Name="Honor 8",Price=4358},
            };
            /* var result = from i in items
                          where i.Price > 3000
                          orderby i.Price
                          select new { i.Name, i.Price };*/
            var result = items
                .Where((p) => p.Price > 4000)
                .OrderBy(i => i.Price)
                .Select((i) => new { i.Name, i.Price });
                         
            foreach (dynamic p in result)
            {
                Console.WriteLine(p);
            }
        }
    }
}
