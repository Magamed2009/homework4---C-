int a;
void sum(int a)
{
    if(a>0) {sum(a-1); System.Console.Write($"{a} ");}
}
a=Convert.ToInt32(Console.ReadLine());
sum(a);