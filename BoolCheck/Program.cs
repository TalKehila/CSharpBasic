﻿namespace BoolCheck
{
	public class Program
	{
		static void Main(string[] args)
		{
			bool flag = false;
			List<int> list = new List<int>() { 1, 3, 2, 4, 5 };
			int n = 0;
			foreach (int i in list)
			{
				if (i == 3)
				{
					flag = true;
					n = i;
				}

			}
			if (flag)
			{

				Console.WriteLine($"{flag} was found {n}");
			}
			
		}
	}
}
