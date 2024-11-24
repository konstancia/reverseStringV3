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
        
        string reverseString = "";
        
        for (int i = 0; i < wordLength; i++)
        {
            reverseString += word[wordLength-1-i];
        }
        
        Console.WriteLine(reverseString);
        Console.WriteLine(word);

        if (reverseString == word)
        {
            Console.WriteLine("Your word is a palindrome");
        }
        else
        {
            Console.WriteLine("Your word is not a palindrome");
        }
        }
}