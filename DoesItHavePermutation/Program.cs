using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItHavePermutation
{
    class Program
    {
        static void Main(string[] args)
        {
           CheckIfPermutationContains("baba", "abab");
        }
     
        public static bool CheckIfPermutationContains(string v1,string v2)
        {
             List<string> l1 = new List<string>();
             List<string> l2 = new List<string>();

            GetEveryPermutation(ref v1, ref l1);
            GetEveryPermutation(ref v2, ref l2);
        
            if(l1.Contains(v2) || l2.Contains(v1))
                return true;

            return false;
          
        }

       public static void GetEveryPermutation(ref string str,ref List<string> target)
        {
            Permutation _permutation = new Permutation();
            for (int i = 1; i <= str.Length; i++)
            {             
                _permutation.permute(str.ToCharArray(), str.Length, i,ref target);
            }
        }
    }

    public class Permutation
    {
        
        public void ConvertToLenthBase(int n, char[] arr, int len, int L, ref List<string> target)
        {
            StringBuilder row = new StringBuilder();
            for (int i = 0; i < L; i++)
            {
                row.Append(arr[n % len]);
                n /= len;
            }
            target.Add(row.ToString());
   
        }

        public void permute(char[] arr, int len, int L,ref List<string> target)
        {
            for (int i = 0; i < (int)Math.Pow(len, L); i++)
            {
           
                ConvertToLenthBase(i, arr, len, L,ref target);
            }
        }
    }

    public class TestHelper
    {
        public bool CheckIfDoesContainPermutation(string param1,string param2)
        {
           return Program.CheckIfPermutationContains(param1,param2);
        }
    }
}
