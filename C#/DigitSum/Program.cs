//  Program takes input from user
int count = int.Parse(Console.ReadLine());
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

//  Exception is thrown when number of cases does not equal array length
if (count != numbers.Length)
{
    throw new Exception("Number of test cases does not equal array length");
}

//  Maximum digits sum and its index are assigned
int maxCount = 0;
int maxIndex = 0;

//  While iterating through numbers array we check if value is bigger than
//  max count, if so we assing it to that variable
for (int i = 0; i < numbers.Length; i++)
{
    int sum = sumDigits(numbers[i]);
    if (sum > maxCount)
    {
        maxCount = sum;
        maxIndex = i;
    }
}

//  Index of number with maximum digits sum is being printed in console
Console.WriteLine(maxIndex);

//  Helper method which calculates sum of digits using modulo
int sumDigits(int number)
{
    int temp = number;
    int sum = 0;
    while (temp != 0)
    {
        sum += temp % 10;
        temp /= 10;
    }
    return sum;
}
