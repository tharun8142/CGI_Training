using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CarWala
    {
        //initialise dictionary
        Dictionary<string, double> car;
        public CarWala()
        {
            //initialise the collection with 10carnames and prices
            car = new Dictionary<string, double>();
            car.Add("Maruti", 900000 );
            car.Add( "Swift", 1500000 );
            car.Add("Mercedes", 2500000);
            car.Add( "Benz", 10000000 );
            car.Add( "Benelli", 15000000);
            car.Add( "Chervolet", 1600000);
            car.Add( "Audi", 7500000);
            car.Add( "RolceRoyce", 40000000);
            car.Add( "ALto", 1700000);
            car.Add( "Tesla", 4000000);
        
        }
        //create Function and display carnames starting with letter 'M'
        public void ListNames()
        {
            Console.WriteLine("CarsNames Start with M");
            foreach(KeyValuePair<string,double> kvp in car)
            {
                if (Regex.IsMatch(kvp.Key, "[M]"))
                {
                    Console.WriteLine(kvp.Key+ ": " + kvp.Value);
                }
            }
        }
        //create function dispaly where carnames price is bvove 10lakhs 
        public void ListPrice()
        {
            Console.WriteLine("CarNmaes where price is above 10lakhs");
            foreach(KeyValuePair<string,double> kvp in car)
            {
                if (kvp.Value > 1000000)
                {
                    Console.WriteLine(kvp.Key+ ":"+kvp.Value);
                }
            }
        }
        //create Function if price is greater than 15lakhs and apply discount of 20% on price and display carName and Discount price
        public void ApplyDiscount()
        {
            Console.WriteLine("Discount price details");
            foreach(KeyValuePair<string,double>kvp in car)
            {
                if (kvp.Value > 1500000)
                {
                    //create try block 
                    try
                    {
                        double value = (kvp.Value * 0.2);
                        Console.WriteLine(kvp.Key + ":" + kvp.Value);
                    }
                    //catch generic exception
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                }
            }
        }
    }
}
