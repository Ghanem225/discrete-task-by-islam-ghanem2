using System;

namespace Project
{
    public class PerfectNumber
    {
        public static void Main()
        {
            int d, q, sum;
            int start, end;

            Console.Write("Start : ");
            start = int.Parse(Console.ReadLine());
            Console.Write("End : ");
            end = int.Parse(Console.ReadLine());

            for (d = start; d <= end; d++)
            {
                q = 1;
                sum = 0;
                while (q < d)
                {
                    if (d % q == 0)
                        sum = sum + q;
                    q++;
                }
                if (sum == d)
                    Console.WriteLine(d);
            }
        }
    }
}