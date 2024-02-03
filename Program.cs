using System;
using System.Collections.Generic;
class Program
{
	static void Main(string[] args)
	{

		List<string> list = new List<string>();

		list.Add ("C#");
		list.Add("Java");
		list.Add("JavaScript");

		Console.WriteLine(list[0]);

		Console.ReadKey();
	}
}