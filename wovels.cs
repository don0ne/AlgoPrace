using System;
using System.Linq;

public class VowelsCounter
{
    public static int CountVowels(string str)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
        return str.Count(c => vowels.Contains(char.ToLower(c)));
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(CountVowels("Hi There!"));
        Console.WriteLine(CountVowels("Why do you ask?"));
        Console.WriteLine(CountVowels("Why?"));
        Console.WriteLine(CountVowels("aeiou")); 
        Console.WriteLine(CountVowels("AEIOU")); 
        Console.WriteLine(CountVowels("abcdefghijklmnopqrstuvwxyz"));
        Console.WriteLine(CountVowels("bcdfghjkl"));
    }
}
