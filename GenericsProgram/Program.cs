using GenericsProgram;
using System;
class Program
{
    static void Main(String[] args)
    {
        int[] arr = { 10, 324, 45, 90, 980 };
        float[] arr1 = { 1.5f, 7.9f, 20.6f, 18.23f, 45.2f };
        PrintArray array = new PrintArray();
        array.MaxElement(arr);
        array.MaxElement(arr1);

    }
}
