using System.Text.RegularExpressions;

//  Program takes user input and using regular expressions removes all
//  characters that are not lowercase and uppercase letters
string input = Console.ReadLine();
input = Regex.Replace(input, "[^a-zA-Z]+", "");

//  Checks wether input is equal to its reversed value
//  If it is true prints YES, otherwise NO
string output = input.SequenceEqual(input.Reverse()) ? "YES" : "NO";

Console.WriteLine(output);
