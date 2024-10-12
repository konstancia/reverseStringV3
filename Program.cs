namespace ConsoleApp4;

public class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello, This program will reserve a string.");
        Console.WriteLine(("Please enter a word:"));

        //convert to lower case to check for palindrome
        string word = (Console.ReadLine().ToLower());

        Console.WriteLine($"You have entered: {word}");

        int wordLength = word.Length;
        Console.WriteLine($"Your word contains {wordLength} characters");

        for (int i = wordLength- 1; i >= 0; i--)
            Console.WriteLine($"Your word backwards is {word[i]}");



    }
}