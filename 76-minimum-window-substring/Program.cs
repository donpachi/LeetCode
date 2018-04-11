using System;

namespace _76_minimum_window_substring
{
    class Program
    {
        public string MinWindow(string s, string t) {
            int[] charMap = new int[128];
            foreach(char c in t) charMap[c]++;
            int start = 0, end = 0, tHit = t.Length, minLen = Int32.MaxValue, head = 0;
            while (end < s.Length){
                char c = s[end];
                if(charMap[c] > 0){ //if we found a char in T
                    tHit--;
                }
                charMap[c]--;
                end++;
                while(tHit == 0){   //when we've found a valid subsequence, compare lengths, and then remove the LRU char in T
                    if(end - start < minLen){
                        minLen = end-start;
                        head = start;                    
                    }
                    c = s[start];
                    if(charMap[c] == 0){    //any char hit whos value is 0 at this point is a value in T, we've hit a key in T, increment hit counter
                        tHit++;
                    }
                    charMap[c]++;
                    start++;
                }
            }
            return minLen == Int32.MaxValue ? "" : s.Substring(head, minLen);
        }

        static void Main(string[] args)
        {
        }
    }
}
