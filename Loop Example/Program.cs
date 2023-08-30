
Console.WriteLine("Hello, World!");

int i = 0; // Initialization statement
while (i < 10) // Condition statement
{
	Console.WriteLine("i: " + i);
	i++; // Control statement
}

// for (<initialization> ; <condition> ; <control> )
for (int j = 0; j < 10; j++)
{
	Console.WriteLine("j: " + j);
}

for (int a = 10; a <= 25; a += 5)
{
	Console.WriteLine(a);
}


// x = x + 5
// x += 5

// y = y + 1
// y += 1
// y++
// ++y

int y = 0;
Console.WriteLine(y);
Console.WriteLine(y++); // Return y first, and then increment
Console.WriteLine(++y); // Increment y first, and then return




// User inputs as many numbers as they want until they input 0
// How many numbers were inputted
// Sum all the numbers

Console.WriteLine("Input numbers (0 to exit)");
int input = int.Parse(Console.ReadLine());
int count = 0;
int sum = 0;

// Repeat until inputting 0
while (input != 0)
{
	// Increment count by 1 with every input to count how many inputs we got
	count++;

	// Sum all the input
	sum += input;

	// User inputs number
	input = int.Parse(Console.ReadLine());
}

Console.WriteLine("Number count: " + count);
Console.WriteLine("Input sum: " + sum);
Console.WriteLine("Avg: " + ((double)sum / count));

int aa = 5;
int bb = 6;
int cc = 4;
Console.WriteLine(aa + (double)bb / cc); // 6.5
Console.WriteLine(aa + bb / (double)cc); // 6.5
Console.WriteLine((double)aa + bb / cc); // 6


// Input meal price
// Input total payment
// Output client rating

Console.WriteLine("Price:");
double price = double.Parse(Console.ReadLine());

Console.WriteLine("Paid:");
double paid = double.Parse(Console.ReadLine());

// (100 - 50) / 50 =  1.00 (100%)
// (75 - 50)  / 50 =  0.5  (50%)
// (25 - 50)  / 50 = -0.5  (-50%)
double tipPercentage = (paid - price) / price;

if (tipPercentage < 0)
	Console.WriteLine("Thief!");
else if (tipPercentage < 0.1)
	Console.WriteLine("Cheap");
else if (tipPercentage < 0.2)
	Console.WriteLine("Normal");
else if (tipPercentage < 0.3)
	Console.WriteLine("Nice");
else
	Console.WriteLine("Mister Moneybags");


//		Fibonacci exercise:
// A1 = 1, A2 = 1
// An = A(n-1) + A(n-2)

// Output first 20 numbers in the sequence
int A1 = 1;
int A2 = 1;
for (int n = 3; n <= 20; n++)
{
	int sumFi = A1 + A2;
	Console.WriteLine(sumFi);

	A1 = A2;
	A2 = sumFi;
}


// Output all numbers smaller than 10000
A1 = 1;
A2 = 1;
while (A2 < 10000)
{
	Console.WriteLine(A2);
	A2 = A2 + A1;
	A1 = A2 - A1;
}