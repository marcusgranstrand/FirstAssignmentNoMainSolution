using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAssignmentNoMain.Classes
{
	public class Methods
	{
		public static string WhatIsYourName()
		{
			Console.WriteLine("Hi There, What is your name: ");
			string name = Console.ReadLine();
			return name;
		}

		public static string PrefixText()
		{
			Console.WriteLine("Hi, Please enter a word: ");
			string input = Console.ReadLine();
			string prefixedText = input.Insert(0, "#");
			return prefixedText;
		}

		public static string EnteredText(string message)
		{
			Console.WriteLine(message);
			string input = Console.ReadLine();
			return input;
		}

		public static string EnteredText2(string word)
		{
			Console.WriteLine($"Please enter a {word}:");
			string input = Console.ReadLine();
			return input;
		}

		public static string FullName(string firstName, string lastName)
		{
			string last = $"{lastName[0].ToString().ToUpper()}" +
							$"{lastName.ToLower().Substring(1)}";
			string first = $"{firstName[0].ToString().ToUpper()}" +
							$"{firstName.ToLower().Substring(1)}";

			return $"{last}, {first}";
		}
	}
}
