﻿namespace ConsoleApp4;

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
        // wordLength = 4; "test"
        //i=0 -> t
        // i=1 => e
        // i = 2 => s
        // i=3 => t
        // i=4 -> 
        
        Console.WriteLine($"Your word contains {wordLength} characters");

        for (int i = wordLength- 1; i >= 0; i--)
            Console.WriteLine($"Your word backwards is {word[i]}");

            string reverseString = $"{word}";
            Console.WriteLine(reverseString[3]);
            Console.WriteLine(reverseString[2]);
            Console.WriteLine(reverseString[1]);
            Console.WriteLine(reverseString[0]);

        
            {
                //0 -> 3
                //1 -> 2
                //2 - > 1
                //3 -> 0
                //reverseString = t
                //reverseString = reverseString + e
                
                //Console.WriteLine($"Your word backwards is {word[i]}");
            }
            





    }
}