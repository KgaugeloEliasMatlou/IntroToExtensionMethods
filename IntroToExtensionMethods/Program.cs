using System;

class Program
{
    static void Main()
    {
        string x = "hello";
        string y = "Hello";
        Console.WriteLine(x + " is capitalized ?" + x.Iscap());
        Console.WriteLine(y + " is capitalized ?" + y.Iscap());


    }

}
public static class Stringcap
{
    public static bool Iscap(this string s)
    {
        if (string.IsNullOrEmpty(s)) return false;
        return char.IsUpper(s[0]);
    }
}
