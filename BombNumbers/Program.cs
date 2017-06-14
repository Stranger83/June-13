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
				if (nums[i] == bombNum)
				{
					if (i + power < nums.Count - 1 && i - power >= 0)
					{
						for (int j = 0; j < power * 2 + 1; j++)
						{
							nums.Remove(nums[i - power]);
						}
					}
					else if (i + power >= nums.Count - 1)
					{
						for (int j = 0; j < nums.Count; j++)
						{
							nums.Remove(nums[i - power]);
						}
						nums.Remove(nums[nums.Count - 1]);
					} else if (i - power < 0)
					{
						for (int k = 0; k < power + 1; k++)
						{
							nums.Remove(nums[0]);
						}
					}
				}
			}
			Console.WriteLine(nums.Sum());
		}
	}
}
