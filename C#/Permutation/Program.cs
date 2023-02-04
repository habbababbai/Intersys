//  Program takes two lines of users input which gets parsed to int arrays
int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

//  If there exists permutation of first array equal to second one program
//  writes ouput YES or NO otherwise
string output = arePermutations(arr1, arr2) ? "YES" : "NO";
Console.WriteLine(output);

//  Return true if there is permutation of first array equal to second
//  Returns false otherwise
static bool arePermutations(int[] arr1, int[] arr2)
{
    //  Dictionary holds all elements of first array and their count
    Dictionary<int, int> dict = new Dictionary<int, int>();

    //  Values from first array are added to dictionary
    for (int i = 0; i < arr1.Length; i++)
    {
        //  If value is not present in dictionary it is added
        int x = arr1[i];
        if (!dict.ContainsKey(x))
            dict.Add(x, 1);
        //  Otherwise count of specific number is added
        else
        {
            int k = dict[x];
            dict.Remove(x);
            dict.Add(x, k + 1);
        }
    }

    //  Traversing through second array to check wheter all elements
    //  of created Dictionary are present
    for (int i = 0; i < arr2.Length; i++)
    {
        int x = arr2[i];

        // When dictionary doesn't contain element returns false
        if (!dict.ContainsKey(x))
            return false;

        //  When dictionary holds different amount of counts returns false
        int k = dict[x];
        if (k == 0)
            return false;

        dict.Remove(x);
        dict.Add(x, k - 1);
    }
    return true;
}