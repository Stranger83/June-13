using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int bestLength = 1;
			int bestPos = 0;
			int currentBestLenght = 1;
			for (int pos = 0; pos < nums.Count; pos++)
			{
				if (pos < nums.Count - 1 && nums[pos] == nums[pos + 1])
				{
					currentBestLenght++;
				}
				else
				{
					currentBestLenght = 1;
				}

				if (currentBestLenght > bestLength)
				{
					bestLength = currentBestLenght;
					bestPos = pos;
				}

			}
			for (int i = 0; i < bestLength; i++)
			{
				Console.Write($"{nums[bestPos]} ");
			}
			Console.WriteLine();
		}
	}
}
