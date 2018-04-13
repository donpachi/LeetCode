using System;
using System.Collections.Generic;

namespace _247_strobo_number_ii
{
    class Program
    {
        public IList<string> FindStrobogrammatic(int n) {
            return HelperStrob(n, n);        
        }
    
    public IList<string> HelperStrob(int currLen, int targetLen){
        //base cases
        if(currLen <= 0) return new List<string>(){""};
        if(currLen == 1) return new List<string>(){"0","1","8"};
        
        IList<string> list = HelperStrob(currLen - 2, targetLen);
        List<string> newList = new List<string>();
        foreach(string s in list){
            if (currLen < targetLen){   //if we'haven't reached full string yet, we can use 0's
                newList.Add("0" + s + "0");
            }
            newList.Add("1" + s + "1");
            newList.Add("6" + s + "9");
            newList.Add("8" + s + "8");
            newList.Add("9" + s + "6");
        }
        return newList;
    }
        static void Main(string[] args)
        {
            Program p = new Program();
            foreach (string s in p.FindStrobogrammatic(3)){
                Console.Write(s + " ");
            }
        }
    }
}
