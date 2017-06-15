using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			string input = Console.ReadLine();		

			while (input != "print")
			{
				var parameters = input.Split();
				var command = parameters[0];

				switch (command)
				{
					case "add":
						nums.Insert(int.Parse(parameters[1]), int.Parse(parameters[2]));
						break;
					case "addMany":
						AddMany(nums, parameters);
						break;
					case "contains":
						Console.WriteLine(nums.IndexOf(int.Parse(parameters[1])));
						break;
					case "remove":
						nums.RemoveAt(int.Parse(parameters[1]));
						break;
					case "shift":
						ShiftLeft(nums, parameters);
						break;
					case "sumPairs":
						nums = SumPairs(nums);
						break;
				}
				input = Console.ReadLine();
			}
			Console.WriteLine($"[{string.Join(", ", nums)}]");
		}

		private static List<int> SumPairs(List<int> nums)
		{
			List<int> summedPairs = new List<int>();
			for (int i = 0; i < nums.Count; i += 2)
			{
				int currentElement = nums[i];
				int nextElement = 0;
				if (i < nums.Count - 1)
				{
					nextElement = nums[i + 1];
				}
				summedPairs.Add(currentElement + nextElement);
			}
			nums = summedPairs;
			return nums;
		}

		private static void ShiftLeft(List<int> nums, string[] parameters)
		{
			int count = int.Parse(parameters[1]) % nums.Count;
			for (int i = 0; i < count; i++)
			{
				nums.Add(nums[0]);
				nums.RemoveAt(0);
			}
		}

		private static void AddMany(List<int> nums, string[] parameters)
		{
			List<int> numsToAdd = new List<int>();
			for (int i = 2; i < parameters.Length; i++)
			{
				numsToAdd.Add(int.Parse(parameters[i]));
			}
			nums.InsertRange(int.Parse(parameters[1]), numsToAdd);
		}
	}
}