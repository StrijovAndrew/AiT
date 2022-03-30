using System;

namespace Timus
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int M;

            string s = Console.ReadLine();
            string[] nums = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            N = Convert.ToInt32(nums[0]);
            M = Convert.ToInt32(nums[1]);
            int output = N * M;
            Console.WriteLine(output);
        }
    }
}