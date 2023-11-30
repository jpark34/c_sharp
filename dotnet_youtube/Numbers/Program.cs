// See https://aka.ms/new-console-template for more information

// int can hold 32 signed bits, 2^32
int a = 18;
// long can hold 64 signed bits, 2^64
long b = 6;
// coerce the int into a long to allow for 
long c = (long)a + b;
// checked() function throws an error if the math can not be completed
long c = checked(a + b);

Console.WriteLine(c);