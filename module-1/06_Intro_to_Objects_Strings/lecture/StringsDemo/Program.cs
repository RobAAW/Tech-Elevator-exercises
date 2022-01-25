using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ada Lovelace";

            // Strings are actually arrays of characters (char).
            // Those characters can be accessed using [] notation.

            // 1. Write code that prints out the first and last characters
            //      of name.
            // Output: A
            // Output: e
            char firstCharacter = name[0];
            char lastCharacter = name[name.Length - 1];
            //string interpolation = $
            Console.WriteLine($"first and last character: {firstCharacter} & {lastCharacter}");
            //string concatenation
            Console.WriteLine("first and last character: " + firstCharacter + "&" + lastCharacter);


            // Console.WriteLine("First and Last Character. ");

            // 2. How do we write code that prints out the first three characters
            // Output: Ada
            string firstThreeCharacters = name.Substring(0, 3);

            Console.WriteLine("First 3 characters: " + firstThreeCharacters);

            // 3. Now print out the first three and the last three characters
            // Output: Adaace
            string lastThreeCharacters = name.Substring(name.Length - 3);

            Console.WriteLine("Last 3 characters: " + lastThreeCharacters);

            // 4. What about the last word?
            // Output: Lovelace
            string[] words = name.Split(' ');
            string lastWord = words[words.Length - 1];

            Console.WriteLine("Last Word: " + lastWord);

            // 5. Does the string contain inside of it "Love"?
            // Output: true

            Console.WriteLine("Contains \"Love\" " + name.Contains("Love"));

            // 6. Where does the string "lace" show up in name?
            // Output: 8


            Console.WriteLine("Index of \"lace\": " + name.IndexOf("lace");

            // 7. How many 'a's OR 'A's are in name?
            // Output: 3

            int countA = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'A' || name[i] == 'a')
                {
                    countA++;
                }              
            }

            Console.WriteLine("Number of \"a's\": " + countA);

            // 8. Replace "Ada" with "Ada, Countess of Lovelace"
            name = name.Replace("Ada", "Ada, Countess of");


            Console.WriteLine(name);


            // 9. Set name equal to null.

            name = null;

            // 10. If name is equal to null or "", print out "All Done".

            if(String.IsNullOrEmpty(name))
            {
                Console.WriteLine("All Done");
            }

            Console.ReadLine();
        }
    }
}