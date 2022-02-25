using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using VendingMachine.Classes;

namespace VendingMachine.DAO
{
    public class FileDAO : IDAO
    {
        public Dictionary<string, Queue<VendingMachineItem>> LoadMachine(string filePath)
        {
            // Declare a local variable to hold the generated dictionary
            Dictionary<string, Queue<VendingMachineItem>> result = new Dictionary<string, Queue<VendingMachineItem>>();

            // Does the file exist?
            if (File.Exists(filePath))
            {
                // read in the file and populate the dictionary
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            // Read the line from the inventory file
                            string line = sr.ReadLine();
                            // The items are separated by the | character, split each value into an item in an array
                            string[] item = line.Split('|');

                            // Set an "out" variable to use in TryParse
                            decimal price = 0;
                            // Try parse kind of combines a try/catch block and a parse. If the parse succeeds, it returns true.
                            decimal.TryParse(item[2], out price);
                            // Set up a local queue that represents the items in a slot
                            Queue<VendingMachineItem> queue = new Queue<VendingMachineItem>();
                            // Check the type of item in a slot based on the input files
                            switch (item[3])
                            {
                                case "Chip":
                                    //instantiate the Queue
                                    queue = new Queue<VendingMachineItem>();
                                    // Add 5 objects to the queue
                                    for (int i = 0; i < 5; i++)
                                    {
                                        // declare an instantiate the product item
                                        ChipItem chipItem = new ChipItem(item[1], price);
                                        // Add it to the queue
                                        queue.Enqueue(chipItem);
                                    }
                                    result[item[0]] = queue;
                                    break;
                                case "Drink":
                                    //instantiate the Queue
                                    queue = new Queue<VendingMachineItem>();
                                    // Add 5 objects to the queue
                                    for (int i = 0; i < 5; i++)
                                    {
                                        // declare an instantiate the product item
                                        BeverageItem chipItem = new BeverageItem(item[1], price);
                                        // Add it to the queue
                                        queue.Enqueue(chipItem);
                                    }
                                    result[item[0]] = queue;
                                    break;
                                case "Candy":
                                    queue = new Queue<VendingMachineItem>();
                                    for (int i = 0; i < 5; i++)
                                    {
                                        CandyItem chipItem = new CandyItem(item[1], price);
                                        queue.Enqueue(chipItem);
                                    }
                                    result[item[0]] = queue;
                                    break;
                                case "Gum":
                                    queue = new Queue<VendingMachineItem>();
                                    for (int i = 0; i < 5; i++)
                                    {
                                        GumItem chipItem = new GumItem(item[1], price);
                                        queue.Enqueue(chipItem);
                                    }
                                    result[item[0]] = queue;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return result;
        }

        public void LogTransaction(string action, decimal txAmount, decimal currentBalance)
        {
            // Get the current directory
            string directory = Environment.CurrentDirectory;
            // Put together the fully qualified path to the log file
            string fullPath = Path.Combine(directory, "Log.txt");
            // Try block since we're doing something dangerous: reading a file
            try
            {
                // open a streamwriter to allow us to write to the file. Use the true parameter to append
                using (StreamWriter sw = new StreamWriter(fullPath, true))
                {
                    // write the line to the log
                    sw.WriteLine($"{DateTime.UtcNow.ToString()} {action}: {txAmount:C2} {currentBalance:C2}");
                }
            }
            catch (Exception e)
            {

            }
        }

        public void ResetLog()
        {
            // Get the current directory
            string directory = Environment.CurrentDirectory;
            // Put together the fully qualified path to the log file
            string fullPath = Path.Combine(directory, "Log.txt");
            // Try block since we're doing something dangerous: accessing a file
            try
            {
                // Delete the file
                File.Delete(fullPath);
            }
            catch (Exception)
            {
            }
        }
    }
}
