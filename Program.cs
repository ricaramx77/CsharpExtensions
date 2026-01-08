
using StringExtensionsDemo;

class Program
{
    static void Main(string[] args)
    {
        string text1 = "hello world";
        string text2 = "racecar";
        string text3 = "This is a simple test";

        Console.WriteLine($"Original: {text1}");
        Console.WriteLine($"Title Case: {text1.ToTitleCase()}");
        Console.WriteLine($"Reversed: {text1.ReverseString()}");
        Console.WriteLine();

        Console.WriteLine($"Original: {text1}");
        Console.WriteLine($"Capitalize: {text1.CapitalizeFirstLetter()}");
        Console.WriteLine();

        Console.WriteLine($"Original: {text2}");
        Console.WriteLine($"Is Palindrome: {text2.IsPalindrome()}");
        Console.WriteLine();

        Console.WriteLine($"Original: {text3}");
        Console.WriteLine($"Word Count: {text3.WordCount()}");

        
    }
}