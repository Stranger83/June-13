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
					

			while (true)
			{
				List<string> input = Console.ReadLine().Split(' ').ToList();
				string command = input[0];
				
				if (command == "print")
				{
					break;
				}

				List<int> parameters = new List<int>();
				for (int i = 1; i < input.Count; i++)
				{
					parameters.Add(int.Parse(input[i]));
				}

				switch (command)
				{
					case "add":
						nums.Insert(parameters[0], parameters[1]);
						break;
					case "addMany":
						AddMany(nums, parameters);
						break;
					case "contains":
						Console.WriteLine(nums.IndexOf(parameters[0]));
						break;
					case "remove":
						nums.RemoveAt(parameters[0]);
						break;
					case "shift":
						ShiftLeft(nums, parameters);
						break;
					case "sumPairs":
						nums = SumPairs(nums);
						break;
				}
				
			}
			Console.WriteLine($"[{string.Join(", ", nums)}]");
		}

		private static List<int> SumPairs(List<int> nums)
		{
			List<int> summedPairs = new List<int>();
			for (int i = 0; i < nums.Count; i += 2)
			{
				if (i == nums.Count - 1)
				{
					summedPairs.Add(nums[i]);
				}
				else
				{
					summedPairs.Add(nums[i] + nums[i + 1]);
				}
			}
			nums = summedPairs;
			return nums;
		}

		private static void ShiftLeft(List<int> nums, List<int> parameters)
		{
			for (int i = 0; i < (parameters[0] % nums.Count); i++)
			{
				nums.Add(nums[0]);
				nums.RemoveAt(0);
			}
		}

		private static void AddMany(List<int> nums, List<int> parameters)
		{
			List<int> numsToAdd = new List<int>();
			for (int i = 1; i < parameters.Count; i++)
			{
				numsToAdd.Add(parameters[i]);
			}
			nums.InsertRange(parameters[0], numsToAdd);
		}
	}
}