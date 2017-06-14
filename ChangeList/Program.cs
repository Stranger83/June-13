using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeList
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

			while (true)
			{
				string[] input = Console.ReadLine().Split(' ');
				string command = input[0];
				switch (command)
				{
					case "Delete":
						while (nums.Contains(int.Parse(input[1])))
						{
							nums.Remove(int.Parse(input[1]));
						}
												break;
					case "Insert":
						nums.Insert(int.Parse(input[2]), int.Parse(input[1]));
						break;
					case "Odd":
						for (int i = 0; i < nums.Count; i++)
						{
							if (nums[i] % 2 != 0)
							{
								Console.Write($"{nums[i]} ");
							}
						}
						Console.WriteLine();
						return;
					case "Even":
						for (int i = 0; i < nums.Count; i++)
						{
							if (nums[i] % 2 == 0)
							{
								Console.Write($"{nums[i]} ");
							}
						}
						Console.WriteLine();
						return;
				}
			}
		}
	}
}
