using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapping_Rain_Water
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] height = new int[] {0,1,0,2,1,0,1,3,2,1,2,1};
            PrintResults(height, RunDoublePointer(height));
            height = new int[] { };
            PrintResults(height, RunDoublePointer(height));
            height = new int[] { 9, 0, 0, 8, 0, 0, 9 };
            PrintResults(height, RunDoublePointer(height));
            height = new int[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 };
            PrintResults(height, RunDoublePointer(height));
            Console.ReadKey();
        }


        static void PrintResults(int[] height, int ans)
        {
            Console.WriteLine(string.Join(",", height) + " returns " + ans);
        }
        /*
         * Given n non-negative integers representing an elevation map 
         * where the width of each bar is 1, compute how much water it 
         * is able to trap after raining. 
         * For example, Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
         */
        static int RunDoublePointer(int[] height)
        {
            return new TwoPointerTrap().Trap(height);
        }
    }
}
