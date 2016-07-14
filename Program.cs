using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            var digits = new List<string> {"1", "2", "3", "4", "5", "6", "7", "8", "9"};

            var permutations = new int[9];
            permutations[1] = 40320; // 8!
            permutations[2] = 5040;  // 7!
            permutations[3] = 720;   // 6!
            permutations[4] = 120;   // 5!
            permutations[5] = 24;    // 4!
            permutations[6] = 6;     // 3!
            permutations[7] = 2;     // 2!
            permutations[8] = 1;     // 1!

            var permutation = 99999;

            StringBuilder sb = new StringBuilder();
            for (var i = 1; i < 9; i++)
            {
                // Get this digit
                var digit = digits[permutation/permutations[i]];

                // Remove digit from list
                digits.Remove(digit);

                // Update the remaining permutaions
                permutation %= permutations[i];

                // Add digit to output string
                sb.Append(digit.ToString());
            }
            sb.Append(digits[0]);

            sw.Stop();

            Console.WriteLine("Answer: " + sb.ToString() + " Elapsed time: " + sw.Elapsed);

            Console.ReadLine();
        }

    }
}
