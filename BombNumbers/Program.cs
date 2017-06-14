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
			List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
			long[] bomb = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
			long bombNum = bomb[0];
			int power = (int)bomb[1];

			for (int i = 0; i < nums.Count; i++)
			{
				if (nums[i] == bombNum)
				{
					for (int j = 0; j < power * 2 + 1; j++)
					{
						if (i - power + j >= 0)
						{
							if (i - power < nums.Count)
							{
								if (i - power >= 0)
								{
									nums.Remove(nums[i - power]);
								}
								else if (nums.Count > 0)
								{
									nums.Remove(nums[0]);
								}
							}
						}
					}
				}
			}
			Console.WriteLine(nums.Sum());
		}
	}
}
