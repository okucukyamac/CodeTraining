using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTraining
{
    public class LeetCode
    {
        public static bool HappyNumber(int n)
        {

            //https://leetcode.com/problems/happy-number/

            HashSet<int> seenNumbers = new HashSet<int>();

            while (n > 1)
            {
                int current = n;
                int sum = 0;
                while (current > 0)
                {
                    sum += (int)Math.Pow(current % 10, 2);
                    current /= 10;
                }

                if (seenNumbers.Contains(sum))
                {
                    return false;
                }

                seenNumbers.Add(sum);

                Console.WriteLine(sum);

                n = sum;
            }

            return true;

        }
    }
}
