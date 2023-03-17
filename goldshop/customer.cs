class Customer{
    int Id=1;
    string Name;
    string Address;
    public void Accept(){
        Console.WriteLine("enter your name :");
        Name=Console.ReadLine();
        Console.WriteLine("enter your Address:");
        Address=Console.ReadLine();
    }
    public void Display(){
        Console.WriteLine("id:{0} ",Id);
        Console.WriteLine("Name:{0} ",Name);
        Console.WriteLine("Address:{0}",Address);
    }


}