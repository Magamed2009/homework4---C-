int a,b=0;
a=Convert.ToInt32(Console.ReadLine());
while(a!=0) {b=b*10+a%10; a/=10;}
void sum(int a)
{
    if(a>0) {System.Console.Write(a%10 + " "); sum(a/=10);}
}
sum(b);