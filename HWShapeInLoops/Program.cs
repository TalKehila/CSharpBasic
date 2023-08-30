
// triangular
Console.WriteLine("enter the base of shape you want");
int Triangular_Number = int.Parse(Console.ReadLine());
string LatterTriangular = "*";
if (Triangular_Number >3 && Triangular_Number <10 )
{ 
    for (int i = 0; i < Triangular_Number; i++)
    {
        for (int j = Triangular_Number - i; j >= 0; j--)
        {
            Console.Write(" ");
        }
        Console.WriteLine(LatterTriangular);
        LatterTriangular += "**";
    }
    for (int d = 0; d > Triangular_Number; d--)
    {
        for (int s = Triangular_Number + d; s <= 0; s++)
        {
            Console.Write(" ");
        }
        Console.WriteLine(LatterTriangular);
        LatterTriangular += "**";
    }
}
else 
{
    Console.WriteLine("low or high number ");
    
}







Console.WriteLine("enter the base of shape you want");
int Square_Number = int.Parse(Console.ReadLine());

string LatterSquare = "";
for (int k = 0; k < Square_Number; k++)
{
    LatterSquare += "*";
}

for (int k = 0; k < Square_Number; k++)
{
    Console.WriteLine(LatterSquare);
}

Console.WriteLine("enter the base of shape you want");
int diamondBase=int.Parse(Console.ReadLine());
string diamondLine = "*";

   for (int i = 0; i < diamondBase; i++)
   {
       for (int j = diamondBase - i; j >= 0; j--)
       {
           Console.Write(" ");
       }
       Console.WriteLine(diamondLine);
       diamondLine += "**";
   }

   for (int i = diamondBase - 1; i >= 0; i--)
   {
       for (int j = diamondBase - i; j >= 0; j--)
       {
           Console.Write(" ");
       }
       Console.WriteLine(diamondLine.Substring(0, diamondLine.Length - 2));
       diamondLine = diamondLine.Substring(0, diamondLine.Length - 2);

   }





