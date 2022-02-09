using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
		public static void Main(string[] args)
		{
            // Prompt the user for a search word
            Console.WriteLine("What is the search word? ");
            string searchWord = Console.ReadLine();
            //searchWord = searchWord.ToLower();

            // Prompt the user for a replacement word
            Console.WriteLine("What is the replacement word? ");
            string replaceWord = Console.ReadLine();

            // What is the source file?
            Console.WriteLine("Please enter the path to the source file: ");
            string sourceFile = Console.ReadLine();

            // What is the destination file?
            Console.WriteLine("Please enter the desired destination file: ");
            string destinationFile = Console.ReadLine();

            try
            {
                using (StreamReader sr = new StreamReader(sourceFile))
                using (StreamWriter sw = new StreamWriter(destinationFile))
                {
                    // Loop until the end of file is reached
                    while (!sr.EndOfStream)
                    {
                        // Read an individual line
                        string line = sr.ReadLine();

                        // Replace the occurence of the word langauge with language
                        string fixedLine = line.Replace(searchWord, replaceWord);

                        // Write the new line to the output file
                        sw.WriteLine(fixedLine);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("*** Problem reading specified file: " + ex.Message);
                return;
            }

            // Tell the user what happened.
            /*string message = $"Converted {searchWord} to {replaceWord} " +
                             $"to {destinationFile} on {DateTime.Now}";
            Console.WriteLine(message);*/

        }
    }
}
