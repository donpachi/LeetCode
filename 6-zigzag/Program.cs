using System;
using System.Text;

namespace _6_zigzag
{
    class Program
    {

        public string Convert(string s, int numRows) {
            if (string.IsNullOrEmpty(s) || numRows <= 0) return "";
            if (numRows >= s.Length) return s;
            StringBuilder[] builders = new StringBuilder[numRows];
            for(int i = 0; i < numRows; i++) builders[i] = new StringBuilder();
            int index = 0;
            while (index < s.Length){
                for(int i = 0; i < builders.Length && index < s.Length; i++){
                    builders[i].Append(s[index++]);
                }
                for(int j = numRows - 2; j >= 1 && index < s.Length; j--){
                    builders[j].Append(s[index++]);
                }
            }
            StringBuilder sb = new StringBuilder();
            foreach(StringBuilder b in builders){
                sb.Append(b.ToString());
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Convert("GOOGLEISHIRING", 3));
        }
    }
}
