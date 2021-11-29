using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOperation
{
    public class ArrayOp
    {
        public static int[] Fix(int length, int minVal = -10,int maxVal = 10)
        {
            int[] arr = new int[length];
            Random rand = new Random();

            for (int i=0;i<arr.Length;i++)
            {
                arr[i] = rand.Next(minVal,maxVal);

            }
            return arr;
        }
        public static int SumNeg(int []arr)
        {
            int sumneg = 0;
            for (int i = 0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                    sumneg += arr[i];
            }
            return sumneg;
                
        }
        public static int PairedMax(int[] arr)
        {
            int maxpair=-500;
            int k = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] % 2 == 0 && arr[i] != 0)
                {

                    if (maxpair < arr[i])
                    {
                        maxpair = arr[i];
                    }
                }
            }
            
            return maxpair;

        }
        public static int DobParied(int[] arr)
        {
            
            int dob = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if(i%2==0&&i!=0)
                {
                    dob*= arr[i];
                }
            }

            return dob;
        }
        public static int IndxeMaxvalue(int[] arr)
        {
            int maxind = arr[0];
            int index = 0;
            for (int i = 1; i < arr.Length; i++)
            {

                if (maxind < arr[i])
                {
                    maxind = arr[i];
                    index = i;
                }
               
            }
                return index;
        }
        public static int MaxModElement(int[]arr)
        {
            
            int max = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                
                arr[i] = Math.Abs(arr[i]);
                if (arr[i]>max)
                {
                    max = arr[i];
                    
                }
                
            }
                return max;
        }
        public static int SumIndexPositive(int[] arr)
        {

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    sum += i;
            }

            return sum;
        }
        public static int numderNoPaired(int[] arr)
        {

            int n = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                    n++;
                else if(n==0) n = 0;
            }

            return n;
        }

    }
}
