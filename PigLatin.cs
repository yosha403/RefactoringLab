using System;
using System.Collections.Generic;
using System.Text;

namespace PigLatin
{
    class PigLatin
    {
        //static void Main(string[] args)
        //{
           // string userInput = GetInput("Please input a word or sentence to translate to pig Latin");
            //string translation = ToPigLatin(userInput);
            //Console.WriteLine(translation);
       // }

        public string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().ToLower().Trim();
            return input;
        }
        public bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            foreach (char w in vowels)
            {
                if (c == w)
                {
                    return true;
                }
            }
            return false;            
        }

        public string ToPigLatin(string word)
        {
            char[] specialChars = { '@', '.', '-', '$', '^', '&' };
            word = word.ToLower();
            foreach (char c in specialChars)
            {
                foreach (char w in word)
                {
                    if (w == c)
                    {
                        Console.WriteLine("That word has special characters, we will return it as is");
                        return word;
                    }
                }

            }

            bool noVowels = true;
            foreach (char letter in word)
            {
                if (IsVowel(letter))
                {
                    noVowels = false;
                }
            }

            if (noVowels)
            {
                return word;
            }

            char firstLetter = word[0];           
            string output;
            if (IsVowel(firstLetter) == true)
            {                
                output = word + "way";
            }
            else
            {
                int vowelIndex = -1;

                //Handle going through all the consonants
                for (int i = 0; i <= word.Length; i++)
                {
                    if (IsVowel(word[i]) == true)
                    {
                        vowelIndex = i;
                        break;
                    }
                }

                string sub = word.Substring(vowelIndex);
                string postFix = word.Substring(0, vowelIndex);

                output = sub + postFix + "ay";
            }

            return output;
        }
    }
}
