using System;

namespace ConvertStringToLowerCase
{
    class Program
    {
        //Write a C# program to convert a given string into lowercase.
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a word in all capitals : ");
            string word = Console.ReadLine();

            Console.WriteLine(word.ToLower());
        }
    }
}
