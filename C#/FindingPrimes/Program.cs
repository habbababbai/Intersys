//  Program takes number of test cases from user
//  and then it saves intervals in input array
int cases = int.Parse(Console.ReadLine());
string[][] input = new string[cases][];
int[] counts = new int[cases];

//  For each test case the boundaries of intervals are taken
//  And then number of prime numbers is saved
for (int i = 0; i < cases; i++)
{
    input[i] = Console.ReadLine().Split(" ");
    int m = int.Parse(input[i][0]);
    int n = int.Parse(input[i][1]);

    for (int j = m; j <= n; j++)
    {
        if (isPrime(j))
            counts[i]++;
    }
}
//  Number of prime numbers in intervals are written in console
foreach (int c in counts)
{
    Console.WriteLine(c);
}

//  Method that checks whether given number is prime
bool isPrime(int number)
{
    //  Checks for cases of numbers less than 1, equal to 2 or even numbers
    if (number <= 1)
        return false;
    if (number == 2)
        return true;
    if (number % 2 == 0)
        return false;
    //  Boundary is given at floor of square root of number
    int bound = (int)Math.Floor(Math.Sqrt(number));
    for (int i = 3; i <= bound; i += 2)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}