//  Input from user is being taken and saved
int cases = int.Parse(Console.ReadLine());
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

//  Program throws exception when number of cases is invalid
if (cases < 2 || cases > 20)
{
    throw new Exception("Number of cases must be between 2 and 20 inclusive");
}
if (numbers.Length != cases)
{
    throw new Exception("Number of cases does not equal length of number array");
}

//  Dictionary is created, which stores digit occurences and their count
Dictionary<int, int> digitCount = new Dictionary<int, int>();

//  Each number from input gets modulo divided until it is 0, and every sinlge
//  digit is added to dictionary
foreach (int n in numbers)
{
    int temp = n;
    while (temp != 0)
    {
        int rest = temp % 10;
        temp = temp / 10;

        //  If dictionary doesn't have key in it, it is getting added
        if (!digitCount.ContainsKey(rest))
        {
            digitCount.Add(rest, 1);
        }
        //  Otherwise count of partical digit is incremented
        else
        {
            digitCount[rest] += 1;
        }
    }
}

//  Key with biggest value is taken from dictionary
int max = digitCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

Console.WriteLine(max);
