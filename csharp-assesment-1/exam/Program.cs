namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create new instance of carwala
            CarWala car = new CarWala();
            //call the functions
            car.ListNames();
            car.ListPrice();
            car.ApplyDiscount();
        }
    }
}