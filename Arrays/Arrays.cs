namespace Arrays
{   
    public class Program
    {
        public static void Main(string[] args)
        {
            //Syntax 
            //datatype[] variable_name = new datatype[size];

            //Q : store 5 roll numbers;
            int[] rollno = new int[5];
            //or directly we can also 
            int[] rollno1 = {1,2,3,4,5};

            int[] ros; //declaration of array here ros is getting defined in the stack memory
            ros = new int[5]; //here object is being created in the heap memory
            
            System.Console.WriteLine(ros[1]);//Outputs 0 
            
            String[] arr = new String[5];
            
            System.Console.WriteLine(arr[0]);

        }
    }
}