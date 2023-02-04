//  In list are stored input numbers
List<uint> numbers = new List<uint>();

//  Program takes user input until he writes something different than unsinged integer
//  Whe does that app stops taking data
uint input;
while (uint.TryParse(Console.ReadLine(), out input))
{
    numbers.Add(input);
}

//  In HashSet powersOfTwo are stored unique powers of 2
HashSet<uint> powersOfTwo = new HashSet<uint>();
foreach (uint num in numbers)
{
    uint power = 1;
    while (power <= num)
    {
        //  When power of 2 is present in the integer it is added to HashSet
        if ((num & power) == power)
        {
            powersOfTwo.Add(power);
        }
        power *= 2;
    }
}

//  In case in which HashSet is empty program writes NA
if (powersOfTwo.Count == 0)
{
    Console.WriteLine("NA");
}
//  Otherwise values gets sorted and printed out in string form
else
{
    List<uint> sortedPowers = new List<uint>(powersOfTwo);
    sortedPowers.Sort();
    Console.WriteLine(string.Join(", ", sortedPowers));
}
