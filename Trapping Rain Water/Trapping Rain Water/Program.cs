using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapping_Rain_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProg = new Program();
            int[] height = new int[] {0,1,0,2,1,0,1,3,2,1,2,1};
            Console.WriteLine(string.Join(",", height) + " returns " + myProg.Trap(height));
        }

        /*
         * Given n non-negative integers representing an elevation map 
         * where the width of each bar is 1, compute how much water it 
         * is able to trap after raining. 
         * For example, Given [0,1,0,2,1,0,1,3,2,1,2,1], return 6.
         */
        public int Trap(int[] height)
        {

        }
    }
}
