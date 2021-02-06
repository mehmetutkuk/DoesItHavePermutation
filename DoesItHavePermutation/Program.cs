using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItHavePermutation
{
    class Program
    {
        static List<string> l1, l2;
        
        static void Main(string[] args)
        {
           CheckIfPermutationContain("baba", "abab");
        }
     
        public static bool CheckIfPermutationContain(string v1,string v2)
        {
            l1 = new List<string>();
            l2 = new List<string>();

            getEveryPermutation(ref v1, ref l1);
            getEveryPermutation(ref v2, ref l2);
        
       
            if(l1.Contains(v2))
                return true;
            
            if (l2.Contains(v1))
                return true;


            return false;
          
        }

       public static void getEveryPermutation(ref string str,ref List<string> target)
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

    public class Main
    {
        public bool CheckIfDoesContainPermutation(string param1,string param2)
        {
           return Program.CheckIfPermutationContain(param1,param2);
        }
    }
}
