//  Program takes user input
int n = int.Parse(Console.ReadLine());
string[] input = Console.ReadLine().Split(" ");

//  Throws exception when length of input is not equal to n
if (input.Length != n)
    throw new Exception("Input length is different than n value");

//  Input array is reversed and printed out in console
Array.Reverse(input);
foreach (string s in input)
{
    Console.Write(s + " ");
}
