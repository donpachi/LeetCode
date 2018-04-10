using System;

namespace _3_max_substring_norepeats
{
    class Program
    {
        public int LengthOfLongestSubstring(string s) {
            int[] map = new int[128];   //assume ascii, can switch to LRU style hashmap of chars and their oldest indices
            int left = 0;
            int right = 0;
            int max = 0;
            while (right < s.Length){
                map[s[right]]++;
                if(map[s[right]] > 1){ //repeat char, increment left pointer
                    if (right - left > max){
                        max = right - left;
                    }
                    while (map[s[right]] > 1){
                        map[s[left]]--;
                        left++;
                    }
                }
                right++;
            }
            return Math.Max(max, right - left);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.LengthOfLongestSubstring("abchdeeh"));
            Console.WriteLine(p.LengthOfLongestSubstring("b"));
        }
    }
}
