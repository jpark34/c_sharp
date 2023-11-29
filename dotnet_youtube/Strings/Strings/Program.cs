// See https://aka.ms/new-console-template for more information
string firstFriend = "Maria";
string secondFriend = "Scott";

// Two ways of writing the same thing
// Top being string interpolation
// Bottom being composite formatting
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine("My friend is " + firstFriend + " and " + secondFriend);

// Trim() functions that allow you to remove whitespace
string trimFriend = "     Maria     ";
string trimFront = firstFriend.TrimStart();
string trimLast = firstFriend.TrimEnd();
string trimed = trimFriend.Trim();
Console.WriteLine($"Trim extra characters {firstFriend.Trim()}");