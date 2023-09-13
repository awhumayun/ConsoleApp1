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

Console.WriteLine(ReverseString("Hello"));