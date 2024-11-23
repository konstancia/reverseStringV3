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
        string reverseStringV2 = "";

        for (int i = 0; i < wordLength; i++)
        {
            //string reverseString += word[i];
            reverseString += word[wordLength-1-i];
            // reverseString = reverseString + word[wordLength-1-i];
            // Console.WriteLine();
            
            //Console.WriteLine($"Your word backwards is {word[i]}");
        }

        for (int i = 0; i < wordLength; i++)
        {
            reverseStringV2 += word[i];
        }

        
        Console.WriteLine(reverseString);
        Console.WriteLine(reverseStringV2);

        if (reverseString == reverseStringV2)
        {
            Console.WriteLine("Your workd is a palindrome");
        }
        else
        {
            Console.WriteLine("Your word is not a palindrome");
        }
        
            //word[50-49] == word[1]

//wordLengt-1-i



    }
}