﻿using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < N; i++)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int calcResult = input[0] == input[1]
                ? input[0] * input[1]
                : input[0] + input[1];
            result += calcResult;
        }
        Console.WriteLine(result);
    }
}