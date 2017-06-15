using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			int[] bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int bombNum = bomb[0];
			int power = bomb[1]; 

			for (int i = 0; i < nums.Count; i++)
			{
				int currentNum = nums[i];
				if (currentNum == bombNum)
				{
					int leftIndex = Math.Max(i - power, 0);
					int rightIndex = Math.Min(i + power, nums.Count - 1);
					int removeCount = rightIndex - leftIndex + 1;
					nums.RemoveRange(leftIndex, removeCount);
					i = -1;
				}
			}
			Console.WriteLine(nums.Sum());
		}
	}
}
