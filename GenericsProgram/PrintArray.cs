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
    }
}
