using System;
using System.Collections.Generic;

namespace CollectionsPart1Lecture
{
    public class CollectionsPart1Lecture
	{
        static void Main(string[] args)
        {
			Console.WriteLine("####################");
			Console.WriteLine("       LISTS");
			Console.WriteLine("####################");

			List<string> names = new List<string>();
			names.Add("A-aron");
			names.Add("Steve");
			names.Add("Joe Biden");
			names.Add("someone not political");
			names.Add("Steve Rogers");
			names.Add("S. Rogers");


			Console.WriteLine("####################");
			Console.WriteLine("Lists are ordered");
			Console.WriteLine("####################");

			for (int i = 0; i < names.Count; i++)
            {
				Console.WriteLine(names[i]);
            }

			names.Insert(2, "Major");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow duplicates");
			Console.WriteLine("####################");

			names.Add("Major");



			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be inserted in the middle");
			Console.WriteLine("####################");

			names.Insert(2, "Major");


			Console.WriteLine("####################");
			Console.WriteLine("Lists allow elements to be removed by index");
			Console.WriteLine("####################");

			names.RemoveAt(4);


			Console.WriteLine("####################");
			Console.WriteLine("Find out if something is already in the List");
			Console.WriteLine("####################");

			names.Contains("A-aron");


			Console.WriteLine("####################");
			Console.WriteLine("Find index of item in List");
			Console.WriteLine("####################");

			Console.WriteLine(names.IndexOf("Major");


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be turned into an array");
			Console.WriteLine("####################");

			string[] arrayNames = names.ToArray();


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be sorted");
			Console.WriteLine("####################");

			names.Sort();


			Console.WriteLine("####################");
			Console.WriteLine("Lists can be reversed too");
			Console.WriteLine("####################");

			names.Reverse();


			Console.WriteLine("####################");
			Console.WriteLine("       FOREACH");
			Console.WriteLine("####################");
			Console.WriteLine();

			foreach ( string name in names )
            {
				Console.WriteLine(name);
            }

			Stack<string> urlHistory = new Stack<string>();
			urlHistory.Push("https://www.google.com");
			urlHistory.Push("some other website");
			urlHistory.Push("https://www.facecbook.com");
			string lastWebsite = urlHistory.Pop();
			urlHistory.Push("something else");

			Queue<string> customers = new Queue<string>();
			customers.Enqueue("First Customer");
			customers.Enqueue("Second Customer");
			customers.Enqueue("Third Customer");
			string currentCustomer = customers.Dequeue();
			customers.Enqueue("Fourth Customer");




		}
	}
}
