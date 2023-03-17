class Sublimation{
    double Weight,Price,Depreciation,Makingcharge,Gross,Total,Net;
    public void Details(){
        Console.WriteLine("enter the weight: ");
        Weight=Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("enter price for 1 gram:");
        Price=Convert.ToDouble(Console.ReadLine());
        
        Gross=Weight*Price;
    }
    public void Depreciationcal(){
        Console.WriteLine("enter depreciation percentage: ");
        Depreciation=Convert.ToDouble(Console.ReadLine());
        Total=Gross*Depreciation;
    }
    public void Makingchargescal(){
        Console.WriteLine("enter making charges percentage");
        Makingcharge=Convert.ToDouble(Console.ReadLine());
        Total+=Gross*Makingcharge;
    }
    public void Netcal(){
        Net=Gross+Total;
        Console.WriteLine("the total value:{0}",Net);
    }
}