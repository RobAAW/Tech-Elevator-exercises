using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {

        //alices_adventures_in_wonderland.txt
        
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("Please enter the path to the book file: ");   
            string filePath = Console.ReadLine();
            string path1 = @"C:\Users\Student\workspace\aaron-ward-student-code\module-1\16b_File_IO_Reading\exercise\";
            string fullPath = Path.Combine(path1, filePath);

            //2. Ask the user for the search string
            Console.WriteLine("What word are you looking for?: ");
            string wordSearch = Console.ReadLine();

            Console.WriteLine("Should the search be case sensitive? (Y\\N)?: ");
            string yesOrNo = Console.ReadLine();
            yesOrNo = yesOrNo.ToLower();

            bool caseSensitive = false;

            if (yesOrNo == "y")
            {
                caseSensitive = true;
            }
            else
                caseSensitive = false;

            //3. Open the file
            //4. Loop through each line in the file
            try
            {
                using (StreamReader fileInput = new StreamReader(fullPath))
                {
                    int lineCount = 0;
                    while (!fileInput.EndOfStream)
                    {
                        string lineOfText = fileInput.ReadLine();
                        lineCount++;

                        if (!caseSensitive)
                        {
                            wordSearch = wordSearch.ToLower();
                            
                            if (lineOfText.ToLower().Contains(wordSearch))
                            {
                                Console.WriteLine($"{lineCount}) {lineOfText}");
                            }
                            
                        }
                        else if (caseSensitive)
                        {
                            if (lineOfText.Contains(wordSearch))
                            {
                                Console.WriteLine($"{lineCount}) {lineOfText}");
                            }
                            
                        } 
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Sorry, couldn't find " + wordSearch + ". Try again please!");
                Console.WriteLine(ex.Message);
            }
        }   
    }
    
}
