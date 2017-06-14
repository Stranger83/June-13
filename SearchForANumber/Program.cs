using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

			for (int i = 0; i < nums.Count - command[0]; i++)
			{
				nums.Remove(nums[nums.Count - 1]);
			}

			for (int i = 0; i < command[1]; i++)
			{
				nums.Remove(nums[0]);
			}

			if (nums.Contains(command[2]))
			{
				Console.WriteLine("YES!");
			}else
			{
				Console.WriteLine("NO!");
			}
		}
	}
}
