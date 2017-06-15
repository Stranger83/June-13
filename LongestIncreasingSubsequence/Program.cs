using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			List<int> longestIncreasingSubsequence = FindLongestIncreasingSubsequence(nums);
			Console.WriteLine(string.Join(" ", longestIncreasingSubsequence));
		}

		private static List<int> FindLongestIncreasingSubsequence(List<int> nums)
		{
			int[] lengths = new int[nums.Count];
			int[] previous = new int[nums.Count];
			int bestLength = 0;
			int lastIndex = -1;
			for (int anchor = 0; anchor < nums.Count; anchor++)
			{
				lengths[anchor] = 1;
				previous[anchor] = -1;
				int anchorNum = nums[anchor];
				for (int i = 0; i < anchor; i++)
				{
					int currentNum = nums[i];
					if (currentNum < anchorNum && lengths[i] + 1 > lengths[anchor])
					{
						lengths[anchor] = lengths[i] + 1;
						previous[anchor] = i;
					}
				}
				if (lengths[anchor] > bestLength)
				{
					bestLength = lengths[anchor];
					lastIndex = anchor;
				}
			}
			List<int> longestIncreasingSubsequence = new List<int>();
			while(lastIndex != -1)
			{
				longestIncreasingSubsequence.Add(nums[lastIndex]);
				lastIndex = previous[lastIndex];
			}
			longestIncreasingSubsequence.Reverse();

			return longestIncreasingSubsequence;
		}
	}
}
