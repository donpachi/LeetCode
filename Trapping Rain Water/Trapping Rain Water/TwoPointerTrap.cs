using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapping_Rain_Water
{
    public class TwoPointerTrap
    {
        public int Trap(int[] height)
        {
            if (height.Length == 0) return 0;
            int leftMax = 0;
            int rightMax = 0;
            int ans = 0;
            for (int left = 0, right = height.Length - 1; left < right;)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        ans += (leftMax - height[left]);
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        ans += (rightMax - height[right]);
                    right--;
                }
            }
            return ans;
        }
    }
}
