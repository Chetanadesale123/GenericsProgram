using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProgram
{
    public class PrintArray
    {
        public void MaxElement(int[] arr)
        {
            int i;
            int max = arr[0];
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            Console.WriteLine("Maximum in given " + "array is " + max);
        }
        public void MaxElement(float[] arr1)
        {
            int i;
            float max = arr1[0];
            for (i = 1; i < arr1.Length; i++)
                if (arr1[i] > max)
                {
                    max = arr1[i];
                }
            Console.WriteLine("Maximum in given " + "array is " + max);
        }
        public void MaxElement(string[] arr2)
        {
            int max_str = arr2[0].Length;
            string ans = arr2[0];
            for (int i = 1; i < arr2.Length; i++)
            {
                int maximum = arr2[i].Length;
                if (maximum > max_str)
                {
                    ans = arr2[i];
                    max_str = maximum;
                }
            }
            Console.WriteLine("Maximum in given " + "array is " + ans);
        }
    }
}
