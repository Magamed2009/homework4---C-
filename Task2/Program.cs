int a;
void sum(int a)
{
    if(a!=0)
    {
        System.Console.Write($"{a} "); sum(a-1);
    }
}
a=Convert.ToInt32(Console.ReadLine());
sum(a);