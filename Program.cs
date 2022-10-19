System.Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int d = 0;
int bbb = 0;
if (a>0)
{
int b = 1;
    while (b<=a) 
    {
       bbb = b*b*b;
       System.Console.Write(bbb+" ");
       b++;
    }
}
else
{
int b = -1;
    while (b>=a) 
    {
       bbb = b*b*b;
       System.Console.Write(bbb+" ");
       b--;
    }
}
       