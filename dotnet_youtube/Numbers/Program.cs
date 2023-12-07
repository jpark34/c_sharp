// See https://aka.ms/new-console-template for more information

// int can hold 32 signed bits, 2^32
int a = 18;
// long can hold 64 signed bits, 2^64
long b = 6;
// coerce the int into a long to allow for 
long c = (long)a + b;
// checked() function throws an error if the math can not be completed
// long c = checked(a + b);

Console.WriteLine(c);


// you must give C# explicit types
double d = 18.234; // natural type
float e = 15.65F;
// cast a number
int f = (int) 17.1;
// can get more accurate with a decimal type
decimal g = 38.65M; // exclusive type

Console.WriteLine($"The answer is {g}");