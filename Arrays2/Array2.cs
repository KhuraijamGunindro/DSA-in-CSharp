using System;

namespace Arrays2{
    public class Program
    {
        //Array input in c#
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            //Array input using for loop
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            /*
            we can also do it by using foreach loop
            */
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine(String.Join(" ",arr));//The easiest way
        }
    }
}