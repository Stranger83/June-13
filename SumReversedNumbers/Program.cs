using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> input = Console.ReadLine().Split(' ').ToList();
			int sum = 0;
			for (int i = 0; i < input.Count; i++)
			{
				char[] nums = input[i].ToCharArray();
				Array.Reverse(nums);
				string finalNum = "";
				for (int j = 0; j < nums.Length; j++)
				{
					finalNum += nums[j];
				}
				
				sum += int.Parse(finalNum);
			}
			Console.WriteLine(sum);
		}
	}
}
