using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int N)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        var binary = Convert.ToString(N, 2);
        Console.Error.WriteLine(binary);
        var start = -1;
        var end = -1;
        var gap = 0;
        var maxGap = 0;
        for (var i = 0; i < binary.Length; i++)
        {
            Console.Error.WriteLine($"binary: {binary[i]}");
            if (binary[i] == '1')
            {
                Console.Error.WriteLine($"start: {start}");
                if (start == -1)
                {
                    start = i;
                    continue;
                }
                end = i;
                gap = end - start - 1;
                start = end;

                Console.Error.WriteLine($"start: {start}, end: {end}");
                maxGap = Math.Max(maxGap, gap);
            }
        }
        return maxGap;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var problem = new Solution();
        Console.WriteLine(problem.solution(n));
    }
}
