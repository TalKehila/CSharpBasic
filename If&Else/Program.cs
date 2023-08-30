
Console.WriteLine("enter number");

int x = int.Parse(Console.ReadLine());

Console.WriteLine("within 0...100 ");
if (x > 0 && x <= 100)
{
    Console.WriteLine("True");


}
else
{
    Console.WriteLine("False");
}

if (x >= 0 && x <= 200 && x % 2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

if (x <= 0 || x >= 100)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}

int y;
Console.WriteLine("enter number");

y = int.Parse(Console.ReadLine());

Console.WriteLine("within 0...100 ");

Console.WriteLine(y > 0 && y <= 100);


Console.WriteLine("within  0...200  and even ");

Console.WriteLine(y >= 0 && y <= 200 && y % 2 == 0);

Console.WriteLine("out side 0...100 ");

Console.WriteLine(y < 0 || y > 100);

