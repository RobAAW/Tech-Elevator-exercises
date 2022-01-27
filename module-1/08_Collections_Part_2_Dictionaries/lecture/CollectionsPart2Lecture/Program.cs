using System;
using System.Collections.Generic;

namespace CollectionsPart2Lecture
{
    public class CollectionsPart2Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       DICTIONARIES");
			Console.WriteLine("####################");
			Console.WriteLine();


			//declare and                          instantiate
			Dictionary<string, string> nameToZip = new Dictionary<string, string>();

			nameToZip["Beth"] = "16036";
			nameToZip["Dave"] = "15212";
			nameToZip["Dan"] = "15232";

			Console.WriteLine("Beth lives in " + nameToZip["Beth"]);


			IEnumerable<string> keys = nameToZip.Keys;

			nameToZip["Tyler"] = "15401";

			foreach (string name in keys)
            {
				Console.WriteLine($"{name} lives in  + {nameToZip[name]}");
			}

			if (nameToZip.ContainsKey("Dave"))
            {
				Console.WriteLine("Dave exists.");
            }

			nameToZip["Beth"] = "15237";

			//iterate over dictionary using KeyValuePair
			foreach(KeyValuePair<string, string> entry in nameToZip)
            {
				Console.WriteLine(entry.Key + " lives in " + entry.Value);
            }

		}
	}
}
