// See https://aka.ms/new-console-template for more information
void armstrong(int num){
    int r,temp=num,sum=0;
    while(num>=0){
        r=num%10;
        sum+=r*r*r;
        num/=10;
    }
    if(num==temp){
        Console.WriteLine("armstrong");

    }
    if(num!=temp){
        Console.WriteLine("not armstrong");
    }
}
armstrong(153);
armstrong(143);
