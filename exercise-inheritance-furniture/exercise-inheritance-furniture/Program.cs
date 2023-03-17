using System;
using System.Dynamic;
using System.Xml.Serialization;

namespace exercise_inheritance_furniture
{
   public class Program
    {
        static void Main(string[] args)
        {
            Furniture[] items = new Furniture[2];
            Program p = new Program();
            int a = p.AddToStock(items);
            double b = p.TotalStockValue(items);
            int c=p.ShowStockDetails(items);
            //create an array  of objects in furniture type
            //create program class object
            // call AddToStock(<furniture array>);
            //call ShowStockDetails(<furniture array>);
            // call TotalStockValue(<furniture array>) and display output 

             
            
        }
       public int AddToStock(Furniture []items) {
            int count = 0, choice;
            for (count = 0; count < items.Length; count++)
            {
                Console.WriteLine("enter the choice 1.Bookshelf 2.DiningTable");
                choice=Convert.ToInt32(Console.ReadLine()); ;
                switch(choice)
                {
                    case 1:
                        items[count] = new BookShelf();
                        Console.WriteLine("enter bookshelf data");
                        items[count].Accept();
                        break;
                    case 2:
                        items[count] = new DiningTable();
                        Console.WriteLine("enter DiningTable Data");
                        items[count].Accept();
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
            }

            //accept the choice from user for type of furniture(BookShelf  or DiningTable)
            // and according to the choice create necessary sub class object and store data
            //continue the process up to the size of array

            // return <size of array>;
            return count;
        }
     public   double TotalStockValue(Furniture []items)
        {
            double stockValue=default;
            //calculate total stock value i.e qty * price of each item
            foreach(var c in items)
            {
                stockValue += c.Price * c.Qty;
            }
            return stockValue;
        }
        public   int ShowStockDetails(Furniture[] items)
        {
            //call display method from all object to display the stock 
           //return <size of array>;
           foreach(var c in items)
            {
                c.Display();
            }
           return 0;    
        }
    }
}
