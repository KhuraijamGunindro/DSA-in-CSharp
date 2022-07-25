namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This is a C# program to showcase how 2D arrays are made in C#
            /*
              1 2 3
              4 5 6
              7 8 9
             */
            
            var arr = new int[3,3];
            //var arr = {{1,2,3},{4,5,6},{7,8,9}};
            //Input of array elements in C#
            for(int row = 0;row<arr.GetLength(0);row++)
            {
                for(int col= 0; col < arr.GetLength(1); col++)
                {
                    arr[row,col]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int row = 0;row<arr.GetLength(0);row++)
            {
                for(int col=0;col<arr.GetLength(1);col++)
                {
                    Console.Write(arr[row,col]+ " ");
                }
                Console.WriteLine();
            }
            //arr.GetLength(0)-->Gives the number of rows in 2D array
            //arr.GetLength(1)-->Gives the number of elements in a row
        }
    }
}