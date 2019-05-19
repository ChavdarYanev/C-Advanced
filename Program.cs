using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			Stack<char> stack = new Stack<char>();

			foreach (var item in text)
			{
				stack.Push(item);
			}

			while (stack.Count>0)
			{
				Console.Write(stack.Pop());
			}
			Console.WriteLine();
		}
	}
}
