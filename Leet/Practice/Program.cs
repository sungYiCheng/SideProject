﻿using System;
using System.Collections.Generic;

namespace Practice
{
	class Program
	{
		static void Main(string[] args)
		{
			Solution solution = new Solution();

			int[][] array = new int[2][];
			array[0] = new int[2] { 3, 3};
            array[1] = new int[2] { 3, 3};
            //array[2] = new int[3] { 2, 7, 7 };


            var ans = solution.DecodeString("3[a]2[bc]");

			Console.WriteLine($"ans:{ans}");
		}

	}
}
