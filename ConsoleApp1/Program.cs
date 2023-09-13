// See https://aka.ms/new-console-template for more information
string ReverseString(string s)
{
    string reverse = "";

    for (int i = s.Length - 1; i >= 0; i--)
    {
        reverse += s[i];
    }

    return reverse;
}

bool IsSum(int[] a, int sum)
{

    for (int i = 0; i < a.Length; i++)
    {
        for (int j = 1; j < a.Length; j++)
        {
            if (a[i] + a[j] == sum && i != j)
            {
                return true;
            }
        }
    }
    return false;
}

Console.WriteLine(ReverseString("Hello"));
Console.WriteLine(IsSum(new int[] { 10, 8, 9, 17, 14, 6, 8, 3 }, 12));
Console.WriteLine(IsSum(new int[] { 10, 8, 9, 17, 14, 6, 8, 3 }, 100));
Console.WriteLine(IsSum(new int[] { 10, 8, 9, 17, 14, 6, 8, 3 }, 28));
Console.WriteLine(IsSum(new int[] { 10, 8, 9, 17, 14, 6, 8, 3 }, 34));
Console.WriteLine(IsSum(new int[] { 10, 8, 9, 17, 14, 6, 8, 3 }, 17 + 6));