char[] Name=new char[10];
int i,Count=0;

for(i=0;i<10;i++)

{
    Console.WriteLine("Enter the char{0}:",i);

    Name[i]=Convert.ToChar(Console.ReadLine());
}
for(i=0;i<10;i++){
if(Name[i]=='a'|| Name[i]=='e'|| Name[i]=='i' || Name[i]=='o' || Name[i]=='u'){
   Count+=1;
 } 
}
Console.WriteLine("Ovwels in the name:{0}",Count);



